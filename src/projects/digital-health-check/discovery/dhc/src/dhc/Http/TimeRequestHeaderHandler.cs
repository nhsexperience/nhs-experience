using Polly;
using Prometheus.HttpClientMetrics;
using System.Diagnostics;

namespace dhc;

public class TimeRequestHeaderHandler<T> : DelegatingHandler
{
    private static readonly Counter _c_client_failures =
        Metrics.CreateCounter("httpclient_request_failures_count", "Failures for a client",
         new CounterConfiguration
         {
             // Here you specify only the names of the labels.
             LabelNames = new[] { "client", "method", "path" }
         });

    private Type type;
    ILogger<T> _logger;

    HttpClientIdentity _identity;
    public TimeRequestHeaderHandler(ILogger<T> logger, HttpClientIdentity identity)
    {
        type = typeof(T);
        _logger = logger;
        _identity = identity;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Context context = request.GetPolicyExecutionContext();

        Stopwatch sw = Stopwatch.StartNew();
        var retries = 0;
        if (context.ContainsKey("totalRetries"))
        {
            retries = (int)context["totalRetries"];
        }

        var retryWaitTime = TimeSpan.Zero;
        if (context.ContainsKey("retryWaitTime"))
        {
            retryWaitTime = (TimeSpan)context["retryWaitTime"];
        }


        try
        {

            var res = await base.SendAsync(request, cancellationToken);

            var requestElapsed = sw.ElapsedMilliseconds;
            var elapsed = requestElapsed;
            if (context.ContainsKey("totalTimeElapsed"))
            {
                var existingE = (long)context["totalTimeElapsed"];
                elapsed = existingE + elapsed;
            }
            elapsed = elapsed + retryWaitTime.Milliseconds;
            context["totalTimeElapsed"] = elapsed;


            _logger.LogInformation("Client {client} fnished after {requestTime} ms (total request time after {attempts} attempts is {totalRequestsTime} ms) for {request}", type.FullName, requestElapsed, (retries + 1), elapsed, request.RequestUri.LocalPath);
            return res;
        }
        catch (Exception)
        {
            _c_client_failures.WithLabels(_identity.Name, request.Method.Method, request.RequestUri.LocalPath).Inc();
            var requestElapsed = sw.ElapsedMilliseconds;
            var elapsed = requestElapsed;
            if (context.ContainsKey("totalTimeElapsed"))
            {
                var existingE = (long)context["totalTimeElapsed"];
                elapsed = existingE + elapsed;
            }
            elapsed = elapsed + retryWaitTime.Milliseconds;
            context["totalTimeElapsed"] = elapsed;

            _logger.LogWarning("Client {client} errored after {requestTime} ms (total request time after {attempts} attempts is {totalRequestsTime} ms) for {request}", type.FullName, requestElapsed, (retries + 1), elapsed, request.RequestUri.LocalPath);
            throw;
        }
    }
}

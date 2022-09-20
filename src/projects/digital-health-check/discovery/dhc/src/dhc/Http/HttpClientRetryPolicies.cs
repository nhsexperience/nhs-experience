using Polly;
using Polly.Extensions.Http;
using Polly.Contrib.WaitAndRetry;

namespace dhc;

public static class HttpClientRetryPolicies
{

    public static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy<ILoggerContext>(IServiceProvider serviceProvider)
    {
        var delay = Backoff.DecorrelatedJitterBackoffV2(medianFirstRetryDelay: TimeSpan.FromSeconds(1), retryCount: 10);

        return HttpPolicyExtensions
            .HandleTransientHttpError()
            .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
            .WaitAndRetryAsync(
                delay,
                onRetry: (outcome, timespan, retryAttempt, context) =>
                {
                    context["totalRetries"] = retryAttempt;
                    context["retryWaitTime"] = timespan;
                    serviceProvider.GetService<ILogger<ILoggerContext>>()
                        .LogWarning("Delaying for {delay}ms, then making retry {retry}.", timespan.TotalMilliseconds, retryAttempt);
                }
            );
    }
}

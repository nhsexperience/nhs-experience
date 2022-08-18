using Prometheus.HttpClientMetrics;

namespace dhc;

public static class TimeRequestHandlerExtensionMethods
    {
        public static IHttpClientBuilder AddTimerAndLoggerHandler<ILoggerContext>(this IHttpClientBuilder builder)
        {
            var identity = new HttpClientIdentity(builder.Name);
            return builder.AddHttpMessageHandler(x =>
            {
                var l = x.GetService<ILogger<ILoggerContext>>();
                var h = new TimeRequestHeaderHandler<ILoggerContext>(l, identity);
                return h;
            });
        }
    }

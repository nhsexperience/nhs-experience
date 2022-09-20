public class SampleHealthCheck : Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck
{
    public Task<Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult> CheckHealthAsync(
        Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        var isHealthy = true;

        // ...

        if (isHealthy)
        {
            return Task.FromResult(
                Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy("A healthy result."));
        }

        return Task.FromResult(
            new Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult(
                context.Registration.FailureStatus, "An unhealthy result."));
    }
}
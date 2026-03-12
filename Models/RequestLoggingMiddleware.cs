using System.Diagnostics;

namespace WebApplication1.Models
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly ILogger _logger;
        public RequestLoggingMiddleware(RequestDelegate requestDelegate, ILogger<RequestLoggingMiddleware> logger)
        {
            _requestDelegate = requestDelegate;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            _logger.LogInformation($"Request: {context.Request.Method} {context.Request.Path} ");
            await _requestDelegate(context);
            stopwatch.Stop();
            _logger.LogInformation($"Response Status: {context.Response.StatusCode} Time: {stopwatch.ElapsedMilliseconds} ms");

            _logger.LogInformation(
            "HTTP {Method} {Path} responded {StatusCode} in {Elapsed} ms",
            context.Request.Method,
            context.Request.Path,
            context.Response.StatusCode,
            stopwatch.ElapsedMilliseconds
);

        }
    }
}

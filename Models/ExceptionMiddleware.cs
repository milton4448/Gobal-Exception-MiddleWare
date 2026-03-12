using System.Text.Json;

namespace WebApplication1.Models
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        public ExceptionMiddleware(RequestDelegate next,ILogger <ExceptionMiddleware> ilogger)
        {
            _next = next;
            _logger = ilogger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
            //    _logger.LogError(ex, "An unhandled exception has occurred while executing the request.");
            //    context.Response.StatusCode = 500;
            //    context.Response.WriteAsJsonAsync(new{
            //        message= "Internal Server Error"

            //    });
                 await HandleExceptionAsync(context, ex);
            }


        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            _logger.LogError(ex, "An unhandled exception has occurred while executing the request.");
            context.Response.ContentType = "application/json";
            context.Response.StatusCode =(int) StatusCodes.Status500InternalServerError;
            var result = JsonSerializer.Serialize(new
            {
                StatusCode = context.Response.StatusCode,
                Message = "Internal Server Error",
                Detail = ex.Message
            });

            return context.Response.WriteAsync(result);
        }
    }
}

namespace DotNetMiddleware.Web.Middlewares;

public class MyCustomMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public MyCustomMiddleware(RequestDelegate next, ILoggerFactory logFactory)
    {
        _next = next;
        _logger = logFactory.CreateLogger("MyCustomMiddleware");
    }

    public async Task Invoke(HttpContext httpContext)
    {
        _logger.LogInformation("MyCustomMiddleware executing ...");
        await _next(httpContext);
    }
}
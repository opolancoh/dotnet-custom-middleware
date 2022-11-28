using DotNetMiddleware.Web.Middlewares;

namespace DotNetMiddleware.Web.Extensions;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MyCustomMiddleware>();
    }
}
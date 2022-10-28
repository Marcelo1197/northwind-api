using NorthwindAPI.Common.Middlewares;

namespace NorthwindAPI.Common.Extensions
{
    public static class ApiExtensions
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}

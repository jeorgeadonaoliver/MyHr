namespace myHr.api.Middleware;

public class HeaderLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public HeaderLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var userAgent = context.Request.Headers["User-Agent"];
        Console.WriteLine($"User-Agent: {userAgent}");

        await _next(context);
    }
}

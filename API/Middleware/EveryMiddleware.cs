namespace API.Middleware;

public class EveryMiddleware
{
    readonly RequestDelegate _next;
    public EveryMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await context.Response.WriteAsync("lolol");
            await _next(context);
        }
        catch(Exception ex)
        {
            await context.Response.WriteAsync("every request lol");
        }

    }

}

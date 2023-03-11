
namespace Microsoft.AspNetCore.Builder;

public static class RegisterEnpoints
{
    public static WebApplication RegisterMapEnpoints(this WebApplication app)
    {
        app.MapGet("/user", () => "hello");
        return app;
    }

}


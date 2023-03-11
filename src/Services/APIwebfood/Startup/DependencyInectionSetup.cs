
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using webfood.Services;


//namespace Microsoft.Extensions.DependencyInjection;
namespace Microsoft.AspNetCore.Builder;
public static class DependencyInectionSetup
{
    /// <summary>
    /// Add Dependency
    /// </summary>
    /// <param name="Services"></param>
    /// <returns>Services added</returns>
	public static WebApplicationBuilder RegisterService(this WebApplicationBuilder builder)
    {
        //Create Config
        //IConfiguration config = new ConfigurationBuilder()
        //      .SetBasePath(Directory.GetCurrentDirectory())
        //      .AddJsonFile("appsettings.json")
        //      .Build();

        builder.Services.AddControllers(); 
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        //builder.Services.AddDbContext<WebFoodDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connect")));
        //builder.Services.AddScoped<WebFoodDbContext>();
        builder.Services.AddTransient<ICategoryService,CategoryService>();
        //builder.Services.AddSingleton<IConfiguration>(config);

        return builder;
    }
}

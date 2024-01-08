// Startup.cs
using food_web_project.Models.Tables;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using food_web_project.Models;

public class Startup
{
    // ... (other methods)

    public void ConfigureServices(IServiceCollection services)
    {
      
        services.AddScoped<Customer>();

        // ... (other services)
    }

    // ... (other methods)
}

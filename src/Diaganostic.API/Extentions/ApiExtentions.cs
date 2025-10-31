using Serilog;
using Serilog.Filters;

namespace Diaganostic.API.Extentions;

public static class ApiExtentions
{
    public static IServiceCollection AddSerilogExtention(this IServiceCollection serviceCollection, IWebHostEnvironment environment, IConfiguration configuration)
    {
       return serviceCollection.AddLogging(b => b.AddSerilog(new LoggerConfiguration()
            .MinimumLevel.Information()
            .Filter.ByExcluding(Matching.FromSource("Microsoft"))
            .WriteTo.Console()
            .WriteTo.OpenSearch(configuration.GetConnectionString("openSearch"))
            .CreateLogger())); 
    }
}
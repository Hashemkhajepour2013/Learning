using Autofac.Extensions.DependencyInjection;
using WebApplication1;

public class Program
{
    public static async Task Main(string[] args)
    {
            await CreateHostBuilder(args).Build().RunAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureLogging(options => options.ClearProviders())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
}
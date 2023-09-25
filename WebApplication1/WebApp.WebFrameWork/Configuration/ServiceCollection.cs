using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.WebFrameWork.Configuration
{
    public static class ServiceCollection
    {
        public static void AddMinimalMvc(this IServiceCollection services)
        {
            services.AddControllers();
        }

        public static void AddCustomApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });
        }
    }
}

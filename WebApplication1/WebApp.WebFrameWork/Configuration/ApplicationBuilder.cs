using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WebApp.WebFrameWork.Configuration
{
    public static class ApplicationBuilder
    {
        public static IApplicationBuilder UseHsts(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
                app.UseHsts();

            return app;
        }
    }
}

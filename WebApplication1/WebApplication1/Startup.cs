using WebApp.Data;
using WebApp.Data.UnitOfWork;
using WebApp.Data.UnitOfWork.Contracts;
using WebApp.Data.Users;
using WebApp.Data.Users.Contracts;
using WebApp.Services.Users;
using WebApp.Services.Users.Contracts;
using WebApp.WebFrameWork.Configuration;
using WebApp.WebFrameWork.Swagger;

namespace WebApplication1
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMinimalMvc();
            services.AddCustomApiVersioning();
            services.AddSwagger();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHsts(env);

            app.UseHttpsRedirection();

            app.UseSwaggerAndUI();

            app.UseRouting();


            app.UseEndpoints(config =>
            {
                config.MapControllers();
            });
        }
    }
}

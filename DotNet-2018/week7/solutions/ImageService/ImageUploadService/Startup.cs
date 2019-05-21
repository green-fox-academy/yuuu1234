using ImageUploadService.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ImageUploadService
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(a => new StorageAccountWrapper(configuration.GetConnectionString("AzureStorage")));
            services.AddTransient<IMessageQueueService, MessageQueueService>();
            services.AddTransient<IMessageQueueService, MessageQueueService>();
            services.AddTransient<IImageUploadService, Services.ImageUploadService>();
            services.AddTransient<IImageService, ImageService>();
            services.AddMvc();

            services.AddDbContext<ApplicationContext>(builder =>
                {
                    builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}

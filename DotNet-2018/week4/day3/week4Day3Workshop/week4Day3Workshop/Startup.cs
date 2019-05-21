using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using week4Day3Workshop.Interfaces;
using week4Day3Workshop.Middlewares;
using week4Day3Workshop.Models;
using week4Day3Workshop.Services;
using week4Day3Workshop.Services.Student;

namespace week4Day3Workshop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ConsoleLoggerMiddleware>();
            services.AddTransient<IPrinter,Printer>();           
            //services.AddTransient<IColor, BlueColor>();
            services.AddTransient<IColor, RedColor>();
            services.AddTransient<UtilityService>();
            services.AddTransient<StudentService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMiddleware<ConsoleLoggerMiddleware>();
            //app.UseMiddleware<ConsoleLoggerMiddleware>();
            app.UseMvc();

            app.Run(async (context) => { await context.Response.WriteAsync("Hello World!"); });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyFirstWebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            /*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            */
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvc();

        }
    }

  
    public class Middleware
    {
        private readonly RequestDelegate next;
        private readonly string name;
        public Middleware(RequestDelegate next, string name)
        {
            this.next = next;
            this.name = name;
        }

        public Task Invoke(HttpContext context)
        {
            next.Invoke(context);
            return context.Response.WriteAsync($"Hi from middleware{name} \n");
        }

        public Task invoke2(HttpContext context)
        {
            next.Invoke(context);
            return context.Response.WriteAsync($"Hello from middleware{name} \n");
        }
    }
}

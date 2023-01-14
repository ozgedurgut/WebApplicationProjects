using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
     
        public void ConfigureServices(IServiceCollection services)
        {
            // add for MVC 
            // In order to use MVC architecture in Asp.net application, Controller and View configurations must be added in the application.
            // for this, first of all, the below serbis must be added to the application. So the application will exhibit MVC behavior.
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // the route of the incoming request is determined by this middleware.
            app.UseRouting();

            // Endpoint: The destination of the request. Here we will let you know which routes/templates the requests coming to this application can come with.
            app.UseEndpoints(endpoints =>
            {
                /*   endpoints.MapGet("/", async context =>
                   {
                       await context.Response.WriteAsync("Hello World!");
                   });
                */
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}

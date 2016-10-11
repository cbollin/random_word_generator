using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;

namespace ninjagold2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession();
        }
        public void Configure(IApplicationBuilder App)
        {
            Console.WriteLine("Start up cs found!");
            App.UseStaticFiles(); // how we include images, javascript, or any other static files other than views.
            App.UseSession();
            App.UseMvc();
        }
    }
}
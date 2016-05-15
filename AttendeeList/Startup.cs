using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace AttendeeList
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WorkshopContext>(options => options.UseInMemoryDatabase());

            services.AddMvc(options => options.OutputFormatters.Add(new VCardFormatter()));
        }
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseFileServer();

            app.UseMvc();
        }
    }
}

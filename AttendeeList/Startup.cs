using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AttendeeList
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WorkshopContext>(options => options.UseSqlite("Data Source=attendees.db"));

            services.AddMvc(options => options.OutputFormatters.Add(new VCardFormatter()));
        }
        
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Debug);

            app.UseFileServer();

            app.UseMvc();
        }
    }
}

using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace AttendeeList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseKestrel()
                            .ConfigureLogging(loggerFactory =>
                            {
                                loggerFactory.AddConsole(LogLevel.Debug);
                            })
                            .UseStartup<Startup>()
                            .Build();

            host.Run();
        }
    }
}

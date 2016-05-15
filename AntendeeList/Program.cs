using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
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

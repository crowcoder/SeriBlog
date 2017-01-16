using SeriBlogger;
using Serilog;
using System;

namespace SeriBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.StealthConsoleSink()
                .CreateLogger();

            var loggedby = new { Name = Environment.UserName, Time = DateTimeOffset.Now };

            Log.Information("Testing Stealth Console Sink {@loggedby}", loggedby);

            Console.ReadKey();
        }
    }
}

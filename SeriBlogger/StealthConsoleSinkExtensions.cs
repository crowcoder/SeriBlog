using Serilog;
using Serilog.Configuration;
using System;

namespace SeriBlogger
{
    public static class StealthConsoleSinkExtensions
    {
        public static LoggerConfiguration StealthConsoleSink(this LoggerSinkConfiguration loggerConfiguration,
            IFormatProvider fmtProvider = null)
        {
            return loggerConfiguration.Sink(new StealthConsoleSink(fmtProvider));
        }
    }
}

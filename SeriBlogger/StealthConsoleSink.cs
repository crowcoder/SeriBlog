using Serilog.Core;
using Serilog.Events;
using System;

namespace SeriBlogger
{
    public class StealthConsoleSink : ILogEventSink
    {
        IFormatProvider _formatProvider;

        public StealthConsoleSink(IFormatProvider formatProvider)
        {
            _formatProvider = formatProvider;
        }

        public void Emit(LogEvent logEvent)
        {
            //Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(logEvent.RenderMessage(_formatProvider));
            Console.ResetColor();
        }
    }
}

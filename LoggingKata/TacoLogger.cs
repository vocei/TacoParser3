using System;

namespace LoggingKata
{
    public class TacoLogger : ILog
    {
        public void LogFatal(string log, Exception exception = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fatal: {log}, Exception {exception}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void LogError(string log, Exception exception = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {log}, Exception {exception}");
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }

        public void LogWarning(string log)
        {
            Console.WriteLine($"Warning: {log}");
        }

        public void LogInfo(string log)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Info: {log}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("....");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void LogDebug(string log)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Info: {log}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

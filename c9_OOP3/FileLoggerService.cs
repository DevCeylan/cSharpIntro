using System;

namespace c9_OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
}

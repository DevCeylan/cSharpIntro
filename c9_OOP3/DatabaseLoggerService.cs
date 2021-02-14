using System;
using System.Collections.Generic;
using System.Text;

namespace c9_OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}

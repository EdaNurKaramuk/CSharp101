using System;

namespace arayuzler_interface
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e log yazar.");
        }
    }
}
using System;

namespace arayuzler_interface
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}
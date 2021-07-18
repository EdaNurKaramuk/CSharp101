using System;

namespace arayuzler_interface
{
    public class LogManager : ILogger
    {
        public ILogger _logger; //ILogger interface'inin bir referansını oluşturuyoruz.
        public LogManager(ILogger logger)
        {
            this._logger = logger;
        }
        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Opp3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanı Loglandı");
        }
    }
}

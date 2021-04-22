using System;
using System.Collections.Generic;
using System.Text;

namespace Opp3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms gönderildi.");
        }
    }
}

using System;
using System.Collections.Generic;

namespace Opp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            SmsLoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,smsLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasitKrediManager }; //Liste oluşturduk

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           












            //IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Interface ler de o Interface yi implemente eden classın referansını tutabiliyor.
        }
    }
}

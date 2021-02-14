using System;
using System.Collections.Generic;

namespace c9_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICreditManager tasitKrediManager = new TasitKrediManager();
            ICreditManager konutKrediManager = new KonutKrediManager();
            // Interface; implement ettiği class ın referansını tutabilir.

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
           
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<ICreditManager> krediler = new List<ICreditManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnbilgilendirmesiYap(krediler);
        }
    }
}

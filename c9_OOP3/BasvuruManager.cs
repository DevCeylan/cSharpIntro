using System;
using System.Collections.Generic;
using System.Text;

namespace c9_OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap( ICreditManager creditManager, ILoggerService loggerService )
        {
            // Basvuran bilgilerini alma-degerlendirme
            // ...

            creditManager.Hesapla();
            loggerService.Log();

            // bu sekilde bir kullanım ile; gönderilen tip ne olursa olsun kendine ait olan
            // ilgili fonksiyon ile, kendi için belirlenmiş kurallar ile çalıştırılır.
            // böylece tipten bağımsız olur. (dependency)

        }
        public void KrediOnbilgilendirmesiYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }


    }
}

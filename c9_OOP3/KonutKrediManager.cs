using System;
using System.Collections.Generic;
using System.Text;

namespace c9_OOP3
{
    class KonutKrediManager : ICreditManager
    {
        public void AnyOperation()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi Odeme plani hesaplandi..");
        }
    }
}

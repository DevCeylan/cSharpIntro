using System;
using System.Collections.Generic;
using System.Text;

namespace c9_OOP3
{
    class IhtiyacKrediManager : ICreditManager
    {
        public void AnyOperation()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac Kredisi Odeme plani hesaplandi..");
        }
    }
}

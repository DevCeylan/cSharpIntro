using System;
using System.Collections.Generic;
using System.Text;

namespace c9_OOP3
{
    class TasitKrediManager : ICreditManager
    {
        public void AnyOperation()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Tasit kredisi Odeme plani hesaplandi..");
        }
    }
}

using System;

namespace c7_GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Mehmet");
        }
    }
}

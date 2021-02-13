using System;

namespace cSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int [] Numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // for-each:

            foreach (int item in Numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}

using System;
using System.Collections.Generic; // required for List<>

namespace c6_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists can be used for active(dynamic) memory allocation
            List<string> names = new List<string> { "Mehmet", "Ahmet", "Deniz" };
            Console.WriteLine(names[2]);
            names.Add("Seyda");
            Console.WriteLine(names[3]);
        }
    }
}

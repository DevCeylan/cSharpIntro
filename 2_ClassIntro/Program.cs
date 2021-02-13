using System;

namespace _2_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            product product1 = new product();

            product1.Name = "laptop";
            product1.Rate = 4;

        }
    }

    class product
    {
        public string Name { get; set; }
        public int Rate { get; set; }
    }

}

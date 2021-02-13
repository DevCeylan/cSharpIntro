using System;

namespace c7_GenericsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("One", 1);
            myDictionary.Add("Two", 2);
            myDictionary.Add("Three", 3);
            myDictionary.Add("Four", 4);
            myDictionary.Add("Five", 5);

        }
    }
}

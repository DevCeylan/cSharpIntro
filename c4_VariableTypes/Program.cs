using System;

namespace c4_VariableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 40;
            // number1 = ?? : 30

            int[] array1 = new int[] { 10, 20, 30 };
            int[] array2 = new int[] { 100, 200, 300 };
            array1 = array2;
            array2[0] = 919;
            // array1[0] = ?? : 919 

        }
    }
}

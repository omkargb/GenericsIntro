using System;
using System.Collections.Generic;
namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to generics program.");

            int[] arrayInt = { 1, 3, 5, 7, 9 };
            double[] arrayDouble = { 1.1, 2.3, 4.56, 7.890 };
            char[] arrayChar = { 'a', 'e', 'i', 'o', 'u' };

            Program.toPrint<int>(arrayInt);
            Program.toPrint<double>(arrayDouble);
            Program.toPrint<char>(arrayChar);
        }

        public static void toPrint<T>(T[] inputArray)
        {
            Console.Write("\n");
            foreach(var elem in inputArray)
            {
                Console.Write(" {0} ",elem);
            }
        }
    }
}

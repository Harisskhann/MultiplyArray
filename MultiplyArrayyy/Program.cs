using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyArray
{
    public class Program
    {
        static void Main()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            int length = myArray.Length;

            Console.WriteLine("Original array:");
            for (int i = 0; i < length; i++)
            {
                Console.Write(myArray[i]);

                if (i < length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                myArray[i] *= length;
            }

            Console.WriteLine("Array with elements multiplied by length:");
            for (int i = 0; i < length; i++)
            {
                Console.Write(myArray[i]);

                if (i < length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}

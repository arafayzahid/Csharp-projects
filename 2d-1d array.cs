using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2d Array:");

            int[,] a = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            int r = a.GetLength(0);
            int c = a.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();



            Console.WriteLine("Size of 1d Array is :");
            int[] b = new int[r * c];
            Console.WriteLine(b.GetLength(0));

            Console.WriteLine();

            Console.WriteLine("2d Array Converted into 1d Array :");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine(a[i, j]);
                }

            }
            Console.ReadKey();
        }
    }
}

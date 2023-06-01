using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r, c, i, j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            r = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());

            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] B = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix B: ");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(B[i, j] + "\t");

                }
                Console.WriteLine();
            }

            int[,] C = new int[10, 10];
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }

            Console.Write("\nDifference Matrix :");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

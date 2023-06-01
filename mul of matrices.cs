using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the matrices
            int[,] matrix1 = new int[2, 2] { { 8, 7 }, { 6, 10 } };
            int[,] matrix2 = new int[2, 2] { { 4, 3 }, { 2, 1 } };

            // Perform matrix multiplication
            int[,] result = new int[2, 2];

            result[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
            result[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
            result[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
            result[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];

            // Print the result
            Console.WriteLine("Matrix Multiplication Result:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); // Wait for the user to press enter
        }
    }
}

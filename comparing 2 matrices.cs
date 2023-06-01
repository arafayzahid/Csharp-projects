using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taking user input of matrices a & b rows & columns
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            int r = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());
            //making matrice A
            int[,] A = new int[2, 2];
            Console.Write("\nEnter The First Matrix : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            //making matrice B
            int[,] B = new int[2, 2];
            Console.Write("\nEnter The Second Matrix:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            //printing matrice A
            Console.WriteLine("\nMatrix A : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }
            //printing matrice B
            Console.WriteLine("\nMatrix B: ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(B[i, j] + "\t");

                }
                Console.WriteLine();
            }
            //comparing both matrices using flag
            int[,] C = new int[2, 2];
            bool flag = true;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (A[i, j] == B[i, j])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }

            //for printing the answer of comparision
            if (flag == true)
            {
                Console.WriteLine("Matrices are Equal  ");
            }
            else
            {
                Console.WriteLine("Not Equal ");
            }
            Console.Read();
        }
    }
}

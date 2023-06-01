using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i += 2)
            {
                Console.WriteLine(" ");
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
            }

            for (int i = 3; i >= 1; i -= 2)
            {
                Console.WriteLine(" ");
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
            }
            Console.ReadKey();
        }
    }
}

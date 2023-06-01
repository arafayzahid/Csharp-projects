using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    if (a == 1)
                    {
                        Console.Write("A");
                    }

                    else if (a == 2)
                    {
                        Console.Write("B");
                    }

                    else if (a == 3)
                    {
                        Console.Write("C");
                    }

                    else if (a == 4)
                    {
                        Console.Write("D");
                    }

                    else if (a == 5)
                    {
                        Console.Write("E");
                    }

                }

                Console.WriteLine("");

            }

            Console.ReadKey();
        }
    }
}

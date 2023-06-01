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

            for (int r = 0; r <= 100; r++)
            {
                int n = r, a = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine(n + " Prime Number");
                }
            }
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fab_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i <= 8; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}

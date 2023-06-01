using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int x = 5;

            //mainloop
            do
            {
                //nested-1
                int n = x;
                do
                {
                    Console.Write(" ");
                    n--;
                } while (1 <= n);
                //nested-1 end


                //nested-2
                int b = 1;
                do
                {
                    Console.Write(" *");
                    b++;
                } while (b <= a);
                //nested-2 end


                Console.WriteLine();
                a++;
                x--;
            } while (a <= 5);


            Console.ReadKey();
        }
    }
}

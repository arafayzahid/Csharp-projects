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

            //user input
            Console.WriteLine("Enter numbers:");

            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = Convert.ToInt32(Console.ReadLine());

            //condition
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The biggest number is: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The biggest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The biggest number is: " + num3);
            }

            Console.ReadKey();




        }
    }
}

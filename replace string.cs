using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string s = "Abdul Rafay Zahid";
            Console.WriteLine("Sentence Before Replacing : {0} ", s);

            string s1 = s.Replace("Rafay", "Haseeb");
            Console.WriteLine("Sentence After Replacing : {0} ", s1);

            Console.ReadLine();
        }
    }
}

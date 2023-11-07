using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var fact = input;
            for (var i = input - 1; i >= 1; i--) 
            {
                fact = fact * i;
            }
            Console.WriteLine(input + "! = " + fact);
        }
    }
}

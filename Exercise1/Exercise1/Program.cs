using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise1
            Console.Write("Unesite broj od 1 do 10:");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number > 0 && number < 11)
            {
                Console.WriteLine("Valid!");
            }
            else 
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}

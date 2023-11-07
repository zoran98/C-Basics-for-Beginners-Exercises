using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 10);
     //       Console.WriteLine(number);
            for (var i = 0; i <= 3; i++)
            {
                Console.Write("Unesite broj od 1 do 10: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (number != input)
                {
               //     Console.WriteLine("Try again.");
                    continue;  
                }
                Console.WriteLine("You won!");
                Process.GetCurrentProcess().Kill();
                break;      
            }
            Console.WriteLine("You lost!");

        }
    }
}

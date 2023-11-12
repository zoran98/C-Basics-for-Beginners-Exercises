using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time: ");
            var str = Console.ReadLine();

            message(str);
            
        }

        public static void message(string str)
        {
            if (TimeSpan.TryParse(str, out var time))
            {
                Console.WriteLine(time);
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var input = Console.ReadLine();

            var s = input.ToCharArray();

            Array.Reverse(s);

            Console.WriteLine(s);

        }
    }
}

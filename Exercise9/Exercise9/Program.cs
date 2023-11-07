using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a series of number: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            int max = Convert.ToInt32(numbers[0]);
            foreach(var number in numbers)
            {
                var some = Convert.ToInt32(number);
                if (some > max)
                    max = some;
            }
            Console.WriteLine("Najveci broj u nizu je: " + max);


        }
    }
}

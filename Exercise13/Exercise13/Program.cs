using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            do
            {
                Console.Write("Enter a number or 'Quit' for exit: ");
                var input = Console.ReadLine();
                if (input == "Quit") {
                    break;
                }
                var broj = Convert.ToInt32(input);
                numbers.Add(broj);

            }while (true);

            var unique = new List<int>();

            foreach (var number in numbers)
            {
                if (!unique.Contains(number)) { 
                    unique.Add(number);
                }
            }

            foreach (var number in unique)
                Console.WriteLine(number);

        }
    }
}

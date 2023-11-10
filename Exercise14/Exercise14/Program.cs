using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do { 
                Console.WriteLine("Enter a numbers separated with comma: ");
                var input = Console.ReadLine();
                var numbers = input.Split(',');
                var list = numbers.ToList();

                if (list.Count < 5) 
                {
                    Console.WriteLine("Invalid list! Try again.");
                    continue;
                }
                list.Sort();

                foreach(var n in list)
                Console.WriteLine(n);

                
                Console.WriteLine("The 3 smallest number are: ");
                for (var i = 0; i < 3; i++)
                {
                    Console.WriteLine(list[i] + " ");
                }
                break;


            } while (true);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise2
            Console.Write("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var maxNumber = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine("Max number is: " + maxNumber);

        }
    }
}

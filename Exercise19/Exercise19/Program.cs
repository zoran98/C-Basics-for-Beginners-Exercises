using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a english word: ");
            var str = Console.ReadLine();

            numberOfVowels(str);
        }

        public static void numberOfVowels (string str) 
        {
            var counter = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                    str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

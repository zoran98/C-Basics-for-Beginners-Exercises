using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by a space: ");
            var str = Console.ReadLine();
            pascalCase(str);
        }

        public static void pascalCase(string str)
        {
            var str1 = str.Split(' ');

            var words = "";
            foreach (var str2 in str1)
            {
                var toUper = char.ToUpper(str2[0]);
                var toLower = new String(str2.Skip(1).Select(c => char.ToLower(c)).ToArray());

                var word = toUper + toLower;
                words += word;
            }
            Console.WriteLine(words);
        }
    }
}

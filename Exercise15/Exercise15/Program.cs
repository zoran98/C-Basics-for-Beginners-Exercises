using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var str = Console.ReadLine();
            var list = new List<int>();

            getListOfNumbers(list, str);

            list.Sort();

            var message = isConsecutive(list) ? "Consecutive" : "Not consecutive";
            Console.WriteLine(message);
        }

        public static List<int> getListOfNumbers(List<int> list, string str)
        {
            
            foreach (var number in str.Split('-'))
            {
                list.Add(Convert.ToInt32(number));
            }
            return list;
        }

        public static bool isConsecutive(List<int> list)
        {
            var isConsecutive = true;
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] != list[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            return isConsecutive;
        }
    }
}

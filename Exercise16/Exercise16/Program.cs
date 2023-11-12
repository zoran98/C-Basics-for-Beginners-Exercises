using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numbers separated by s hyphens: ");
            var str = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(str))
            {
                Environment.Exit(0);
            }

            var list = getList(str);

            var store = list[0];
            for (var j = 1; j < list.Count; j++)
            {
                if (store.Equals(list[j]))
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
                continue;
            }            
        }

        public static List<int> getList(string str)
        {
            var list = new List<int>();
            foreach (var number in str.Split('-'))
            {
                list.Add(Convert.ToInt32(number));
            }
            return list;
        }
    }
}

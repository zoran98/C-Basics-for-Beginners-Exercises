using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
          
            while (true) 
            {
                Console.Write("Enter number or 'ok' for exit: ");
                var input = Convert.ToString(Console.ReadLine());
                if (input == "ok") 
                {
                    break;
                }
                br++;
            }
            Console.WriteLine(br);
        }
    }
}

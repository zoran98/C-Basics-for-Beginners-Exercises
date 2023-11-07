using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) 
                {
                    br++;
                }
            }
            Console.WriteLine(br);
        }
    }
}

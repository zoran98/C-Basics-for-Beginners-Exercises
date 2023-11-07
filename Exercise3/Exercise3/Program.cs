using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise3
            Console.Write("Enter width of image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height of image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height) 
            {
                Console.WriteLine("Image is landscape!");
            }
            else
            {
                Console.WriteLine("Image is portrait!");
            }

        }
    }
}

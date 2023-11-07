using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise4
            Console.Write("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the speed of car: ");
            var speedOfCar = Convert.ToInt32(Console.ReadLine());

            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if(speedOfCar > speedLimit) {
                var difrence = speedOfCar - speedLimit;
                var points = difrence / 5;
                if (points <= 12) 
                {
                    Console.WriteLine("It's Ok!");
                }
                else
                {
                    Console.WriteLine("License suspended!");
                }

            }
        }
    }
}

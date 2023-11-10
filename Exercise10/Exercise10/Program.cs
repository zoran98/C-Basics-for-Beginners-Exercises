using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>();

            do
            {
                Console.Write("Enter a name: ");
                var name = Console.ReadLine();
                if (name != "")
                {
                    
                    lista.Add(name);
                }
                else 
                { 
                    break; 
                }

            } while (true);
   
            if (lista.Count == 1)
            {
                Console.WriteLine(lista.First());
            }
            else if (lista.Count == 2)
            {
                Console.WriteLine(lista.First());
                Console.WriteLine(lista.ElementAt(1));
            }
            else if (lista.Count > 2) 
            {
                Console.WriteLine(lista.First());
                Console.WriteLine(lista.ElementAt(1));
                var broj = lista.Count - 2;
                Console.WriteLine("I jos: " + broj);
            }

        }
    }
}

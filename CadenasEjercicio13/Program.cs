using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasEjercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            string segundaFrase = "";

            do
            {
                Console.WriteLine("Ingrese la primer frase");
                frase = Console.ReadLine();
                if (frase == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
            } while (frase == "");

            do
            {
                Console.WriteLine("Ingrese la segunda frase");
                segundaFrase = Console.ReadLine();
                if (segundaFrase == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
            } while (segundaFrase == "");

            if (frase.Length == segundaFrase.Length)
            {
                Console.WriteLine("Las frases tienen el mismo largo");
            }
            else
            {
                Console.WriteLine("Las frases tienen distinto largo");
            }

            Console.ReadKey();
        }
    }
}

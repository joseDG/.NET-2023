using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EstructuraCiclicaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Numero = 0;

            do
            {
                Console.WriteLine("El valor de la variable Numero es: " + Numero);
                Numero++;

            } while (Numero <= 10);
            Console.ReadKey();
        }
    }
}

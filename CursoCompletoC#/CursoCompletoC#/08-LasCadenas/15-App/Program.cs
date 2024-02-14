using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fotrmato de cadenas
            //Formato compuesto
            int numero1 = 5, numero2 = 10;

            Console.WriteLine("El primer valor es: {0}, y el segundo valor es: {1}", numero1, numero2);

            string cadena1;

            cadena1 = String.Format("El valor es {0}", numero1);
            Console.WriteLine(cadena1);
        }
    }
}

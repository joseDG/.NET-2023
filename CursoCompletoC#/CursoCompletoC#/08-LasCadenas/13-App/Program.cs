using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "Hola a todos";

            Console.WriteLine(cadena1);

            //despues de padlet
            Console.WriteLine(cadena1.PadLeft(15));

            //utilizando paidRight
            Console.WriteLine(cadena1.PadRight(15, '#'));
        }
    }
}

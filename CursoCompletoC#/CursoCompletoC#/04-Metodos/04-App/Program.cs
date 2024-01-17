using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nombre = "Luis";
            byte edad = 50;
            long numero = 5552523545;

            //tipo tuplas
            //(tipo) Identificador = (valor)
            //(string, byte, long) persona1 = ("Luis", 50, 5536564554);
            var persona1 = ("Luis", 50, 5536564554);
            Console.WriteLine(persona1);
            Console.WriteLine("{0}, {1}, {2}", nombre, edad, numero);
        }
    }
}

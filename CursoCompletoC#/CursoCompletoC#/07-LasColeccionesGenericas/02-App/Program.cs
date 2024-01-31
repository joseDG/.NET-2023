using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            byte numPequeno = 125;
            int numGrande = numPequeno;
            //Boxing [tipo de valor -> object] implicita
            int a = 50;
            object obj = a;
            object resultado;
            //la conversion Boxing copia el valor de "a" dentro del objeto "obj"

            //Unboxing [obejct -> tipo de valor] explicito
            resultado = (int)numero1 + 10;
            Console.WriteLine(resultado);
        }
    }
}

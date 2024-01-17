using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i; //variable control del ciclo

            //tipo[] nombre = new tipo[tamano];
            string[] nombres = new string[3];

            //colocamos valores en los 3 elementos
            //nombres[0] = "Sandra";
            //nombres[1] = "Pedro";
            //nombres[2] = "Carmen";

            //byte i; //Variable de control del ciclo

            for(i = 0; i <= 2; i++)
            {
                Console.Write("Ingresa el valor para el indice {0}: ", i);
                nombres[i] = Console.ReadLine();
            }
            //mostramos los valores
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}

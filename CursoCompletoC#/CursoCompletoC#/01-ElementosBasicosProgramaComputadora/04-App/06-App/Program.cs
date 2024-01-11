using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar la informacion por pantalla
            string nombre;

            //Preguntando el nombre del usuario
            Console.Write("Como te llamas?: ");
            nombre = Console.ReadLine();

            //Saludo al usuario
            Console.WriteLine("Hola {0}, un placer", nombre);
        }
    }
}

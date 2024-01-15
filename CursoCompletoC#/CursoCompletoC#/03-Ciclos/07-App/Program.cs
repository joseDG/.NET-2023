using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasena1, contrasena2 = "";

            Console.WriteLine("Escribe tu contrasena: ");
            contrasena1 = Console.ReadLine();

            while(contrasena1 != contrasena2)
            {
                Console.WriteLine("Confirma tu contrasena: ");
                contrasena2 = Console.ReadLine();
            }

            Console.WriteLine("Contrasena guardada!");
        }
    }
}

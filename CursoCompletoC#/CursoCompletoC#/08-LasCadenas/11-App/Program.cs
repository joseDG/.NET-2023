using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro para nuevo ingreso\n");

            Console.WriteLine("Ingresa tu nombre completo: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu correo electronico: ");
            string email = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Verifica tu informacion: \n");

            //utilizando el metodoS
            Console.WriteLine("Nombre: {0}", nombre.ToUpper());
            Console.WriteLine("Nombre: {0}", email.ToLower());

            //Char.ToUpper
            //Char.ToLower
        }
    }
}

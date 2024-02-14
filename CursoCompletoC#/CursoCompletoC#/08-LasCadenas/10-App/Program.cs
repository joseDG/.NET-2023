using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comparacion ordinal sin distincion
            Console.WriteLine("Ingresa tu correo: ");
            string correo = Console.ReadLine();

            Console.WriteLine("Ingrese tu correo nuevamente: ");
            string correoConfirmar = Console.ReadLine();

            bool coincidenciaCorreo;

            coincidenciaCorreo = correo.Equals(correoConfirmar, StringComparison.OrdinalIgnoreCase);

            if (coincidenciaCorreo)
            {
                Console.WriteLine("Registrado con exito");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

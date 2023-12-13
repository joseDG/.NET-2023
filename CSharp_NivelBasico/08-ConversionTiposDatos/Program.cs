using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConversionTiposDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese su Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            //Edad = int.Parse(Console.ReadLine());
            Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Eres Casado?: ");
            //Casado = bool.Parse(Console.ReadLine());
            Casado = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Tu Sueldo: ");
            //Sueldo = double.Parse(Console.ReadLine());
            Sueldo = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_VariableDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dynamic se ajusta a cualquier tipo de dato.
            dynamic Contenido;
            Contenido = "Bienvenido a mi Sistema";

            Console.WriteLine("Contenido: " + Contenido);
        }
    }
}

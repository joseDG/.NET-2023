using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InstruccionFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;

            Console.Write("Ingrese un nro para definir la Tabla de Multiplicar: ");
            i = int.Parse(Console.ReadLine());

            for(int a = 0; a <= 12; a++)
            {
                Console.WriteLine(i + " X " + a + " = " + (i * a));
            }
            Console.ReadKey();
        }
    }
}

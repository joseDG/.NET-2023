using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asignacion compuesta (x -= 5) => (x = x - 5)
            //Acumulador = acumulador + variable == acumulador += variable

            int i;
            int acumulador = 0;
            int precio;

            for(i = 1; i <=5; i++)
            {
                Console.WriteLine("Inmgrese el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());

                acumulador += precio;
            }

            Console.WriteLine("El total es: {0}", acumulador);
        }
    }
}

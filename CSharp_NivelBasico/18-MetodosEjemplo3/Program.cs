using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_MetodosEjemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double PagoxDia;
            int Dias;

            Console.Write("Ingresa tu Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Cuanto te pagan por día trabajado?: ");
            PagoxDia = double.Parse(Console.ReadLine());

            Console.Write("Cuántos días trabajastes?: ");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine("El dinero obtenido por los días trabajados es:" + CalcularTotal(PagoxDia, Dias));

            Console.ReadKey();
        }

        //Método para obtener el total de dinero ganado por trabajo
        static double CalcularTotal(double P1, int P2)
        {
            double Total;
            Total = (P1 * P2);
            return Total;
        }
    }
}

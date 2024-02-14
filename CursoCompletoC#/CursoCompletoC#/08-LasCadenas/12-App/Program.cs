using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _12_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entero negativo (primera cadena < segunda cadena)
            //cero (primera cadena == segunda cadena)
            //entero positivo (primera cadena > segunda cadena)

            string cadena1 = "A";
            string cadena2 = "a";

            Console.WriteLine(String.Compare(cadena1, cadena2));
            
            int ordenar;
            ordenar = String.Compare(cadena1, cadena2, new CultureInfo("sv-SE"), CompareOptions.None);

            switch (ordenar)
            {
                case -1:
                    Console.WriteLine("({0}) es menor que ({1}) segun el criterio de ordenacion", cadena1, cadena2);
                    break;

                case 0:
                    Console.WriteLine("({0}) y ({1}) son iguales seguin el criteio de ordenacion", cadena1, cadena2);
                    break;

                case 1:
                    Console.WriteLine("({0}) es mayor que ({1}) segun el criterio de ordenacion", cadena1, cadena2);
                    break;
            }
        }
    }
}

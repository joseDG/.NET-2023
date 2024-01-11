using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * INICIO
             * 1. Pedir altura del rectangulo
             * 2. Pedir ancho del rectangulo
             * 3. Calcular area multiplicando alto por ancho
             * 4. Calcular el perimetro sumando los cuatro lados
             * 5. Mostrar area
             * 6. Mostrar perimetro
             * FIN
             * 
             * ======SEUDOCODIGO==================
             * INICIO
             * 
             * Variables:
             *  altura, ancho, area, perimetro: double
             *Escribir("Dame la altura: ")
             *Leer(altura)
             *Escribir("Dame el ancho: ")
             *Leer (ancho)
             *area <- altura * ancho
             *perimetro <- 2(altura + ancho)
             *Escribir ("El area es: ", area)
             *Escribir("El perimetro es:", perimetro)
             *FIN
             */

            //Variables
            double altura, ancho, area, perimetro;

            //Pedimos la altura y conversion a tipo double
            Console.Write("Dame la altura: ");
            altura = double.Parse(Console.ReadLine());

            //pedimo el ancho y convertimos a tipo double
            Console.Write("Dame la base: ");
            ancho = double.Parse(Console.ReadLine());

            //calculamos el area
            area = altura * ancho;

            //calculamos el permitro
            perimetro = 2 * (altura + ancho);

            //Mostrar los resultados en pantalla
            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0}", perimetro);
        }
    }
}

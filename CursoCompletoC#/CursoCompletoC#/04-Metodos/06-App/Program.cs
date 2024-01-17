using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una aplicación que calcule el área de un círculo, cuadrado o triangulo. Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos.

            //Variables
            double radioAr, baseAr, alturaAr, ladoAr, area;
            byte opcion;

            //Mostramos las opciones
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Cuadrado");

            //Preguntamos
            Console.Write("Escoge una opción y calcularé su área: ");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Dame el valor del radio de tu círculo: ");
                    radioAr = Convert.ToDouble(Console.ReadLine());

                    //Invocamos al método
                    area = AreaCirculo(radioAr);

                    //Mostramos el resultado
                    Console.WriteLine("El área es: {0}", area);
                    break;
                case 2:
                    //Pedimos los valores de base y altura
                    Console.Write("Dame el valor de la base de tu triangulo: ");
                    baseAr = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Dame el valor de la altura de tu triangulo: ");
                    alturaAr = Convert.ToDouble(Console.ReadLine());

                    //Invocamos al método
                    area = AreaTriangulo(baseAr, alturaAr);

                    //Mostramos el resultado
                    Console.WriteLine("El área es: {0}", area);
                    break;
                case 3:
                    Console.Write("Dame el valor de uno de los lados de tu cuadrado: ");
                    ladoAr = Convert.ToDouble(Console.ReadLine());

                    area = AreaCuadrado(ladoAr);

                    //Mostramos el resultado
                    Console.WriteLine("El área es: {0}", area);
                    break;
            }

        }

        static double AreaCirculo(double radioPa)
        {
            double area;

            //calcualr el area
            area = Math.PI * (radioPa * radioPa);

            //regresamos el
            //valor del area
            return area;    

        }

        static double AreaCuadrado(double ladoPa)
        {
            double area;

            //Calculamos el área
            area = ladoPa * ladoPa;

            //Regresamos el valor del área
            return area;
        }

        static double AreaTriangulo(double basePa, double alturaPa)
        {
            double area;

            //Calcula el área
            area = (basePa * alturaPa) / 2;

            //Regresamos el valor de área
            return area;
        }
    }
}

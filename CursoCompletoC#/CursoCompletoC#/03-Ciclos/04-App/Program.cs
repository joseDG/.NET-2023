using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            byte i, numAlumnos;
            double calificacion, sumaCalif = 0, promedio;

            Console.Write("Ingresa el número de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingresa la calificación: ");
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaCalif += calificacion;
            }

            //Calculamos el promedio
            promedio = sumaCalif / numAlumnos;

            //Mostramos el promedio
            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}

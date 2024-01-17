using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _05_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un método para transformar de grados a radianes
            double gradosAr, radianes;

            Console.WriteLine("Ingrese los grados a convertir: ");
            gradosAr = Convert.ToDouble(Console.ReadLine());

            radianes = GradosRadianes(gradosAr);
            Console.WriteLine("{0}° = {1} radianes", gradosAr, radianes);
        }

        static double GradosRadianes(double gradosPa)
        {
            double radianes;
            radianes = (gradosPa * Math.PI) / 180;
            return radianes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando un objeto DataTime
            DateTime fechaHoraPredeterminados = new DateTime();
            DateTime fecha = new DateTime(2004, 01, 23);
            DateTime fechaHora = new DateTime(20001, 06, 15, 23, 11, 5);

            Console.WriteLine(fechaHoraPredeterminados);
            Console.WriteLine(fecha);
            Console.WriteLine(fechaHora);

            //converitr el objeto DateTime en una cadena
            string cadenaFechaHora = fechaHora.ToString("F");

            //impirmiendo la representacino en cadena del objeto DateTime segun la referencia cultural
            Console.WriteLine($"la presentacion en cadena es: {cadenaFechaHora}");
        }
    }
}

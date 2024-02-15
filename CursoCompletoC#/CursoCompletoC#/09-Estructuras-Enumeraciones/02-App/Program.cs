using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos a la estructura
            Alumno alumno1 = new Alumno();

            //asignaaanodel el valor a un campo
            alumno1.Nombre = "Luis";
            //Mostrar el valor del campo "Nombre"
            Console.WriteLine($"El nombre del alumno es: {alumno1.Nombre}");

        }
    }

    struct Alumno
    {
        //campos
        string nombre;
        string apellido;
        string calificacion;
        string alergias;
        string numeroTelefono;

        //creamos una propiedaad para nombre
        public string Nombre { get => nombre; set => nombre = value; }
    }
}

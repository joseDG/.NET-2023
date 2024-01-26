using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_App
{
    internal class Program
        

        //sobrecarga de metodos
    {
        static void Main(string[] args)
        {
            //variable para recibir desde concatenar
            string nombreYApellido;

            //instanciar
            Nombres nombres = new Nombres();
            nombreYApellido = nombres.Concatenar("Leticia", "Guazman", "Diaz");
            
            //mostrando las cadenas concatenadas
            Console.WriteLine(nombreYApellido);
        }
    }

    class Nombres
    {
        //metodo
        public string Concatenar(string nombrePa, string apellidoPa)
        {
            string nombreApellido;

            nombreApellido = nombrePa + " " + apellidoPa;

            return nombreApellido;
        }

        //sobrecarta del metodo concatenar
        public string Concatenar(string nombrePa, string apellidoPa, string apellido2Pa)
        {
            string nombreApellido;

            nombreApellido = nombrePa + "" + apellidoPa + "" + apellido2Pa;

            return nombreApellido;
        }
    }
}

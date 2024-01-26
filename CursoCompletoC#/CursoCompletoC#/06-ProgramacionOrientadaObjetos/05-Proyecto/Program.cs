using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables locales
            string nombreAr, apellidoAr, nip;

            Console.WriteLine("Bienvenido a Monster Inc.\n");
            Console.WriteLine("Ingrese los siguientes campos que se le solicitan: \n");

            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("Apellido: ");
            apellidoAr = Console.ReadLine();
            Console.Write("Digite su NIP para aasignarle a su tarjeta bancaria: ");
            nip = Console.ReadLine();

            //Instanciamso ala clase empleado
            Empleado empleado1 = new Empleado(nombreAr, apellidoAr);

            empleado1.Nip = nip;

            //Mostrar la informacion del objeto
            Console.WriteLine(empleado1.ToString());
        }
    }

    class Empleado
    {
        //campos
        private string nombre, apellido, id, locker, banco, nip;

        //constructor
        public Empleado(string nombrePa, string apellidoPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;

            //Llamando also metodos para generar los numero aleatorios
            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignarBanco();
        }

        //Instanciamos a Random
        Random random = new Random();

        //propiedades
        public string Nip
        {
            set => nip = value;
        }

        //metodos
        private string GenerarID()
        {
          
            //variables
            int i, numero;
            string id = "";

            for (i = 0; i < 10; i++)
            {
                numero = random.Next(10);

                id += numero.ToString();
            }
            return id;
        }

        private string GenerarLocker()
        {

            int i, numero;
            string locker = "";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10);

                locker += numero.ToString();
            }

            return locker;
        }

        private string AsignarBanco()
        {
            
            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1, 3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Stander";
                    break;

                case 2:
                    banco = "BBVA";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = "";
            mensaje = "Empleado: " + nombre + " " + apellido + "\nNumero de empelado: " + id + "\nLocker No. " + locker + "\nBanco asignado: " + banco;

            return mensaje;
        }
    }
}

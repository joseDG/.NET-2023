using System;
using System.Collections.Concurrent;
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
            //declarar variable local
            //bool acelerar;

            //instanciando ala claase Automovil
            Automovil automovil = new Automovil();

            //Mostrando el campo pruvado
            //Console.WriteLine("El color es: {0}", automovil.Color);

            //Asignandole un valor a un campo privado y mostrandolo
            automovil.Combustible = "Diesel";
            //Console.WriteLine("el combustible es {0}", automovil.Combustible);

            Console.WriteLine(automovil.ToString());

            //accediendo a los cambos de la clase
            /* automovil.color = "Rojo";
             automovil.combustible = "diesel";

             Console.WriteLine("El tipo de combustible es: {0}", automovil.combustible);

             //accediendo a los metodos
             acelerar = automovil.Acelerar();

             if (acelerar)
             {
                 Console.WriteLine("Acelerando correctamente");
             }

             //ejecucion del metodo static
             //automovil.Prueba();
             Automovil.Prueba();*/

        }
    }

    //[modificador de acceso] [class] [identificador]
    public class Automovil
    {
        //Campos 
        private string color = "Rojo", modelo="ZB30", combustible, ano ="1998", numPuertas = "4";
        private int ccMotor = 1500;

        //propiedades
        //[acceso] [tipo] [Nombre]
        public string Color
        {
            //descriptor de acceso get
            get => color;
            //un descriptor de acceso set

            //Accessors
        }

        public string Combustible
        {
            //descritor de aceso "get"
            get { return combustible; }

            //descripcion de acceso "set"
            set => combustible = value;
        }

        //miembro => expresion;


        //Metodos
        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            //ejecucion del metodo estatico
            Prueba();
            return acelerar;
        }

        public bool Frenar()
        {
            bool frenar = true;
            Console.WriteLine("Frenar");
            return frenar;
        }

        public void Velocidades(ref byte velocidadPa)
        {
            velocidadPa++;
            Console.WriteLine("Cambio de velocidad");
        }

        //Metodo estatico
        public static void Prueba()
        {
            Console.WriteLine("Soy un metodo estatico");
        }

        //Invalidando el metodo ToString
        public override string ToString()
        {
            string mensaje;
            mensaje = "Color: " + color + "\nModelo: " + modelo + "\nTipo de Combustible: "+ combustible+ "\nAno: " +  ano + "\nPuertas: " + numPuertas + "\nMotor: " + ccMotor;

            return mensaje;
        }



    }
}

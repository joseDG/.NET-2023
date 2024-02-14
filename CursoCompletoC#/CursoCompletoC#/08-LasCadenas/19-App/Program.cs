using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _19_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*. De entre 8-20 caracteres
             * .an a contener al menos una letra minuscula
             * .Una letra mayuscula
             * .Un numero
             * .Y un caracter especia de entre sesu posibles opciones
             */

            //variables necsarias
            string nombreUsuario, opcion, contrasena;

            //un titulo para el programa
            Console.WriteLine("\t\tRegistro\n\n");

            //pedimos el nombre de usaurio
            Console.WriteLine("Ingrese un nombre de usuario: ");
            nombreUsuario = Console.ReadLine();
        }
    }

    //se crea una clase especificamenmte para manejar los campos y metodos que van a generar la contrasena

    class Contrasena
    {
        //campos
        //4 coleciones de caracter para escoger y generar la contrasena
        string numeros = "0123456789";
        string letrasMin = "qwertyuioplkjmnhgbvfdcxsaz";
        string letrasMay = "QWERTYUIOPLKJMNHBGVFDCXSZA";
        string caracterEspecial = "$%#&!?";

        //Contadores para verificar el numero de caracteres de cada grupo
        int numContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;


        //Metodo para generar la contrasena
        public string GenerarContrasena()
        {
            //aqui guardar la contrasena
            string ContrasenaGenerada = "";

            //Instancia a la clase Random para usarla mas adelante
            Random random = new Random();

            //Declaramos una variable que guarde el tamano que tendra la contrasena, generamos un numero aleatorio para determinar una longitud de entre 8 y 20 caracteres y se lo asignamos ala variable
            int longitudContrasena = random.Next(8, 21);

            //Variables que van a determinar el numero de caracteres que se usaran de cada grupo, basandose en uin porcentaje de la longitud de la contrasena
            double numTener = longitudContrasena * .15;
            double minTener = longitudContrasena * .35;
            double mayTener = longitudContrasena * .35;
            double espTener = longitudContrasena * .15;

            //variable de tipo char que va a alamcenar a cada uno de los caracteres que van a confirmar ala contrasena
            char caracterEscogido;

            //Usamos una iteracion while para ir colocando un caracter (de los 4 del grupo) hasta que completamos la longitud que se establecio anteriormente
            while(ContrasenaGenerada.Length < longitudContrasena)
            {
                //volvamos a usar una numero aleatorio, esta vez para seleccionar uno de los 4 grupos de string que tenermos
                switch(random.Next(0, 4))
                {
                    case 0:
                        //si los caracteres numericos que contiene la contrasena son menores a lso que debe contener, entonces ingresa al bloque de codigo y los genera;
                        if(numContiene < numTener)
                        {
                            //A caracteEscogido. se le va a asignar un caracter aleatorio de lso contenidos en el string numeros, basandose en el indice y apoyuandose de la porpiedad "lenght" Ejemp
                            caracterEscogido = numeros[random.Next(numeros.Length)];
                            //se le acumula el caracter escgido por Ramdon a la contrasena 
                            ContrasenaGenerada += caracterEscogido;
                            //se aumenta en 1 a los caracters numericos que contiene l aconstrasena
                            numContiene++;
                        }
                        break;
                    case 1:
                        if(minContiene < minTener)
                        {
                            caracterEscogido = letrasMin[random.Next(letrasMin.Length)];
                            ContrasenaGenerada += caracterEscogido;
                            minContiene++;
                        }
                        break;
                    case 2:
                        if(mayContiene < mayTener)
                        {
                            caracterEscogido = letrasMay[random.Next(letrasMay.Length)];
                            ContrasenaGenerada += caracterEscogido;
                            mayContiene++;
                        }
                        break;
                    case 3:
                        if(espContiene < espTener)
                        {
                            caracterEscogido = caracterEspecial[random.Next(caracterEspecial.Length)];
                            ContrasenaGenerada += caracterEscogido;
                            espContiene++;
                        }
                        break;
                }
            }
            return ContrasenaGenerada;


        }
    }
}

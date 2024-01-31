using System;
using System.Collections.Concurrent;
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
            //variables locales
            string valorElemento;

            //instancia la clase
            //GuardarObjetos<Alumno> objetos1 = new GuardarObjetos<Alumno>(3);

            //isntacnia a al clase Alumno
            //Alumno alumno1 = new Alumno(8.5);
            //Alumno alumno2 = new Alumno(7.5);
            //Alumno alumno3 = new Alumno(6.5);

            //agregar objetosala clase
            GuardarObjetos<string> objetos1 = new GuardarObjetos<string>(3);
            
            //agregar objetos
            objetos1.AgregarElementos("Luis");
            objetos1.AgregarElementos("Mateo");
            objetos1.AgregarElementos("Juan");

            //obtener elemento
            valorElemento = objetos1.ObtenerElemento(1);
            Console.WriteLine(valorElemento);
        }
    }

    class GuardarObjetos<T>
    {
        //campos 
        private int i = 0;
        private T[] matrizElementos;

        //constructor
        public GuardarObjetos(int elementosPa)
        {
            matrizElementos = new T[elementosPa];
        }

        //metodos
        public void AgregarElementos(T elementosPa)
        {
            matrizElementos[i] = elementosPa;
            i++;
        }

        public T ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];
        }
    }

    class Alumno
    {
        //campos
        double calificacion;

        //constructor
        public Alumno(double calificacionPa)
        {
            calificacion = calificacionPa;
        }

        //propiedades
        public double Calificacion
        {
            get => calificacion;
        }
    }
}

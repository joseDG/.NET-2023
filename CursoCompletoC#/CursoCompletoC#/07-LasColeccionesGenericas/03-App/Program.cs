using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_App
{
    internal class Program
    {
        //creacion de un ejemplo que no se utilza genericos
        static void Main(string[] args)
        {
            //variables locales
            string valorElemento;

            //insntacia la clase
            GuardaObjetos obejtos1 = new GuardaObjetos(3);

            //agregar objetops
            obejtos1.AgregarElementos("luis");
            obejtos1.AgregarElementos("Juan");
            obejtos1.AgregarElementos("Jose");

            //obtener elemento
            valorElemento = (string) obejtos1.ObtenerElemento(1);
            Console.WriteLine(valorElemento);
        }
    }

    class GuardaObjetos
    {
        //campos
        private int i = 0;
        private object[] matrizElementos;

        //constructor
        public GuardaObjetos(int elementosPa)
        {
            matrizElementos = new object[elementosPa];
        }

        //metodos
        public void AgregarElementos(object elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++;
        }

        public object ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];
        }
    }
}

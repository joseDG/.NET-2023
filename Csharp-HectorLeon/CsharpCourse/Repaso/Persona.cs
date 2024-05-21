﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    //encapsulamiento
    public class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }

        public virtual void Presentacion()
        {
            Console.WriteLine("Soy una persona");
        }

    }
}

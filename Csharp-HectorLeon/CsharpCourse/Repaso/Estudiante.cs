using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estudiante : Persona
    {
        public string Escuela { get; set; }

        public void Estudiar()
        {
            Console.WriteLine($"Soy el estudiante {Nombre}  tengo {Edad} y estudio en: {Escuela}.");
        }

        public override void Presentacion()
        {
            Console.WriteLine("Soy estudiante");
        }
    }
}

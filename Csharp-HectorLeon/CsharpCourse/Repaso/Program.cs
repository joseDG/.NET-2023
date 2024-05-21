using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Presentacion();
           
            Estudiante estudiante = new Estudiante();
            estudiante.Presentacion();

            Profesor profe = new Profesor();
            profe.Presentacion();
            
        }
    }
}

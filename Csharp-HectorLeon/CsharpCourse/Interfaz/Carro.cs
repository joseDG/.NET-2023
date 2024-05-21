using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class Carro : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("el carro esta siendo conducido.");
        }

       
        public int ObternerNumeroDeRuedas()
        {
            return 4;
        }
    }
}

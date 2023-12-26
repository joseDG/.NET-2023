using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_ClasesAbstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Acutangulo acutangulo = new Acutangulo();
            Escaleno escaleno = new Escaleno();

            acutangulo.Area();
            escaleno.Area();

            escaleno.CalcularAreaTrianguloHipotenusa(6, 8);
            acutangulo.CalcularAreaTrianguloHipotenusa(2, 5);
        }
    }
}

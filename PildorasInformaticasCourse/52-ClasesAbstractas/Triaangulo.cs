using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_ClasesAbstractas
{
    public abstract class Triaangulo
    {
        public abstract decimal Perimetro();
        public abstract decimal Area();

        public double CalcularAreaTrianguloHipotenusa(int lado, int hipotenusa)
        {
            double ladob = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2));
            return lado - ladob / 2;
        }
    }

    public class Escaleno : Triaangulo
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }

    public class Acutangulo : Triaangulo
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }
}

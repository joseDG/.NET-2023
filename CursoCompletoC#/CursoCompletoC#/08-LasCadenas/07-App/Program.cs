using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto_original = "   caundo dorian gray saliode lahabitacion, load henrry cero los ojos y empso a pensar.    ";

            //quitamos los guiones
            string textoRemplazo = texto_original.Trim();

            //quitando la palabra Loard
            string quitarTexto = texto_original.Remove(43, 5);

            Console.WriteLine(texto_original);
            Console.WriteLine();
            Console.WriteLine(textoRemplazo);
        }
    }
}

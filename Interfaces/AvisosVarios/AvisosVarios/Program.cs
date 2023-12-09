using System;

namespace AvisosVarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("PJ LOJA", "Sancion por escandolo publico: $500", "02-05-2023");
            av2.getFecha();
            av2.mostrarAviso();
        }
    }
}

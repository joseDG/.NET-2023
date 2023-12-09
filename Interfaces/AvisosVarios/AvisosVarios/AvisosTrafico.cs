using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    class AvisosTrafico:IAvisos
    {
        
       //cosntructor 1
        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion cometida. Pague antes de 3 dias y se beneficia en undescuento del 50%";
            fecha = "";
        }

        //constructor 2
        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;

        }

        //metodos traidos desde la Interfaz
        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensjae {0} ha sido enviado por {1} el dia {2}", mensaje, remitente, fecha);
        }


        //variables 
        private string remitente;

        private string mensaje;

        private string fecha;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CheckRadioButton
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = "";

            if(chk_vfp.Checked == true)
            {
                Resultado += chk_vfp.Text+ ", "  ;
            }

            if(chk_csharp.Checked == true)
            {
                Resultado += chk_csharp.Text+ ", ";
            }

            if(chk_net.Checked == true)
            {
                Resultado += chk_net.Text+ ", ";
            }
            if(chk_java.Checked == true)
            {
                Resultado += chk_java.Text+ ", ";
            }

            //Evaluando proceso de selecion del radio button
            if(rb_presencial.Checked == true)
            {
                Resultado += " :::::: " +rb_presencial.Text+":::::";
            }
            else
            {
                Resultado += " :::::: " + rb_virtual.Text + ":::::";
            }
            //Resutlado boton
            textBReultado.Text = Resultado;
        }
    }
}

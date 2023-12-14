using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Presentacion
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void MiprimerFormulario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {   
            //limpiar cajas de texto
            text_Codigo.Text = "";
            textDescripcion.Text = "";

            //activar cajas de texto
            text_Codigo.Enabled = true;
            textDescripcion.Enabled = true;

            //inicia el cursor al inicio
            //text_Codigo.Select();
            text_Codigo.Focus();
        }
    }
}

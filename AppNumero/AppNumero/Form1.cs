using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNumeroMayor_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Instanciar Objeto Numero
            Numero numero1 = new Numero(int.Parse(txtNumMenor.Text), 
                                        int.Parse (txtNumMayor.Text));

            List<int> RangoNumero = new List<int>();
            RangoNumero = numero1.MostrarRango(); //Llenar vector

            foreach(int contador2 in RangoNumero)
            {
                rtbMostrar.Text = rtbMostrar.Text + " " + contador2.ToString();
            }

        }
    }
}

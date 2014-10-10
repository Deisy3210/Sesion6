using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Crear Objeto Persona
            Persona persona1 = new Persona(txtNombre.Text, int.Parse(txtEdad.Text));

            if (persona1.Edad >= 18)
            {
                MessageBox.Show(" Edad de " +persona1.Nombre + " tiene " + persona1.Edad
                    +" es mayor de 18 ");
            }
                else 
                {
                MessageBox.Show("Edad de " +persona1.Nombre + " tiene " + persona1.Edad
                    + " es menor de 18 ");
                }

            }




        }
    }


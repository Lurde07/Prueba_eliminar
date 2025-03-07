using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcion_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(txtedad.Text, out int edad))
            {
                if (edad > 0 && edad < 100)
                {

                        MessageBox.Show("Su edad es " + txtedad.Text + " años");
                }
                else 
                {
                  
                    MessageBox.Show("Por favor, ingrese una edad válida");
                }

               
            }
            else
            {
                MessageBox.Show("Por favo, ingrese una edad válida");
            }
        }
    }
}

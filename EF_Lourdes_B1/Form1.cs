using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Lourdes_B1
{
    public partial class Examen : Form
    {
        public Examen()
        {
            InitializeComponent();
        }


        private void btncomparar_Click_1(object sender, EventArgs e)
        {
            int num1, num2;

            if (int.TryParse(txtnum1.Text, out num1) && int.TryParse(txtnum2.Text, out num2))
            {
                if (num1 < num2)
                {
                    MessageBox.Show("El número " + txtnum2.Text + " es mayor que " + txtnum1.Text);
                }
                else if (num1 > num2)
                {
                    MessageBox.Show("El número " + txtnum1.Text + " es mayor que " + txtnum2.Text);
                }
                else
                {
                    MessageBox.Show("Los números son iguales");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido");
            }

        }
    }
}

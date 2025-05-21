using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5A_Examen_final_2B_FG
{
    public partial class NumAleatorio : Form
    {
        int aleatorio = 0;
        Random rand = new Random();

        public NumAleatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumMax.Text, out int numMax))
            {
                if (numMax < 1)
                {
                    MessageBox.Show("Ingrese un número positivo");
                }
                aleatorio = rand.Next(1, numMax);
                MessageBox.Show($"Numero: {aleatorio}");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

        private void NumAleatorio_Load(object sender, EventArgs e)
        {

        }
    }
}

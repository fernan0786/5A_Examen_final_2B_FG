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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPpt_Click(object sender, EventArgs e)
        {
            G2_PiedraPapelTijera g2_PiedraPapelTijera = new G2_PiedraPapelTijera();
            g2_PiedraPapelTijera.Show();
        }

        private void btnNumAleat_Click(object sender, EventArgs e)
        {
            NumAleatorio numero_Aleatorio = new NumAleatorio();
            numero_Aleatorio.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

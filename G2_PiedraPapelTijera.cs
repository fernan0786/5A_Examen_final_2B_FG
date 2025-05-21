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
    public partial class G2_PiedraPapelTijera : Form
    {
        Random random = new Random();

        public G2_PiedraPapelTijera()
        {
            InitializeComponent();
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            Jugar("Piedra");
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jugar("Papel");
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            Jugar("Tijera");
        }

        private void Jugar(string eleccionJugador)
        {
            string[] opciones = { "Piedra", "Papel", "Tijera" };
            string eleccionComputadora = opciones[random.Next(3)];
            lblEleccionComputadora.Text = "Computadora eligió: " + eleccionComputadora;

            string resultado = "";

            if (eleccionJugador == eleccionComputadora)
            {
                resultado = "¡Empate!";
            }
            else if (
            (eleccionJugador == "Piedra" && eleccionComputadora == "Tijera") ||
            (eleccionJugador == "Papel" && eleccionComputadora == "Piedra") ||
            (eleccionJugador == "Tijera" && eleccionComputadora == "Papel")
            )
            {
                resultado = "¡Ganaste!";
            }
            else
            {
                resultado = "Perdiste...";
            }

            lblResultado.Text = resultado;
        }
    }
}
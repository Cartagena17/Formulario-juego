using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierda_papel_tijera
{
    public partial class Form1 : Form
    {
        int contarPuntos = 0, contarPuntosPC = 0;
        string jugador = "", computadora = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            string []seleccion = {"Piedra","Papel","Tijera" };

            Random random = new Random();

            if (bdnPiedra.Checked==true)
            {
                jugador = "Piedra";
            }
            else if (rdnPapel.Checked==true)
            {
                jugador = "Papel";
            }
            else if (rdnTijera.Checked == true)
            {
                jugador = "Tijera";
            }
            else
            {
                MessageBox.Show("Selecciona una opcion disponible");
            }


            computadora = seleccion[random.Next(0,3)];

            if (computadora=="Piedra")
            {
                rdnPiedramach.Checked = true;
            }
            else if (computadora == "Papel")
            {
                rdnPapelmach.Checked = true;
            }
            else
            {
                rdnTijeramach.Checked = true;
            }

            //Comparando los resultados
            if (computadora==jugador)
            {
                lblGanador.ForeColor = Color.White;
                lblGanador.ForeColor = Color.YellowGreen;
                lblGanador.Text = "Empate";
            }

            else if ((jugador=="Piedra"&& computadora=="Tijeras")||
                (jugador=="Papel"&& computadora=="Piedra")||
                (jugador=="Tijera"&& computadora == "Papel"))
            {
                lblGanador.BackColor = Color.DarkGoldenrod;
                lblGanador.ForeColor = Color.White;
                lblGanador.Text = "Ganaste";
                contarPuntos++;
                txtJugador.Text=contarPuntos.ToString();
            }
            else
            {
                lblGanador.BackColor = Color.DarkGoldenrod;
                lblGanador.ForeColor = Color.White;
                lblGanador.Text = "Perdiste";
                contarPuntosPC++;
                txtMaquina.Text = contarPuntosPC.ToString();
            }

            if (contarPuntos == 3)
            {
                MessageBox.Show("Felicidades ganaste el juego");
                Close();
            }
            else if (contarPuntosPC==3)
            {
                MessageBox.Show("La computadora gano el juego");
                Close();
            }











        }
    }
}

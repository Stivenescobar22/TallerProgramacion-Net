using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1_ProgramacionNetEjercicios
{
    public partial class Ejercicio5_RaizCuadrada : Form
    {
        RaizCu raiz = new RaizCu();
        public Ejercicio5_RaizCuadrada()
        {
            InitializeComponent();
            lblmensaje1.Text = "Programa que calcula la raiz";
            lblmensaje2.Text = "de un numero";
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            raiz.setNumero(double.Parse(txtnumero.Text));

            if (raiz.Raiz() > 0)
            {

                lblresultado.Text = raiz.Raiz().ToString();
                lblresultado.Visible = true;

            }
            else
            {
                lblresultado.Text = "";
                lblmensaje3.Text = "No se le puede sacar raiz cuadrada";
                lblmensaje3.Visible = true;
            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}

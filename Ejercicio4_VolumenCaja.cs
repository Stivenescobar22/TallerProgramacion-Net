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
    public partial class Ejercicio4_VolumenCaja : Form
    {
        VolumenCa volumen = new VolumenCa();
        public Ejercicio4_VolumenCaja()
        {
            InitializeComponent();
            lblmensaje1.Text = "Programa que calcula el volumen";
            lblmensaje2.Text = "de una caja";
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            volumen.setLongitud(double.Parse(txtlongitud.Text));
            volumen.setAncho(double.Parse(txtancho.Text));
            volumen.setAltura(double.Parse(txtaltura.Text));

            lblresultado.Text = volumen.Volumen().ToString();
            lblresultado.Visible = true;
        }

        private void Txtlongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void Txtancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void Txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}

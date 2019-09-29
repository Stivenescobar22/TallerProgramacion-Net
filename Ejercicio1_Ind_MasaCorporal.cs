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
    public partial class Ejercicio1_Ind_MasaCorporal : Form
    {
        IndiceMasaCorporal indiceMasa = new IndiceMasaCorporal();
        public Ejercicio1_Ind_MasaCorporal()
        {
            InitializeComponent();
            lblmensaje1.Text = "Programa que calcula el indice";
            lblmensaje2.Text = " de masa corporal de una persona";
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            indiceMasa.setEstatura(double.Parse(txtestatura.Text));
            indiceMasa.setPeso(double.Parse(txtpeso.Text));

            if (indiceMasa.Calcular() < 18.5) {

                lblresultado.Text = indiceMasa.Calcular().ToString();
                lblresultado.Visible = true;
                lblmensaje3.Text = "Peso inferior al normal";
                lblmensaje3.Visible = true;

            }else if (indiceMasa.Calcular() <= 24.9) {

                lblresultado.Text = indiceMasa.Calcular().ToString();
                lblresultado.Visible = true;
                lblmensaje3.Text = "Peso Normal";
                lblmensaje3.Visible = true;

            }else if (indiceMasa.Calcular() < 29.9) {

                lblresultado.Text = indiceMasa.Calcular().ToString();
                lblresultado.Visible = true;
                lblmensaje3.Text = "Peso superior al normal";
                lblmensaje3.Visible = true;

            }else if (indiceMasa.Calcular() > 30.0) {

                lblresultado.Text = indiceMasa.Calcular().ToString();
                lblresultado.Visible = true;
                lblmensaje3.Text = "Obesidad";
                lblmensaje3.Visible = true;
            }

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

        private void Txtestatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloDecimal(e);
        }

        private void Txtpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloNumeros(e);
        }
    }
}

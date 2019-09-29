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


    public partial class Ejercicio3_NotasEstudiante : Form
    {
        PromedioNotas promedio = new PromedioNotas();
        public Ejercicio3_NotasEstudiante()
        {
            InitializeComponent();
            lblmensaje1.Text = "Programa que calcula el promedio";
            lblmensaje2.Text = "de un estudiante y muestra el resultado";
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            promedio.setNota1(double.Parse(txtnota1.Text));
            promedio.setNota2(double.Parse(txtnota2.Text));
            promedio.setNota3(double.Parse(txtnota3.Text));
            promedio.setNota4(double.Parse(txtnota4.Text));

            if (promedio.promedionotas() <= 2.99)
            {

                lblresultado.Text = promedio.promedionotas().ToString();
                lblresultado.Visible = true;
                lblmensaje3.Text = "Deficiente";
                lblmensaje3.Visible = true;

            }
            else if (promedio.promedionotas() <= 3.99)
            {


                lblresultado.Text = promedio.promedionotas().ToString();
                lblresultado.Visible = true;
                lblmensaje3.Text = "Bien";
                lblmensaje3.Visible = true;

            }
            else if (promedio.promedionotas() <= 5)
            {

                lblresultado.Text = promedio.promedionotas().ToString();
                lblresultado.Visible = true;
                lblmensaje3.Text = "Excelente";
                lblmensaje3.Visible = true;


            }

        }

        private void Txtnota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloDecimal(e);
        }

        private void Txtnota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloDecimal(e);
        }

        private void Txtnota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloDecimal(e);
        }

        private void Txtnota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validartxt.soloDecimal(e);
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}

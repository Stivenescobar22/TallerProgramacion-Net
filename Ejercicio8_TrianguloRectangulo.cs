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
    public partial class Ejercicio8_TrianguloRectangulo : Form
    {

        PruebaTriangulo pruebaTriangulo = new PruebaTriangulo();
        public Ejercicio8_TrianguloRectangulo()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            pruebaTriangulo.setCatetoa(double.Parse(txtcatetoa.Text));
            pruebaTriangulo.setHipotenusa(double.Parse(txthipotenusa.Text));
            pruebaTriangulo.setCatetob(double.Parse(txtcatetob.Text));

            if (pruebaTriangulo.Sumacatetos() == pruebaTriangulo.pruebaHipotenusa())
            {

                lblresultado.Text = pruebaTriangulo.Areatriangulo().ToString();
                lblresultado.Visible = true;
                lblmensaje.Text = "Es un triangulo rectangulo";
                lblmensaje.Visible = true;
            }
            else
            {
                lblresultado.Text = "--";
                lblresultado.Visible = true;
                lblmensaje.Text = "No es un triangulo rectangulo";
                lblmensaje.Visible = true;
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

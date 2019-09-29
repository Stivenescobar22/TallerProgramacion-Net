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
    public partial class Ejercicio9_MostrarEdad : Form
    {
        MosrarEdad mostrarEdad = new MosrarEdad();
        public Ejercicio9_MostrarEdad()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            mostrarEdad.setEdad(int.Parse(txtedad.Text));

            if (mostrarEdad.muestralaEdad() <= 10)
            {

                lbledad.Text = mostrarEdad.muestralaEdad().ToString();
                lbledad.Visible = true;
                lblmensaje.Text = " Niño ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }
            else if (mostrarEdad.muestralaEdad() <= 14)
            {

                lblmostraredad.Text = mostrarEdad.muestralaEdad().ToString();
                lblmostraredad.Visible = true;
                lblmensaje.Text = "Pre_Adolescente";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }
            else if (mostrarEdad.muestralaEdad() <= 18)
            {

                lblmostraredad.Text = mostrarEdad.muestralaEdad().ToString();
                lblmostraredad.Visible = true;
                lblmensaje.Text = " Adolescente ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }
            else if (mostrarEdad.muestralaEdad() <= 25)
            {

                lblmostraredad.Text = mostrarEdad.muestralaEdad().ToString();
                lblmostraredad.Visible = true;
                lblmensaje.Text = " Joven ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }
            else if (mostrarEdad.muestralaEdad() <= 65)
            {

                lblmostraredad.Text = mostrarEdad.muestralaEdad().ToString();
                lblmostraredad.Visible = true;
                lblmensaje.Text = " Adulto ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }
            else if (mostrarEdad.muestralaEdad() > 65)
            {

                lbledad.Text = mostrarEdad.muestralaEdad().ToString();
                lbledad.Visible = true;
                lblmensaje.Text = " Anciano ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();
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

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
    public partial class Ejercicio6_yearEdad : Form
    {
        Year year = new Year();
        public Ejercicio6_yearEdad()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            year.setAño(int.Parse(txtyear.Text));

            lblresultado.Text = year.edadpersona().ToString();
            lblresultado.Visible = true;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}

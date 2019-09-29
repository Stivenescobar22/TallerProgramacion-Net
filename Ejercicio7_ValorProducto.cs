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
    public partial class Ejercicio7_ValorProducto : Form
    {
        Valor valor = new Valor();
        public Ejercicio7_ValorProducto()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            valor.setProducto(int.Parse(txtvalor.Text));

            lblresultado.Text = valor.totalproducto().ToString();
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

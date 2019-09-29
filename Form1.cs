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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pgbcargando.Value = 0;
            this.timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            



            if (pgbcargando.Value <= 99) {

                pgbcargando.Minimum = 0;
                pgbcargando.Maximum = 100;
                pgbcargando.Value++;
                lblcargando.Text = "Cargando" + pgbcargando.Value.ToString() + "%";
                lblcargando.Visible = true;

            }
            else
            {
                this.timer1.Stop();

                Menu menu = new Menu();
                menu.Show();
                this.Hide();

            }
        }
    }
}

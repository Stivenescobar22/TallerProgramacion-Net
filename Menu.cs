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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btnejercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1_Ind_MasaCorporal ejercicio1 = new Ejercicio1_Ind_MasaCorporal();
            ejercicio1.Show();
            this.Hide();

        }

        private void Btnejercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2_TarifasLlamadas ejercicio2 = new Ejercicio2_TarifasLlamadas();
            ejercicio2.Show();
            this.Hide();
        }

        private void Btnejercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3_NotasEstudiante ejercicio3 = new Ejercicio3_NotasEstudiante();
            ejercicio3.Show();
            this.Hide();
        }

        private void Btnejercicio4_Click(object sender, EventArgs e)
        {
            Ejercicio4_VolumenCaja ejercicio4 = new Ejercicio4_VolumenCaja();
            ejercicio4.Show();
            this.Hide();
        }

        private void Btnejercicio5_Click(object sender, EventArgs e)
        {
            Ejercicio5_RaizCuadrada ejercicio5 = new Ejercicio5_RaizCuadrada();
            ejercicio5.Show();
            this.Hide();
        }

        private void Btnejercicio6_Click(object sender, EventArgs e)
        {
            Ejercicio6_yearEdad ejercicio6 = new Ejercicio6_yearEdad();
            ejercicio6.Show();
            this.Hide();
        }

        private void Btnejercicio7_Click(object sender, EventArgs e)
        {
            Ejercicio7_ValorProducto ejercicio7 = new Ejercicio7_ValorProducto();
            ejercicio7.Show();
            this.Hide();
        }

        private void Btnejercicio8_Click(object sender, EventArgs e)
        {
            Ejercicio8_TrianguloRectangulo ejercicio8 = new Ejercicio8_TrianguloRectangulo();
            ejercicio8.Show();
            this.Hide();
        }

        private void Btnejercicio9_Click(object sender, EventArgs e)
        {
            Ejercicio9_MostrarEdad ejercicio9 = new Ejercicio9_MostrarEdad();
            ejercicio9.Show();
            this.Hide();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

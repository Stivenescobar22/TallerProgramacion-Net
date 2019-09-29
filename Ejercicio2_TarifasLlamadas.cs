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
    public partial class Ejercicio2_TarifasLlamadas : Form
    {

        Tarifas tarifas = new Tarifas();

        public Ejercicio2_TarifasLlamadas()
        {
            InitializeComponent();
            lblmensaje1.Text = "Programa que calcula el valor de la";
            lblmensaje2.Text = "tarifa dependiendo del lugar a llamar";
            cmblugares.Text = "Seleccione..";
            cmblugares.Items.Add("Seleccione..");
            cmblugares.Items.Add("Estados Unidos");
            cmblugares.Items.Add("Canada");
            cmblugares.Items.Add("Europa");
            cmblugares.Items.Add("Resto del Mundo");


            

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            tarifas.setTotalMinutos(double.Parse(txtminutos.Text));


            switch (cmblugares.SelectedIndex.ToString())
            {

                //VALIDACION DE ESTADOS UNIDOS
                case "-1":

                    MessageBox.Show("Escoga una opcion"
                        , "Aviso"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Warning);
                    break;

                case "1":

                    if (tarifas.getTotalMinutos() < 15)
                    {
                        lblminutoos.Text = txtminutos.Text + " Minutos";
                        lblminutoos.Visible = true;
                        lblresultado.Text = "$ " + tarifas.EstadosUnidos().ToString();
                        lblresultado.Visible = true;
                        lblporcentaje.Text = "0%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Red;

                    }
                    else
                    {
                        lblminutoos.Text = txtminutos.Text + " Minutos";
                        lblminutoos.Visible = true;
                        lblresultado.Text = "$ " + tarifas.desc_estadosunidos().ToString();
                        lblresultado.Visible = true;
                        lblporcentaje.Text = "20%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Green;

                    }

                    break;


                //VALIDACION DE CANADA
                case "2":

                    if (tarifas.getTotalMinutos() < 15)
                    {
                        lblminutoos.Text = txtminutos.Text + " Minutos";
                        lblminutoos.Visible = true;
                        lbltarifa.Text = "$ " + tarifas.Canada().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "0%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Red;

                    }
                    else
                    {
                        lblminutoos.Text = txtminutos.Text + " Minutos";
                        lblminutoos.Visible = true;
                        lbltarifa.Text = "$ " + tarifas.desc_canada().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "20%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Green;

                    }


                    break;

                //VALIDACION DE EUROPA
                case "3":

                    if (tarifas.getTotalMinutos() < 15)
                    {
                        lblminutoos.Text = txtminutos.Text + " Minutos";
                        lblminutoos.Visible = true;
                        lbltarifa.Text = "$ " + tarifas.Europa().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "0%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Red;

                    }
                    else
                    {
                        lblminutoos.Text = txtminutos.Text + " Minutos";
                        lblminutoos.Visible = true;
                        lbltarifa.Text = "$ " + tarifas.desc_europa().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "20%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Green;

                    }
                    break;

                //VALIDACION DEL RESTO DEL MUNDO
                case "4":

                    if (tarifas.getTotalMinutos() < 15)
                    {
                        lblminutoos.Text = txtminutos.Text + " Minutos";
                        lblminutoos.Visible = true;
                        lbltarifa.Text = "$ " + tarifas.RestodelMundo().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "0%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Red;

                    }
                    else
                    {
                        lblminutoos.Text = txtminutos.Text + " Minutos";
                        lblminutoos.Visible = true;
                        lbltarifa.Text = "$ " + tarifas.desc_restodelmundo().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "20%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Green;

                    }
                    break;

                default:

                    MessageBox.Show("escoga un de las Opciones"
                        , "Aviso"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Warning);


                    break;

            }

        }

        private void Cmblugares_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmblugares.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}

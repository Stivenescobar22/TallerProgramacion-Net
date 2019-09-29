namespace Taller1_ProgramacionNetEjercicios
{
    partial class Ejercicio2_TarifasLlamadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtminutos = new System.Windows.Forms.TextBox();
            this.cmblugares = new System.Windows.Forms.ComboBox();
            this.lblmensaje1 = new System.Windows.Forms.Label();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.lbllugar = new System.Windows.Forms.Label();
            this.lblminutos = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblduracion = new System.Windows.Forms.Label();
            this.lblminutoos = new System.Windows.Forms.Label();
            this.lbltarifa = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(78, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(128, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Tarifa Llamada";
            // 
            // txtminutos
            // 
            this.txtminutos.Location = new System.Drawing.Point(85, 140);
            this.txtminutos.Name = "txtminutos";
            this.txtminutos.Size = new System.Drawing.Size(100, 20);
            this.txtminutos.TabIndex = 1;
            // 
            // cmblugares
            // 
            this.cmblugares.FormattingEnabled = true;
            this.cmblugares.Location = new System.Drawing.Point(85, 104);
            this.cmblugares.Name = "cmblugares";
            this.cmblugares.Size = new System.Drawing.Size(121, 21);
            this.cmblugares.TabIndex = 2;
            this.cmblugares.SelectedIndexChanged += new System.EventHandler(this.Cmblugares_SelectedIndexChanged);
            // 
            // lblmensaje1
            // 
            this.lblmensaje1.AutoSize = true;
            this.lblmensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje1.Location = new System.Drawing.Point(58, 49);
            this.lblmensaje1.Name = "lblmensaje1";
            this.lblmensaje1.Size = new System.Drawing.Size(65, 15);
            this.lblmensaje1.TabIndex = 3;
            this.lblmensaje1.Text = "mensaje 1";
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje2.Location = new System.Drawing.Point(58, 76);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(65, 15);
            this.lblmensaje2.TabIndex = 4;
            this.lblmensaje2.Text = "mensaje 2";
            // 
            // lbllugar
            // 
            this.lbllugar.AutoSize = true;
            this.lbllugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllugar.Location = new System.Drawing.Point(32, 107);
            this.lbllugar.Name = "lbllugar";
            this.lbllugar.Size = new System.Drawing.Size(48, 15);
            this.lbllugar.TabIndex = 5;
            this.lbllugar.Text = "Lugar:";
            // 
            // lblminutos
            // 
            this.lblminutos.AutoSize = true;
            this.lblminutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutos.Location = new System.Drawing.Point(18, 140);
            this.lblminutos.Name = "lblminutos";
            this.lblminutos.Size = new System.Drawing.Size(62, 15);
            this.lblminutos.TabIndex = 6;
            this.lblminutos.Text = "Minutos:";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(216, 138);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(231, 266);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblduracion
            // 
            this.lblduracion.AutoSize = true;
            this.lblduracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduracion.Location = new System.Drawing.Point(22, 183);
            this.lblduracion.Name = "lblduracion";
            this.lblduracion.Size = new System.Drawing.Size(69, 15);
            this.lblduracion.TabIndex = 9;
            this.lblduracion.Text = "Duracion:";
            // 
            // lblminutoos
            // 
            this.lblminutoos.AutoSize = true;
            this.lblminutoos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutoos.Location = new System.Drawing.Point(103, 183);
            this.lblminutoos.Name = "lblminutoos";
            this.lblminutoos.Size = new System.Drawing.Size(58, 15);
            this.lblminutoos.TabIndex = 10;
            this.lblminutoos.Text = "minutos";
            this.lblminutoos.Visible = false;
            // 
            // lbltarifa
            // 
            this.lbltarifa.AutoSize = true;
            this.lbltarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarifa.Location = new System.Drawing.Point(43, 254);
            this.lbltarifa.Name = "lbltarifa";
            this.lbltarifa.Size = new System.Drawing.Size(48, 15);
            this.lbltarifa.TabIndex = 11;
            this.lbltarifa.Text = "Tarifa:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(103, 254);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(70, 16);
            this.lblresultado.TabIndex = 12;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescuento.Location = new System.Drawing.Point(12, 223);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(79, 15);
            this.lbldescuento.TabIndex = 13;
            this.lbldescuento.Text = "Descuento:";
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje.Location = new System.Drawing.Point(103, 225);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(76, 15);
            this.lblporcentaje.TabIndex = 14;
            this.lblporcentaje.Text = "Porcentaje";
            this.lblporcentaje.Visible = false;
            // 
            // Ejercicio2_TarifasLlamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 301);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbltarifa);
            this.Controls.Add(this.lblminutoos);
            this.Controls.Add(this.lblduracion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblminutos);
            this.Controls.Add(this.lbllugar);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.lblmensaje1);
            this.Controls.Add(this.cmblugares);
            this.Controls.Add(this.txtminutos);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio2_TarifasLlamadas";
            this.Text = "Ejercicio2_TarifasLlamadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtminutos;
        private System.Windows.Forms.ComboBox cmblugares;
        private System.Windows.Forms.Label lblmensaje1;
        private System.Windows.Forms.Label lblmensaje2;
        private System.Windows.Forms.Label lbllugar;
        private System.Windows.Forms.Label lblminutos;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblduracion;
        private System.Windows.Forms.Label lblminutoos;
        private System.Windows.Forms.Label lbltarifa;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lblporcentaje;
    }
}
namespace Taller1_ProgramacionNetEjercicios
{
    partial class Ejercicio3_NotasEstudiante
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
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblmensaje1 = new System.Windows.Forms.Label();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.lblnota4 = new System.Windows.Forms.Label();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblmensaje3 = new System.Windows.Forms.Label();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(55, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(176, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Promedio Estudiante";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(98, 99);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 20);
            this.txtnota1.TabIndex = 1;
            this.txtnota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnota1_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(213, 197);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblmensaje1
            // 
            this.lblmensaje1.AutoSize = true;
            this.lblmensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje1.Location = new System.Drawing.Point(56, 41);
            this.lblmensaje1.Name = "lblmensaje1";
            this.lblmensaje1.Size = new System.Drawing.Size(65, 15);
            this.lblmensaje1.TabIndex = 3;
            this.lblmensaje1.Text = "mensaje 1";
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota1.Location = new System.Drawing.Point(43, 102);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(53, 15);
            this.lblnota1.TabIndex = 4;
            this.lblnota1.Text = "Nota 1:";
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota2.Location = new System.Drawing.Point(43, 141);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(53, 15);
            this.lblnota2.TabIndex = 5;
            this.lblnota2.Text = "Nota 2:";
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota3.Location = new System.Drawing.Point(43, 171);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(49, 13);
            this.lblnota3.TabIndex = 6;
            this.lblnota3.Text = "Nota 3:";
            // 
            // lblnota4
            // 
            this.lblnota4.AutoSize = true;
            this.lblnota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota4.Location = new System.Drawing.Point(43, 202);
            this.lblnota4.Name = "lblnota4";
            this.lblnota4.Size = new System.Drawing.Size(53, 15);
            this.lblnota4.TabIndex = 7;
            this.lblnota4.Text = "Nota 4:";
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(23, 251);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(73, 15);
            this.lblpromedio.TabIndex = 8;
            this.lblpromedio.Text = "Promedio:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(110, 251);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(63, 15);
            this.lblresultado.TabIndex = 9;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // lblmensaje3
            // 
            this.lblmensaje3.AutoSize = true;
            this.lblmensaje3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje3.Location = new System.Drawing.Point(43, 297);
            this.lblmensaje3.Name = "lblmensaje3";
            this.lblmensaje3.Size = new System.Drawing.Size(65, 15);
            this.lblmensaje3.TabIndex = 10;
            this.lblmensaje3.Text = "mensaje 3";
            this.lblmensaje3.Visible = false;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(98, 138);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 11;
            this.txtnota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnota2_KeyPress);
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(98, 168);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 20);
            this.txtnota3.TabIndex = 12;
            this.txtnota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnota3_KeyPress);
            // 
            // txtnota4
            // 
            this.txtnota4.Location = new System.Drawing.Point(98, 199);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(100, 20);
            this.txtnota4.TabIndex = 13;
            this.txtnota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnota4_KeyPress);
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje2.Location = new System.Drawing.Point(56, 56);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(65, 15);
            this.lblmensaje2.TabIndex = 14;
            this.lblmensaje2.Text = "mensaje 2";
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(213, 302);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Ejercicio3_NotasEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 337);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.lblmensaje3);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.lblnota4);
            this.Controls.Add(this.lblnota3);
            this.Controls.Add(this.lblnota2);
            this.Controls.Add(this.lblnota1);
            this.Controls.Add(this.lblmensaje1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio3_NotasEstudiante";
            this.Text = "Ejercicio3_NotasEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblmensaje1;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.Label lblnota4;
        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblmensaje3;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.Label lblmensaje2;
        private System.Windows.Forms.Button btnsalir;
    }
}
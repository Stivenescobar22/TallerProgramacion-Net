namespace Taller1_ProgramacionNetEjercicios
{
    partial class Ejercicio1_Ind_MasaCorporal
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
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblestatura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblimc = new System.Windows.Forms.Label();
            this.lblmensaje3 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblmensaje1 = new System.Windows.Forms.Label();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(109, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(41, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "IMC";
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(90, 100);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 20);
            this.txtestatura.TabIndex = 1;
            this.txtestatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtestatura_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(207, 133);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestatura.Location = new System.Drawing.Point(22, 103);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(68, 15);
            this.lblestatura.TabIndex = 3;
            this.lblestatura.Text = "Estatura: ";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(22, 136);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(43, 15);
            this.lblpeso.TabIndex = 4;
            this.lblpeso.Text = "Peso:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(87, 185);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(63, 15);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.Location = new System.Drawing.Point(22, 185);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(40, 15);
            this.lblimc.TabIndex = 6;
            this.lblimc.Text = "IMC :";
            // 
            // lblmensaje3
            // 
            this.lblmensaje3.AutoSize = true;
            this.lblmensaje3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje3.Location = new System.Drawing.Point(87, 221);
            this.lblmensaje3.Name = "lblmensaje3";
            this.lblmensaje3.Size = new System.Drawing.Size(70, 16);
            this.lblmensaje3.TabIndex = 7;
            this.lblmensaje3.Text = "Mensaje 3";
            this.lblmensaje3.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(207, 162);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(90, 133);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 9;
            this.txtpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpeso_KeyPress);
            // 
            // lblmensaje1
            // 
            this.lblmensaje1.AutoSize = true;
            this.lblmensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje1.Location = new System.Drawing.Point(22, 47);
            this.lblmensaje1.Name = "lblmensaje1";
            this.lblmensaje1.Size = new System.Drawing.Size(67, 16);
            this.lblmensaje1.TabIndex = 10;
            this.lblmensaje1.Text = "mensaje1";
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje2.Location = new System.Drawing.Point(22, 63);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(70, 16);
            this.lblmensaje2.TabIndex = 11;
            this.lblmensaje2.Text = "mensaje 2";
            // 
            // Ejercicio1_Ind_MasaCorporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 265);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.lblmensaje1);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblmensaje3);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio1_Ind_MasaCorporal";
            this.Text = "Ejercicio1_Ind_MasaCorporal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Label lblmensaje3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblmensaje1;
        private System.Windows.Forms.Label lblmensaje2;
    }
}
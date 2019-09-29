namespace Taller1_ProgramacionNetEjercicios
{
    partial class Ejercicio5_RaizCuadrada
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblmensaje1 = new System.Windows.Forms.Label();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblraiz = new System.Windows.Forms.Label();
            this.lblmensaje3 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(41, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(119, 18);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Raiz Cuadrada";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(94, 84);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(104, 110);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(187, 205);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblmensaje1
            // 
            this.lblmensaje1.AutoSize = true;
            this.lblmensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje1.Location = new System.Drawing.Point(55, 40);
            this.lblmensaje1.Name = "lblmensaje1";
            this.lblmensaje1.Size = new System.Drawing.Size(65, 15);
            this.lblmensaje1.TabIndex = 4;
            this.lblmensaje1.Text = "mensaje 1";
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje2.Location = new System.Drawing.Point(55, 53);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(65, 15);
            this.lblmensaje2.TabIndex = 5;
            this.lblmensaje2.Text = "mensaje 2";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(26, 85);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(62, 15);
            this.lblnumero.TabIndex = 6;
            this.lblnumero.Text = "Numero:";
            // 
            // lblraiz
            // 
            this.lblraiz.AutoSize = true;
            this.lblraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraiz.Location = new System.Drawing.Point(26, 159);
            this.lblraiz.Name = "lblraiz";
            this.lblraiz.Size = new System.Drawing.Size(44, 15);
            this.lblraiz.TabIndex = 7;
            this.lblraiz.Text = "Raiz: ";
            // 
            // lblmensaje3
            // 
            this.lblmensaje3.AutoSize = true;
            this.lblmensaje3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje3.Location = new System.Drawing.Point(26, 190);
            this.lblmensaje3.Name = "lblmensaje3";
            this.lblmensaje3.Size = new System.Drawing.Size(65, 15);
            this.lblmensaje3.TabIndex = 8;
            this.lblmensaje3.Text = "mensaje 3";
            this.lblmensaje3.Visible = false;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(82, 159);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(64, 16);
            this.lblresultado.TabIndex = 9;
            this.lblresultado.Text = "resultado";
            this.lblresultado.Visible = false;
            // 
            // Ejercicio5_RaizCuadrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 240);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblmensaje3);
            this.Controls.Add(this.lblraiz);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.lblmensaje1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio5_RaizCuadrada";
            this.Text = "Ejercicio5_RaizCuadrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblmensaje1;
        private System.Windows.Forms.Label lblmensaje2;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblraiz;
        private System.Windows.Forms.Label lblmensaje3;
        private System.Windows.Forms.Label lblresultado;
    }
}
namespace Taller1_ProgramacionNetEjercicios
{
    partial class Ejercicio9_MostrarEdad
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
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbledad = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbledadd = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lblmostraredad = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(72, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(110, 18);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Mostrar Edad";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(62, 76);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 1;
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(72, 58);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(96, 15);
            this.lbledad.TabIndex = 2;
            this.lbledad.Text = "Ingrese Edad:";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(75, 102);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lbledadd
            // 
            this.lbledadd.AutoSize = true;
            this.lbledadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledadd.Location = new System.Drawing.Point(48, 151);
            this.lbledadd.Name = "lbledadd";
            this.lbledadd.Size = new System.Drawing.Size(44, 15);
            this.lbledadd.TabIndex = 4;
            this.lbledadd.Text = "Edad:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(48, 182);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(60, 16);
            this.lblmensaje.TabIndex = 5;
            this.lblmensaje.Text = "mensaje";
            this.lblmensaje.Visible = false;
            // 
            // lblmostraredad
            // 
            this.lblmostraredad.AutoSize = true;
            this.lblmostraredad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostraredad.Location = new System.Drawing.Point(98, 153);
            this.lblmostraredad.Name = "lblmostraredad";
            this.lblmostraredad.Size = new System.Drawing.Size(49, 15);
            this.lblmostraredad.TabIndex = 6;
            this.lblmostraredad.Text = "mostrar";
            this.lblmostraredad.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(170, 210);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Ejercicio9_MostrarEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 245);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblmostraredad);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lbledadd);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio9_MostrarEdad";
            this.Text = "Ejercicio9_MostrarEdad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbledadd;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lblmostraredad;
        private System.Windows.Forms.Button btnsalir;
    }
}
namespace Taller1_ProgramacionNetEjercicios
{
    partial class Ejercicio8_TrianguloRectangulo
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
            this.txthipotenusa = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblhipotenusa = new System.Windows.Forms.Label();
            this.lblcatetoa = new System.Windows.Forms.Label();
            this.lblcatetob = new System.Windows.Forms.Label();
            this.txtcatetoa = new System.Windows.Forms.TextBox();
            this.txtcatetob = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(45, 25);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(168, 18);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Triangulo Rectangulo";
            // 
            // txthipotenusa
            // 
            this.txthipotenusa.Location = new System.Drawing.Point(113, 73);
            this.txthipotenusa.Name = "txthipotenusa";
            this.txthipotenusa.Size = new System.Drawing.Size(100, 20);
            this.txthipotenusa.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(86, 183);
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
            this.btnsalir.Location = new System.Drawing.Point(197, 243);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblhipotenusa
            // 
            this.lblhipotenusa.AutoSize = true;
            this.lblhipotenusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhipotenusa.Location = new System.Drawing.Point(21, 74);
            this.lblhipotenusa.Name = "lblhipotenusa";
            this.lblhipotenusa.Size = new System.Drawing.Size(84, 15);
            this.lblhipotenusa.TabIndex = 4;
            this.lblhipotenusa.Text = "Hipotenusa:";
            // 
            // lblcatetoa
            // 
            this.lblcatetoa.AutoSize = true;
            this.lblcatetoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatetoa.Location = new System.Drawing.Point(41, 106);
            this.lblcatetoa.Name = "lblcatetoa";
            this.lblcatetoa.Size = new System.Drawing.Size(64, 15);
            this.lblcatetoa.TabIndex = 5;
            this.lblcatetoa.Text = "Cateto A:";
            // 
            // lblcatetob
            // 
            this.lblcatetob.AutoSize = true;
            this.lblcatetob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatetob.Location = new System.Drawing.Point(40, 142);
            this.lblcatetob.Name = "lblcatetob";
            this.lblcatetob.Size = new System.Drawing.Size(65, 15);
            this.lblcatetob.TabIndex = 6;
            this.lblcatetob.Text = "Cateto B:";
            // 
            // txtcatetoa
            // 
            this.txtcatetoa.Location = new System.Drawing.Point(113, 105);
            this.txtcatetoa.Name = "txtcatetoa";
            this.txtcatetoa.Size = new System.Drawing.Size(100, 20);
            this.txtcatetoa.TabIndex = 7;
            // 
            // txtcatetob
            // 
            this.txtcatetob.Location = new System.Drawing.Point(113, 141);
            this.txtcatetob.Name = "txtcatetob";
            this.txtcatetob.Size = new System.Drawing.Size(100, 20);
            this.txtcatetob.TabIndex = 8;
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarea.Location = new System.Drawing.Point(34, 243);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(40, 15);
            this.lblarea.TabIndex = 9;
            this.lblarea.Text = "Area:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(92, 243);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(70, 16);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(34, 278);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(55, 15);
            this.lblmensaje.TabIndex = 11;
            this.lblmensaje.Text = "mensaje";
            this.lblmensaje.Visible = false;
            // 
            // Ejercicio8_TrianguloRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 311);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.txtcatetob);
            this.Controls.Add(this.txtcatetoa);
            this.Controls.Add(this.lblcatetob);
            this.Controls.Add(this.lblcatetoa);
            this.Controls.Add(this.lblhipotenusa);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txthipotenusa);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio8_TrianguloRectangulo";
            this.Text = "Ejercicio8_TrianguloRectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txthipotenusa;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblhipotenusa;
        private System.Windows.Forms.Label lblcatetoa;
        private System.Windows.Forms.Label lblcatetob;
        private System.Windows.Forms.TextBox txtcatetoa;
        private System.Windows.Forms.TextBox txtcatetob;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblmensaje;
    }
}
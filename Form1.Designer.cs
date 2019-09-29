namespace Taller1_ProgramacionNetEjercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgbcargando = new System.Windows.Forms.ProgressBar();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblcargando = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbcargando
            // 
            this.pgbcargando.Location = new System.Drawing.Point(59, 90);
            this.pgbcargando.Name = "pgbcargando";
            this.pgbcargando.Size = new System.Drawing.Size(127, 23);
            this.pgbcargando.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(24, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(210, 19);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Taller 1 programacion .Net";
            // 
            // lblcargando
            // 
            this.lblcargando.AutoSize = true;
            this.lblcargando.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargando.Location = new System.Drawing.Point(84, 70);
            this.lblcargando.Name = "lblcargando";
            this.lblcargando.Size = new System.Drawing.Size(64, 17);
            this.lblcargando.TabIndex = 2;
            this.lblcargando.Text = "cargando";
            this.lblcargando.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 192);
            this.Controls.Add(this.lblcargando);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.pgbcargando);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbcargando;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblcargando;
        private System.Windows.Forms.Timer timer1;
    }
}


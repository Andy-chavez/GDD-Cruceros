namespace FrbaCrucero.AbmCrucero
{
    partial class GestionDePasajesPorBaja
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonPosponer = new System.Windows.Forms.Button();
            this.diasCorrimiento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.motivo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonPosponer);
            this.groupBox2.Controls.Add(this.diasCorrimiento);
            this.groupBox2.Location = new System.Drawing.Point(37, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese dias de corrimiento en caso de querer posponer viajes";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // botonPosponer
            // 
            this.botonPosponer.Location = new System.Drawing.Point(357, 27);
            this.botonPosponer.Name = "botonPosponer";
            this.botonPosponer.Size = new System.Drawing.Size(90, 23);
            this.botonPosponer.TabIndex = 4;
            this.botonPosponer.Text = "Posponer";
            this.botonPosponer.UseVisualStyleBackColor = true;
            this.botonPosponer.Click += new System.EventHandler(this.BotonPosponer_Click);
            // 
            // diasCorrimiento
            // 
            this.diasCorrimiento.Location = new System.Drawing.Point(106, 29);
            this.diasCorrimiento.Name = "diasCorrimiento";
            this.diasCorrimiento.Size = new System.Drawing.Size(222, 20);
            this.diasCorrimiento.TabIndex = 0;
            this.diasCorrimiento.TextChanged += new System.EventHandler(this.DiasCorrimiento_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.motivo);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese motivo en caso de querer cancelar pasajes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // motivo
            // 
            this.motivo.Location = new System.Drawing.Point(106, 29);
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(222, 20);
            this.motivo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(37, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 71);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Presione aqui en caso si quiere reeemplazar el crucero por otro cucero disponible" +
    "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reemplazar crucero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(37, 237);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(76, 23);
            this.botonVolver.TabIndex = 8;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // GestionDePasajesPorBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 270);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionDePasajesPorBaja";
            this.Text = "GestionDePasajesPorBaja";
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonPosponer;
        private System.Windows.Forms.TextBox diasCorrimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox motivo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonVolver;
    }
}
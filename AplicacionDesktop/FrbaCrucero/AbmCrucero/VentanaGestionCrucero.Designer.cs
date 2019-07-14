namespace FrbaCrucero.AbmCrucero
{
    partial class VentanaGestionCrucero
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
            this.botonAlta = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(46, 22);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(139, 23);
            this.botonAlta.TabIndex = 0;
            this.botonAlta.Text = "Dar de Alta";
            this.botonAlta.UseVisualStyleBackColor = true;
            this.botonAlta.Click += new System.EventHandler(this.botonAlta_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(46, 62);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(139, 23);
            this.botonModificar.TabIndex = 1;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(46, 101);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(139, 23);
            this.botonBaja.TabIndex = 2;
            this.botonBaja.Text = "Dar de Baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            this.botonBaja.Click += new System.EventHandler(this.botonBaja_Click);
            // 
            // VentanaGestionCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 147);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonAlta);
            this.Name = "VentanaGestionCrucero";
            this.Text = "Cruceros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaGestionCrucero_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAlta;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonBaja;
    }
}
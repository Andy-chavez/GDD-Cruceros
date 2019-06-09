namespace FrbaCrucero.AbmPuerto
{
    partial class VentanaGestionarPuerto
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
            this.botonBaja = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(59, 35);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(156, 23);
            this.botonAlta.TabIndex = 0;
            this.botonAlta.Text = "Dar de Alta";
            this.botonAlta.UseVisualStyleBackColor = true;
            this.botonAlta.Click += new System.EventHandler(this.botonAlta_Click);
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(59, 80);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(156, 23);
            this.botonBaja.TabIndex = 1;
            this.botonBaja.Text = "Dar de Baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(59, 127);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(156, 23);
            this.botonModificar.TabIndex = 2;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonListado
            // 
            this.botonListado.Location = new System.Drawing.Point(59, 171);
            this.botonListado.Name = "botonListado";
            this.botonListado.Size = new System.Drawing.Size(156, 23);
            this.botonListado.TabIndex = 3;
            this.botonListado.Text = "Listado";
            this.botonListado.UseVisualStyleBackColor = true;
            this.botonListado.Click += new System.EventHandler(this.botonListado_Click);
            // 
            // VentanaGestionarPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botonListado);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.botonAlta);
            this.Name = "VentanaGestionarPuerto";
            this.Text = "VentanaGestionarPuerto";
            this.Load += new System.EventHandler(this.VentanaGestionarPuerto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAlta;
        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonListado;
    }
}
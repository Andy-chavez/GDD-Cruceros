namespace FrbaCrucero.GeneracionViaje
{
    partial class VentanaOperacion
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
            this.botonComprar = new System.Windows.Forms.Button();
            this.botonReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonComprar
            // 
            this.botonComprar.Location = new System.Drawing.Point(58, 67);
            this.botonComprar.Name = "botonComprar";
            this.botonComprar.Size = new System.Drawing.Size(154, 37);
            this.botonComprar.TabIndex = 0;
            this.botonComprar.Text = "Comprar";
            this.botonComprar.UseVisualStyleBackColor = true;
            // 
            // botonReservar
            // 
            this.botonReservar.Location = new System.Drawing.Point(58, 138);
            this.botonReservar.Name = "botonReservar";
            this.botonReservar.Size = new System.Drawing.Size(154, 36);
            this.botonReservar.TabIndex = 1;
            this.botonReservar.Text = "Reservar";
            this.botonReservar.UseVisualStyleBackColor = true;
            // 
            // VentanaOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botonReservar);
            this.Controls.Add(this.botonComprar);
            this.Name = "VentanaOperacion";
            this.Text = "Que desea hacer?";
            this.Load += new System.EventHandler(this.VentanaOperacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonComprar;
        private System.Windows.Forms.Button botonReservar;
    }
}
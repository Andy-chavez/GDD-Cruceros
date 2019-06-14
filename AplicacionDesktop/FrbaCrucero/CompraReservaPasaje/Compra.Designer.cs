namespace FrbaCrucero.CompraReservaPasaje
{
    partial class Compra
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
            this.buttonMedio = new System.Windows.Forms.Button();
            this.Pagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMedio
            // 
            this.buttonMedio.Location = new System.Drawing.Point(69, 41);
            this.buttonMedio.Name = "buttonMedio";
            this.buttonMedio.Size = new System.Drawing.Size(142, 23);
            this.buttonMedio.TabIndex = 0;
            this.buttonMedio.Text = "Ingresar Medio de Pago";
            this.buttonMedio.UseVisualStyleBackColor = true;
            this.buttonMedio.Click += new System.EventHandler(this.buttonMedio_Click);
            // 
            // Pagar
            // 
            this.Pagar.Location = new System.Drawing.Point(99, 97);
            this.Pagar.Name = "Pagar";
            this.Pagar.Size = new System.Drawing.Size(75, 23);
            this.Pagar.TabIndex = 1;
            this.Pagar.Text = "Pagar";
            this.Pagar.UseVisualStyleBackColor = true;
            this.Pagar.Click += new System.EventHandler(this.Pagar_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.Pagar);
            this.Controls.Add(this.buttonMedio);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMedio;
        private System.Windows.Forms.Button Pagar;
    }
}
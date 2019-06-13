namespace FrbaCrucero.PagoReserva
{
    partial class VentanaPagoReserva
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
            this.comboBoxReserva = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPago = new System.Windows.Forms.ComboBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxReserva
            // 
            this.comboBoxReserva.FormattingEnabled = true;
            this.comboBoxReserva.Location = new System.Drawing.Point(113, 63);
            this.comboBoxReserva.Name = "comboBoxReserva";
            this.comboBoxReserva.Size = new System.Drawing.Size(214, 21);
            this.comboBoxReserva.TabIndex = 9;
            this.comboBoxReserva.SelectedIndexChanged += new System.EventHandler(this.comboBoxReserva_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID_Reserva";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID_Pago";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxPago
            // 
            this.comboBoxPago.FormattingEnabled = true;
            this.comboBoxPago.Location = new System.Drawing.Point(113, 155);
            this.comboBoxPago.Name = "comboBoxPago";
            this.comboBoxPago.Size = new System.Drawing.Size(214, 21);
            this.comboBoxPago.TabIndex = 12;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(15, 231);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 13;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonPagar
            // 
            this.botonPagar.Location = new System.Drawing.Point(252, 231);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(75, 23);
            this.botonPagar.TabIndex = 14;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = true;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // VentanaPagoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 275);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.comboBoxPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxReserva);
            this.Name = "VentanaPagoReserva";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaPagoReserva_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPago;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonPagar;
    }
}
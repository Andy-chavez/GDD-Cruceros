namespace FrbaCrucero.PagoReserva
{
    partial class VentanaPagoDeReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reserva = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonPagar = new System.Windows.Forms.Button();
            this.MedioDePago = new System.Windows.Forms.GroupBox();
            this.comboBoxMedios = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.MedioDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reserva);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Id de reserva";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // reserva
            // 
            this.reserva.Location = new System.Drawing.Point(52, 38);
            this.reserva.Name = "reserva";
            this.reserva.Size = new System.Drawing.Size(294, 20);
            this.reserva.TabIndex = 1;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(38, 192);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(93, 23);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // botonPagar
            // 
            this.botonPagar.Location = new System.Drawing.Point(353, 192);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(93, 23);
            this.botonPagar.TabIndex = 4;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = true;
            this.botonPagar.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // MedioDePago
            // 
            this.MedioDePago.Controls.Add(this.comboBoxMedios);
            this.MedioDePago.Location = new System.Drawing.Point(38, 98);
            this.MedioDePago.Name = "MedioDePago";
            this.MedioDePago.Size = new System.Drawing.Size(408, 70);
            this.MedioDePago.TabIndex = 5;
            this.MedioDePago.TabStop = false;
            this.MedioDePago.Text = "Elija Medio de Pago";
            this.MedioDePago.Enter += new System.EventHandler(this.GroupBox2_Enter_1);
            // 
            // comboBoxMedios
            // 
            this.comboBoxMedios.FormattingEnabled = true;
            this.comboBoxMedios.Location = new System.Drawing.Point(52, 14);
            this.comboBoxMedios.Name = "comboBoxMedios";
            this.comboBoxMedios.Size = new System.Drawing.Size(294, 21);
            this.comboBoxMedios.TabIndex = 0;
            this.comboBoxMedios.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMedios_SelectedIndexChanged);
            // 
            // VentanaPagoDeReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 227);
            this.Controls.Add(this.MedioDePago);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaPagoDeReserva";
            this.Text = "Pago de Reserva";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaPagoDeReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MedioDePago.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox reserva;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonPagar;
        private System.Windows.Forms.GroupBox MedioDePago;
        private System.Windows.Forms.ComboBox comboBoxMedios;
    }
}
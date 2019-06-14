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
            this.botonCrear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pago = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.botonVolver.Location = new System.Drawing.Point(38, 213);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(93, 23);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(353, 213);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(93, 23);
            this.botonCrear.TabIndex = 4;
            this.botonCrear.Text = "Asociar Pago";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pago);
            this.groupBox2.Location = new System.Drawing.Point(38, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese id de pago de reserva";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // pago
            // 
            this.pago.Location = new System.Drawing.Point(52, 38);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(294, 20);
            this.pago.TabIndex = 1;
            this.pago.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // VentanaPagoDeReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaPagoDeReserva";
            this.Text = "Pago de Reserva";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox reserva;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pago;
    }
}
namespace FrbaCrucero.CompraReservaPasaje
{
    partial class VentanaSeleccionarviaje
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
            this.viajesDisponibles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.viajesDisponibles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viajesDisponibles
            // 
            this.viajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajesDisponibles.Location = new System.Drawing.Point(23, 44);
            this.viajesDisponibles.Name = "viajesDisponibles";
            this.viajesDisponibles.Size = new System.Drawing.Size(439, 245);
            this.viajesDisponibles.TabIndex = 0;
            this.viajesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viajesDisponibles_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viajesDisponibles);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "seleccionar viajes disponibles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VentanaSeleccionarviaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 379);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaSeleccionarviaje";
            this.Text = "VentanaSeleccionarviaje";
            ((System.ComponentModel.ISupportInitialize)(this.viajesDisponibles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viajesDisponibles;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}
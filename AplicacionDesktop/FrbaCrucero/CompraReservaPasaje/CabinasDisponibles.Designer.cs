namespace FrbaCrucero.CompraReservaPasaje
{
    partial class CabinasDisponibles
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
            this.CabinasParaSeleccionar = new System.Windows.Forms.DataGridView();
            this.Cabinas = new System.Windows.Forms.GroupBox();
            this.SeleccionCabina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CabinasParaSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // CabinasParaSeleccionar
            // 
            this.CabinasParaSeleccionar.AllowDrop = true;
            this.CabinasParaSeleccionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CabinasParaSeleccionar.Location = new System.Drawing.Point(22, 57);
            this.CabinasParaSeleccionar.Name = "CabinasParaSeleccionar";
            this.CabinasParaSeleccionar.Size = new System.Drawing.Size(564, 187);
            this.CabinasParaSeleccionar.TabIndex = 0;
            this.CabinasParaSeleccionar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Cabinas
            // 
            this.Cabinas.Location = new System.Drawing.Point(22, 38);
            this.Cabinas.Name = "Cabinas";
            this.Cabinas.Size = new System.Drawing.Size(564, 13);
            this.Cabinas.TabIndex = 1;
            this.Cabinas.TabStop = false;
            this.Cabinas.Text = "Elija Cabina";
            this.Cabinas.Enter += new System.EventHandler(this.Cabinas_Enter);
            // 
            // SeleccionCabina
            // 
            this.SeleccionCabina.Location = new System.Drawing.Point(493, 268);
            this.SeleccionCabina.Name = "SeleccionCabina";
            this.SeleccionCabina.Size = new System.Drawing.Size(93, 23);
            this.SeleccionCabina.TabIndex = 2;
            this.SeleccionCabina.Text = "Seleccionar";
            this.SeleccionCabina.UseVisualStyleBackColor = true;
            this.SeleccionCabina.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CabinasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 337);
            this.Controls.Add(this.SeleccionCabina);
            this.Controls.Add(this.Cabinas);
            this.Controls.Add(this.CabinasParaSeleccionar);
            this.Name = "CabinasDisponibles";
            this.Text = "CabinasDisponibles";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CabinasDisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CabinasParaSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CabinasParaSeleccionar;
        private System.Windows.Forms.GroupBox Cabinas;
        private System.Windows.Forms.Button SeleccionCabina;
    }
}
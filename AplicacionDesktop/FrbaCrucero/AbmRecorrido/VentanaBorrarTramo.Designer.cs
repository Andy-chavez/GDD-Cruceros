namespace FrbaCrucero.AbmRecorrido
{
    partial class VentanaBorrarTramo
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
            this.botonBorrar = new System.Windows.Forms.Button();
            this.dataGridTramos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).BeginInit();
            this.SuspendLayout();
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(217, 262);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 9;
            this.botonBorrar.Text = "Eliminar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // dataGridTramos
            // 
            this.dataGridTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramos.Location = new System.Drawing.Point(39, 24);
            this.dataGridTramos.Name = "dataGridTramos";
            this.dataGridTramos.Size = new System.Drawing.Size(253, 216);
            this.dataGridTramos.TabIndex = 11;
            // 
            // VentanaBorrarTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 317);
            this.Controls.Add(this.dataGridTramos);
            this.Controls.Add(this.botonBorrar);
            this.Name = "VentanaBorrarTramo";
            this.Text = "Borrar Tramo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.DataGridView dataGridTramos;
    }
}
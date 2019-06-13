namespace FrbaCrucero.AbmRecorrido
{
    partial class VentanaModificarRecorrido
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
            this.recorridosActuales = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tramosDisponibles = new System.Windows.Forms.DataGridView();
            this.textoRecorridoSeleccionado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonAgregarTramo = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recorridosActuales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // recorridosActuales
            // 
            this.recorridosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recorridosActuales.Location = new System.Drawing.Point(7, 19);
            this.recorridosActuales.Name = "recorridosActuales";
            this.recorridosActuales.Size = new System.Drawing.Size(589, 142);
            this.recorridosActuales.TabIndex = 0;
            this.recorridosActuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosActuales_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.recorridosActuales);
            this.groupBox1.Location = new System.Drawing.Point(21, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos Actuales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tramosDisponibles);
            this.groupBox2.Location = new System.Drawing.Point(21, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tramos disponibles";
            // 
            // tramosDisponibles
            // 
            this.tramosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tramosDisponibles.Location = new System.Drawing.Point(7, 20);
            this.tramosDisponibles.Name = "tramosDisponibles";
            this.tramosDisponibles.Size = new System.Drawing.Size(589, 144);
            this.tramosDisponibles.TabIndex = 0;

            // 
            // textoRecorridoSeleccionado
            // 
            this.textoRecorridoSeleccionado.Location = new System.Drawing.Point(167, 229);
            this.textoRecorridoSeleccionado.Name = "textoRecorridoSeleccionado";
            this.textoRecorridoSeleccionado.ReadOnly = true;
            this.textoRecorridoSeleccionado.Size = new System.Drawing.Size(263, 20);
            this.textoRecorridoSeleccionado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recorrido seleccionado";
            // 
            // botonAgregarTramo
            // 
            this.botonAgregarTramo.Location = new System.Drawing.Point(454, 456);
            this.botonAgregarTramo.Name = "botonAgregarTramo";
            this.botonAgregarTramo.Size = new System.Drawing.Size(163, 23);
            this.botonAgregarTramo.TabIndex = 5;
            this.botonAgregarTramo.Text = "AgregarTramo";
            this.botonAgregarTramo.UseVisualStyleBackColor = true;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(517, 229);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // VentanaModificarRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 505);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonAgregarTramo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoRecorridoSeleccionado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaModificarRecorrido";
            this.Text = "VentanaBajaRecorrido";
            this.Load += new System.EventHandler(this.VentanaModificarRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recorridosActuales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tramosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recorridosActuales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tramosDisponibles;
        private System.Windows.Forms.TextBox textoRecorridoSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAgregarTramo;
        private System.Windows.Forms.Button botonLimpiar;
    }
}
namespace FrbaCrucero.AbmRecorrido
{
    partial class VentanaDarDeBajaRecorrido
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
            this.dataGridRecorridosActuales = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoRecorridoSeleccionado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonDardeBaja = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridTramos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorridosActuales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRecorridosActuales
            // 
            this.dataGridRecorridosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecorridosActuales.Location = new System.Drawing.Point(7, 19);
            this.dataGridRecorridosActuales.Name = "dataGridRecorridosActuales";
            this.dataGridRecorridosActuales.ReadOnly = true;
            this.dataGridRecorridosActuales.Size = new System.Drawing.Size(589, 142);
            this.dataGridRecorridosActuales.TabIndex = 0;
            this.dataGridRecorridosActuales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosActuales_CellClick);
            this.dataGridRecorridosActuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosActuales_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridRecorridosActuales);
            this.groupBox1.Location = new System.Drawing.Point(21, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos Actuales";
            // 
            // textoRecorridoSeleccionado
            // 
            this.textoRecorridoSeleccionado.Location = new System.Drawing.Point(167, 414);
            this.textoRecorridoSeleccionado.Name = "textoRecorridoSeleccionado";
            this.textoRecorridoSeleccionado.ReadOnly = true;
            this.textoRecorridoSeleccionado.Size = new System.Drawing.Size(263, 20);
            this.textoRecorridoSeleccionado.TabIndex = 3;
            this.textoRecorridoSeleccionado.TextChanged += new System.EventHandler(this.textoRecorridoSeleccionado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recorrido seleccionado";
            // 
            // botonDardeBaja
            // 
            this.botonDardeBaja.Location = new System.Drawing.Point(485, 414);
            this.botonDardeBaja.Name = "botonDardeBaja";
            this.botonDardeBaja.Size = new System.Drawing.Size(132, 23);
            this.botonDardeBaja.TabIndex = 6;
            this.botonDardeBaja.Text = "Dar de baja";
            this.botonDardeBaja.UseVisualStyleBackColor = true;
            this.botonDardeBaja.Click += new System.EventHandler(this.botonDardeBaja_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridTramos);
            this.groupBox2.Location = new System.Drawing.Point(21, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tramos Correspondientes";
            // 
            // dataGridTramos
            // 
            this.dataGridTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramos.Location = new System.Drawing.Point(7, 19);
            this.dataGridTramos.Name = "dataGridTramos";
            this.dataGridTramos.ReadOnly = true;
            this.dataGridTramos.Size = new System.Drawing.Size(589, 142);
            this.dataGridTramos.TabIndex = 0;
            // 
            // VentanaDarDeBajaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botonDardeBaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoRecorridoSeleccionado);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaDarDeBajaRecorrido";
            this.Text = "Eliminar Recorrido";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaModificarRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorridosActuales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRecorridosActuales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoRecorridoSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonDardeBaja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridTramos;
    }
}
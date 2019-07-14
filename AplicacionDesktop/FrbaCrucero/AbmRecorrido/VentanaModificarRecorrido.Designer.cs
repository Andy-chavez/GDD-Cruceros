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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxFiltroDestino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFiltroOrigen = new System.Windows.Forms.TextBox();
            this.buttonFiltrarRecs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLimpiarRecs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorridosActuales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRecorridosActuales
            // 
            this.dataGridRecorridosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecorridosActuales.Location = new System.Drawing.Point(12, 19);
            this.dataGridRecorridosActuales.Name = "dataGridRecorridosActuales";
            this.dataGridRecorridosActuales.ReadOnly = true;
            this.dataGridRecorridosActuales.Size = new System.Drawing.Size(385, 176);
            this.dataGridRecorridosActuales.TabIndex = 0;
            this.dataGridRecorridosActuales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosActuales_CellClick);
            this.dataGridRecorridosActuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosActuales_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridRecorridosActuales);
            this.groupBox1.Location = new System.Drawing.Point(21, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos Actuales";
            // 
            // textoRecorridoSeleccionado
            // 
            this.textoRecorridoSeleccionado.Location = new System.Drawing.Point(225, 540);
            this.textoRecorridoSeleccionado.Name = "textoRecorridoSeleccionado";
            this.textoRecorridoSeleccionado.ReadOnly = true;
            this.textoRecorridoSeleccionado.Size = new System.Drawing.Size(119, 20);
            this.textoRecorridoSeleccionado.TabIndex = 3;
            this.textoRecorridoSeleccionado.TextChanged += new System.EventHandler(this.textoRecorridoSeleccionado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recorrido seleccionado";
            // 
            // botonDardeBaja
            // 
            this.botonDardeBaja.Location = new System.Drawing.Point(298, 585);
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
            this.groupBox2.Location = new System.Drawing.Point(21, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tramos Correspondientes";
            // 
            // dataGridTramos
            // 
            this.dataGridTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramos.Location = new System.Drawing.Point(12, 19);
            this.dataGridTramos.Name = "dataGridTramos";
            this.dataGridTramos.ReadOnly = true;
            this.dataGridTramos.Size = new System.Drawing.Size(385, 142);
            this.dataGridTramos.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxFiltroDestino);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.textBoxFiltroOrigen);
            this.groupBox7.Controls.Add(this.buttonFiltrarRecs);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.buttonLimpiarRecs);
            this.groupBox7.Location = new System.Drawing.Point(21, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(407, 108);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Filtrar Recorrido";
            // 
            // textBoxFiltroDestino
            // 
            this.textBoxFiltroDestino.Location = new System.Drawing.Point(111, 73);
            this.textBoxFiltroDestino.Name = "textBoxFiltroDestino";
            this.textBoxFiltroDestino.Size = new System.Drawing.Size(174, 20);
            this.textBoxFiltroDestino.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Destino";
            // 
            // textBoxFiltroOrigen
            // 
            this.textBoxFiltroOrigen.Location = new System.Drawing.Point(111, 30);
            this.textBoxFiltroOrigen.Name = "textBoxFiltroOrigen";
            this.textBoxFiltroOrigen.Size = new System.Drawing.Size(174, 20);
            this.textBoxFiltroOrigen.TabIndex = 10;
            // 
            // buttonFiltrarRecs
            // 
            this.buttonFiltrarRecs.Location = new System.Drawing.Point(311, 28);
            this.buttonFiltrarRecs.Name = "buttonFiltrarRecs";
            this.buttonFiltrarRecs.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrarRecs.TabIndex = 9;
            this.buttonFiltrarRecs.Text = "Buscar";
            this.buttonFiltrarRecs.UseVisualStyleBackColor = true;
            this.buttonFiltrarRecs.Click += new System.EventHandler(this.buttonFiltrarRecs_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Origen";
            // 
            // buttonLimpiarRecs
            // 
            this.buttonLimpiarRecs.Location = new System.Drawing.Point(311, 71);
            this.buttonLimpiarRecs.Name = "buttonLimpiarRecs";
            this.buttonLimpiarRecs.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarRecs.TabIndex = 6;
            this.buttonLimpiarRecs.Text = "Limpiar";
            this.buttonLimpiarRecs.UseVisualStyleBackColor = true;
            this.buttonLimpiarRecs.Click += new System.EventHandler(this.buttonLimpiarRecs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // VentanaDarDeBajaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(449, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox7);
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxFiltroDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFiltroOrigen;
        private System.Windows.Forms.Button buttonFiltrarRecs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLimpiarRecs;
        private System.Windows.Forms.Button button1;
    }
}
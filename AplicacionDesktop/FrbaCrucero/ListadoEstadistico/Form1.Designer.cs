namespace FrbaCrucero.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            this.top5_rec_pasajes = new System.Windows.Forms.Button();
            this.top5_rec_cabinas = new System.Windows.Forms.Button();
            this.top5cruc_fuera_serv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxAnio = new System.Windows.Forms.ComboBox();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.dataGridViewTop5s = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5s)).BeginInit();
            this.SuspendLayout();
            // 
            // top5_rec_pasajes
            // 
            this.top5_rec_pasajes.Location = new System.Drawing.Point(185, 70);
            this.top5_rec_pasajes.Name = "top5_rec_pasajes";
            this.top5_rec_pasajes.Size = new System.Drawing.Size(257, 23);
            this.top5_rec_pasajes.TabIndex = 0;
            this.top5_rec_pasajes.Text = "Top 5 Recorridos con más Pasajes Comprados";
            this.top5_rec_pasajes.UseVisualStyleBackColor = true;
            this.top5_rec_pasajes.Click += new System.EventHandler(this.top5_rec_pasajes_Click);
            // 
            // top5_rec_cabinas
            // 
            this.top5_rec_cabinas.Location = new System.Drawing.Point(185, 110);
            this.top5_rec_cabinas.Name = "top5_rec_cabinas";
            this.top5_rec_cabinas.Size = new System.Drawing.Size(257, 23);
            this.top5_rec_cabinas.TabIndex = 1;
            this.top5_rec_cabinas.Text = "Top 5 Recorridos con más Cabinas Libres por Viaje";
            this.top5_rec_cabinas.UseVisualStyleBackColor = true;
            this.top5_rec_cabinas.Click += new System.EventHandler(this.button1_Click);
            // 
            // top5cruc_fuera_serv
            // 
            this.top5cruc_fuera_serv.Location = new System.Drawing.Point(185, 150);
            this.top5cruc_fuera_serv.Name = "top5cruc_fuera_serv";
            this.top5cruc_fuera_serv.Size = new System.Drawing.Size(257, 23);
            this.top5cruc_fuera_serv.TabIndex = 2;
            this.top5cruc_fuera_serv.Text = "Top 5 Cruceros con más Días fuera de Servicio";
            this.top5cruc_fuera_serv.UseVisualStyleBackColor = true;
            this.top5cruc_fuera_serv.Click += new System.EventHandler(this.top5cruc_fuera_serv_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Ingrese Año y Semestre";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxAnio
            // 
            this.comboBoxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnio.FormattingEnabled = true;
            this.comboBoxAnio.Items.AddRange(new object[] {
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.comboBoxAnio.Location = new System.Drawing.Point(185, 249);
            this.comboBoxAnio.Name = "comboBoxAnio";
            this.comboBoxAnio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnio.TabIndex = 4;
            this.comboBoxAnio.SelectedIndex = 0;
            this.comboBoxAnio.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnio_SelectedIndexChanged);
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemestre.Location = new System.Drawing.Point(313, 248);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemestre.SelectedIndex = 0;
            this.comboBoxSemestre.TabIndex = 5;
            // 
            // dataGridViewTop5s
            // 
            this.dataGridViewTop5s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop5s.Location = new System.Drawing.Point(12, 304);
            this.dataGridViewTop5s.Name = "dataGridViewTop5s";
            this.dataGridViewTop5s.Size = new System.Drawing.Size(603, 317);
            this.dataGridViewTop5s.TabIndex = 6;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 633);
            this.Controls.Add(this.dataGridViewTop5s);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.comboBoxAnio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.top5cruc_fuera_serv);
            this.Controls.Add(this.top5_rec_cabinas);
            this.Controls.Add(this.top5_rec_pasajes);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5s)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button top5_rec_pasajes;
        private System.Windows.Forms.Button top5_rec_cabinas;
        private System.Windows.Forms.Button top5cruc_fuera_serv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxAnio;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.DataGridView dataGridViewTop5s;
    }
}
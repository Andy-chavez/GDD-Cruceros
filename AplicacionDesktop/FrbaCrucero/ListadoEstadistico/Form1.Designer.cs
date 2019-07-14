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
            this.comboBoxAnio = new System.Windows.Forms.ComboBox();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.dataGridViewTop5s = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5s)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // top5_rec_pasajes
            // 
            this.top5_rec_pasajes.Location = new System.Drawing.Point(52, 32);
            this.top5_rec_pasajes.Name = "top5_rec_pasajes";
            this.top5_rec_pasajes.Size = new System.Drawing.Size(257, 23);
            this.top5_rec_pasajes.TabIndex = 0;
            this.top5_rec_pasajes.Text = "Top 5 Recorridos con más Pasajes Comprados";
            this.top5_rec_pasajes.UseVisualStyleBackColor = true;
            this.top5_rec_pasajes.Click += new System.EventHandler(this.top5_rec_pasajes_Click);
            // 
            // top5_rec_cabinas
            // 
            this.top5_rec_cabinas.Location = new System.Drawing.Point(52, 75);
            this.top5_rec_cabinas.Name = "top5_rec_cabinas";
            this.top5_rec_cabinas.Size = new System.Drawing.Size(257, 23);
            this.top5_rec_cabinas.TabIndex = 1;
            this.top5_rec_cabinas.Text = "Top 5 Recorridos con más Cabinas Libres por Viaje";
            this.top5_rec_cabinas.UseVisualStyleBackColor = true;
            this.top5_rec_cabinas.Click += new System.EventHandler(this.button1_Click);
            // 
            // top5cruc_fuera_serv
            // 
            this.top5cruc_fuera_serv.Location = new System.Drawing.Point(52, 122);
            this.top5cruc_fuera_serv.Name = "top5cruc_fuera_serv";
            this.top5cruc_fuera_serv.Size = new System.Drawing.Size(257, 23);
            this.top5cruc_fuera_serv.TabIndex = 2;
            this.top5cruc_fuera_serv.Text = "Top 5 Cruceros con más Días fuera de Servicio";
            this.top5cruc_fuera_serv.UseVisualStyleBackColor = true;
            this.top5cruc_fuera_serv.Click += new System.EventHandler(this.top5cruc_fuera_serv_Click);
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
            this.comboBoxAnio.Location = new System.Drawing.Point(189, 22);
            this.comboBoxAnio.Name = "comboBoxAnio";
            this.comboBoxAnio.Size = new System.Drawing.Size(87, 21);
            this.comboBoxAnio.TabIndex = 4;
            this.comboBoxAnio.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnio_SelectedIndexChanged);
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemestre.Location = new System.Drawing.Point(340, 22);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(87, 21);
            this.comboBoxSemestre.TabIndex = 5;
            // 
            // dataGridViewTop5s
            // 
            this.dataGridViewTop5s.AllowUserToAddRows = false;
            this.dataGridViewTop5s.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTop5s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop5s.Location = new System.Drawing.Point(29, 257);
            this.dataGridViewTop5s.Name = "dataGridViewTop5s";
            this.dataGridViewTop5s.Size = new System.Drawing.Size(426, 168);
            this.dataGridViewTop5s.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese Año y Semestre:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(29, 442);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(93, 23);
            this.botonVolver.TabIndex = 8;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.top5_rec_pasajes);
            this.groupBox6.Controls.Add(this.top5_rec_cabinas);
            this.groupBox6.Controls.Add(this.top5cruc_fuera_serv);
            this.groupBox6.Location = new System.Drawing.Point(69, 80);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(358, 158);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Elija el listado que desee:";
            this.groupBox6.Enter += new System.EventHandler(this.GroupBox6_Enter);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(500, 477);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTop5s);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.comboBoxAnio);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5s)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button top5_rec_pasajes;
        private System.Windows.Forms.Button top5_rec_cabinas;
        private System.Windows.Forms.Button top5cruc_fuera_serv;
        private System.Windows.Forms.ComboBox comboBoxAnio;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.DataGridView dataGridViewTop5s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}
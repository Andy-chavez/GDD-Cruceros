namespace FrbaCrucero.AbmCrucero
{
    partial class VentanaModificarCrucero
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoModelo = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.TextoCruceroSeleccionado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonBajaTemp = new System.Windows.Forms.Button();
            this.botonBajaFinal = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textoFecha = new System.Windows.Forms.TextBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFechaReinicio = new System.Windows.Forms.Button();
            this.textoFechaReinicio = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBoxFabricante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(371, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(357, 506);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(75, 23);
            this.botonModificar.TabIndex = 1;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textoModelo);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo";
            // 
            // textoModelo
            // 
            this.textoModelo.Location = new System.Drawing.Point(93, 37);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(163, 20);
            this.textoModelo.TabIndex = 0;
            this.textoModelo.TextChanged += new System.EventHandler(this.textoModelo_TextChanged);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(23, 506);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // TextoCruceroSeleccionado
            // 
            this.TextoCruceroSeleccionado.Location = new System.Drawing.Point(145, 345);
            this.TextoCruceroSeleccionado.Name = "TextoCruceroSeleccionado";
            this.TextoCruceroSeleccionado.ReadOnly = true;
            this.TextoCruceroSeleccionado.Size = new System.Drawing.Size(287, 20);
            this.TextoCruceroSeleccionado.TabIndex = 4;
            this.TextoCruceroSeleccionado.TextChanged += new System.EventHandler(this.TextoCruceroSeleccionado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crucero seleccionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nuevo Fabricante";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // botonBajaTemp
            // 
            this.botonBajaTemp.Location = new System.Drawing.Point(225, 535);
            this.botonBajaTemp.Name = "botonBajaTemp";
            this.botonBajaTemp.Size = new System.Drawing.Size(207, 29);
            this.botonBajaTemp.TabIndex = 8;
            this.botonBajaTemp.Text = "Dar de baja temporalmente";
            this.botonBajaTemp.UseVisualStyleBackColor = true;
            this.botonBajaTemp.Click += new System.EventHandler(this.botonBajaTemp_Click);
            // 
            // botonBajaFinal
            // 
            this.botonBajaFinal.Location = new System.Drawing.Point(225, 471);
            this.botonBajaFinal.Name = "botonBajaFinal";
            this.botonBajaFinal.Size = new System.Drawing.Size(207, 29);
            this.botonBajaFinal.TabIndex = 9;
            this.botonBajaFinal.Text = "Dar de baja definitivamente";
            this.botonBajaFinal.UseVisualStyleBackColor = true;
            this.botonBajaFinal.Click += new System.EventHandler(this.botonBajaFinal_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(58, 393);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(67, 13);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "FechaActual";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // textoFecha
            // 
            this.textoFecha.Location = new System.Drawing.Point(145, 393);
            this.textoFecha.Name = "textoFecha";
            this.textoFecha.ReadOnly = true;
            this.textoFecha.Size = new System.Drawing.Size(114, 20);
            this.textoFecha.TabIndex = 12;
            this.textoFecha.TextChanged += new System.EventHandler(this.textoFecha_TextChanged);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(357, 47);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 13;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de Reinicio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonFechaReinicio
            // 
            this.buttonFechaReinicio.Location = new System.Drawing.Point(145, 434);
            this.buttonFechaReinicio.Name = "buttonFechaReinicio";
            this.buttonFechaReinicio.Size = new System.Drawing.Size(114, 23);
            this.buttonFechaReinicio.TabIndex = 15;
            this.buttonFechaReinicio.Text = "Seleccionar fecha";
            this.buttonFechaReinicio.UseVisualStyleBackColor = true;
            this.buttonFechaReinicio.Click += new System.EventHandler(this.buttonFechaReinicio_Click);
            // 
            // textoFechaReinicio
            // 
            this.textoFechaReinicio.Location = new System.Drawing.Point(266, 437);
            this.textoFechaReinicio.Name = "textoFechaReinicio";
            this.textoFechaReinicio.ReadOnly = true;
            this.textoFechaReinicio.Size = new System.Drawing.Size(127, 20);
            this.textoFechaReinicio.TabIndex = 16;
            this.textoFechaReinicio.TextChanged += new System.EventHandler(this.textoFechaReinicio_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(240, 263);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // comboBoxFabricante
            // 
            this.comboBoxFabricante.FormattingEnabled = true;
            this.comboBoxFabricante.Location = new System.Drawing.Point(145, 393);
            this.comboBoxFabricante.Name = "comboBoxFabricante";
            this.comboBoxFabricante.Size = new System.Drawing.Size(150, 21);
            this.comboBoxFabricante.TabIndex = 18;
            // 
            // VentanaModificarCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 585);
            this.Controls.Add(this.comboBoxFabricante);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textoFechaReinicio);
            this.Controls.Add(this.buttonFechaReinicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.textoFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.botonBajaFinal);
            this.Controls.Add(this.botonBajaTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextoCruceroSeleccionado);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VentanaModificarCrucero";
            this.Text = "Modificar Crucero";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaModificarCrucero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoModelo;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TextBox TextoCruceroSeleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonBajaTemp;
        private System.Windows.Forms.Button botonBajaFinal;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textoFecha;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFechaReinicio;
        private System.Windows.Forms.TextBox textoFechaReinicio;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBoxFabricante;
    }
}
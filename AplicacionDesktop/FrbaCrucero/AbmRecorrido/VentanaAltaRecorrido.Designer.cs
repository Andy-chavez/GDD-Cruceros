namespace FrbaCrucero.AbmRecorrido
{
    partial class VentanaAltaRecorrido
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonTramo = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.dataSetTramo = new FrbaCrucero.DataSetTramo();
            this.tramosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tramosDisponiblesTableAdapter = new FrbaCrucero.DataSetTramoTableAdapters.TramosDisponiblesTableAdapter();
            this.idtramoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrecorridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idorigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciobaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recorrido = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.dataSet5 = new FrbaCrucero.DataSet5();
            this.tramoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tramoTableAdapter = new FrbaCrucero.DataSet5TableAdapters.TramoTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramosDisponiblesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtramoDataGridViewTextBoxColumn,
            this.idrecorridoDataGridViewTextBoxColumn,
            this.idorigenDataGridViewTextBoxColumn,
            this.iddestinoDataGridViewTextBoxColumn,
            this.ordenDataGridViewTextBoxColumn,
            this.preciobaseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tramoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tramos disponibles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Tramo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // botonTramo
            // 
            this.botonTramo.Location = new System.Drawing.Point(12, 137);
            this.botonTramo.Name = "botonTramo";
            this.botonTramo.Size = new System.Drawing.Size(196, 35);
            this.botonTramo.TabIndex = 3;
            this.botonTramo.Text = "Agregar nuevo tramo";
            this.botonTramo.UseVisualStyleBackColor = true;
            this.botonTramo.Click += new System.EventHandler(this.botonTramo_Click);
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(693, 475);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(118, 23);
            this.botonCrear.TabIndex = 4;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            // 
            // dataSetTramo
            // 
            this.dataSetTramo.DataSetName = "DataSetTramo";
            this.dataSetTramo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tramosDisponiblesBindingSource
            // 
            this.tramosDisponiblesBindingSource.DataMember = "TramosDisponibles";
            this.tramosDisponiblesBindingSource.DataSource = this.dataSetTramo;
            // 
            // tramosDisponiblesTableAdapter
            // 
            this.tramosDisponiblesTableAdapter.ClearBeforeFill = true;
            // 
            // idtramoDataGridViewTextBoxColumn
            // 
            this.idtramoDataGridViewTextBoxColumn.DataPropertyName = "id_tramo";
            this.idtramoDataGridViewTextBoxColumn.HeaderText = "id_tramo";
            this.idtramoDataGridViewTextBoxColumn.Name = "idtramoDataGridViewTextBoxColumn";
            this.idtramoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idrecorridoDataGridViewTextBoxColumn
            // 
            this.idrecorridoDataGridViewTextBoxColumn.DataPropertyName = "id_recorrido";
            this.idrecorridoDataGridViewTextBoxColumn.HeaderText = "id_recorrido";
            this.idrecorridoDataGridViewTextBoxColumn.Name = "idrecorridoDataGridViewTextBoxColumn";
            // 
            // idorigenDataGridViewTextBoxColumn
            // 
            this.idorigenDataGridViewTextBoxColumn.DataPropertyName = "id_origen";
            this.idorigenDataGridViewTextBoxColumn.HeaderText = "id_origen";
            this.idorigenDataGridViewTextBoxColumn.Name = "idorigenDataGridViewTextBoxColumn";
            // 
            // iddestinoDataGridViewTextBoxColumn
            // 
            this.iddestinoDataGridViewTextBoxColumn.DataPropertyName = "id_destino";
            this.iddestinoDataGridViewTextBoxColumn.HeaderText = "id_destino";
            this.iddestinoDataGridViewTextBoxColumn.Name = "iddestinoDataGridViewTextBoxColumn";
            // 
            // ordenDataGridViewTextBoxColumn
            // 
            this.ordenDataGridViewTextBoxColumn.DataPropertyName = "orden";
            this.ordenDataGridViewTextBoxColumn.HeaderText = "orden";
            this.ordenDataGridViewTextBoxColumn.Name = "ordenDataGridViewTextBoxColumn";
            // 
            // preciobaseDataGridViewTextBoxColumn
            // 
            this.preciobaseDataGridViewTextBoxColumn.DataPropertyName = "precio_base";
            this.preciobaseDataGridViewTextBoxColumn.HeaderText = "precio_base";
            this.preciobaseDataGridViewTextBoxColumn.Name = "preciobaseDataGridViewTextBoxColumn";
            // 
            // Recorrido
            // 
            this.Recorrido.FormattingEnabled = true;
            this.Recorrido.Location = new System.Drawing.Point(0, 22);
            this.Recorrido.Name = "Recorrido";
            this.Recorrido.Size = new System.Drawing.Size(334, 238);
            this.Recorrido.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Recorrido);
            this.groupBox3.Location = new System.Drawing.Point(471, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 266);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tramos Agregados";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(274, 137);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(191, 35);
            this.botonEliminar.TabIndex = 7;
            this.botonEliminar.Text = "Eliminar tramo";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tramoBindingSource
            // 
            this.tramoBindingSource.DataMember = "Tramo";
            this.tramoBindingSource.DataSource = this.dataSet5;
            // 
            // tramoTableAdapter
            // 
            this.tramoTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click para sacar el tramo del recorrido";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(13, 474);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(110, 23);
            this.botonVolver.TabIndex = 9;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // VentanaAltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 523);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.botonTramo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaAltaRecorrido";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaAltaRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramosDisponiblesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonTramo;
        private System.Windows.Forms.Button botonCrear;
        private DataSetTramo dataSetTramo;
        private System.Windows.Forms.BindingSource tramosDisponiblesBindingSource;
        private DataSetTramoTableAdapters.TramosDisponiblesTableAdapter tramosDisponiblesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtramoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrecorridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciobaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox Recorrido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button botonEliminar;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource tramoBindingSource;
        private DataSet5TableAdapters.TramoTableAdapter tramoTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonVolver;
    }
}
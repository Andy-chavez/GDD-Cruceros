namespace FrbaCrucero.AbmCrucero
{
    partial class VentanaListadoCrucero
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
            this.l1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filtro1 = new System.Windows.Forms.TextBox();
            this.filtro2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filtro3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rsFiltro2 = new System.Windows.Forms.TextBox();
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.grupoFiltro = new System.Windows.Forms.GroupBox();
            this.planillaDeResultados = new System.Windows.Forms.DataGridView();
            this.idcruceroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crucerosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FrbaCrucero.DataSet1();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.crucerosDisponiblesTableAdapter = new FrbaCrucero.DataSet1TableAdapters.CrucerosDisponiblesTableAdapter();
            this.grupoFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planillaDeResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crucerosDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(6, 35);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(38, 13);
            this.l1.TabIndex = 0;
            this.l1.Text = "Filtro 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filtro1
            // 
            this.filtro1.Location = new System.Drawing.Point(46, 77);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(100, 20);
            this.filtro1.TabIndex = 2;
            this.filtro1.TextChanged += new System.EventHandler(this.filtro1_TextChanged);
            // 
            // filtro2
            // 
            this.filtro2.Location = new System.Drawing.Point(46, 32);
            this.filtro2.Name = "filtro2";
            this.filtro2.Size = new System.Drawing.Size(100, 20);
            this.filtro2.TabIndex = 3;
            this.filtro2.TextChanged += new System.EventHandler(this.filtro2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtro 3";
            // 
            // filtro3
            // 
            this.filtro3.FormattingEnabled = true;
            this.filtro3.Location = new System.Drawing.Point(229, 31);
            this.filtro3.Name = "filtro3";
            this.filtro3.Size = new System.Drawing.Size(181, 21);
            this.filtro3.TabIndex = 5;
            this.filtro3.SelectedIndexChanged += new System.EventHandler(this.filtro3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtro 2";
            // 
            // rsFiltro2
            // 
            this.rsFiltro2.Location = new System.Drawing.Point(229, 76);
            this.rsFiltro2.Name = "rsFiltro2";
            this.rsFiltro2.ReadOnly = true;
            this.rsFiltro2.Size = new System.Drawing.Size(100, 20);
            this.rsFiltro2.TabIndex = 7;
            this.rsFiltro2.TextChanged += new System.EventHandler(this.rsFiltro2_TextChanged);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(335, 74);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.botonSeleccionar.TabIndex = 8;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(369, 144);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 9;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 144);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 10;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // grupoFiltro
            // 
            this.grupoFiltro.Controls.Add(this.filtro2);
            this.grupoFiltro.Controls.Add(this.filtro1);
            this.grupoFiltro.Controls.Add(this.l1);
            this.grupoFiltro.Controls.Add(this.label1);
            this.grupoFiltro.Controls.Add(this.rsFiltro2);
            this.grupoFiltro.Controls.Add(this.label3);
            this.grupoFiltro.Controls.Add(this.filtro3);
            this.grupoFiltro.Controls.Add(this.botonSeleccionar);
            this.grupoFiltro.Controls.Add(this.label2);
            this.grupoFiltro.Location = new System.Drawing.Point(12, 14);
            this.grupoFiltro.Name = "grupoFiltro";
            this.grupoFiltro.Size = new System.Drawing.Size(432, 110);
            this.grupoFiltro.TabIndex = 13;
            this.grupoFiltro.TabStop = false;
            this.grupoFiltro.Text = "Filtros de busqueda";
            this.grupoFiltro.Enter += new System.EventHandler(this.grupoFiltro_Enter);
            // 
            // planillaDeResultados
            // 
            this.planillaDeResultados.AllowUserToAddRows = false;
            this.planillaDeResultados.AllowUserToDeleteRows = false;
            this.planillaDeResultados.AllowUserToResizeColumns = false;
            this.planillaDeResultados.AllowUserToResizeRows = false;
            this.planillaDeResultados.AutoGenerateColumns = false;
            this.planillaDeResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planillaDeResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcruceroDataGridViewTextBoxColumn,
            this.idfabricanteDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn});
            this.planillaDeResultados.DataSource = this.crucerosDisponiblesBindingSource;
            this.planillaDeResultados.Location = new System.Drawing.Point(12, 173);
            this.planillaDeResultados.Name = "planillaDeResultados";
            this.planillaDeResultados.ReadOnly = true;
            this.planillaDeResultados.Size = new System.Drawing.Size(432, 150);
            this.planillaDeResultados.TabIndex = 14;
            this.planillaDeResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planillaDeResultados_CellContentClick);
            // 
            // idcruceroDataGridViewTextBoxColumn
            // 
            this.idcruceroDataGridViewTextBoxColumn.DataPropertyName = "id_crucero";
            this.idcruceroDataGridViewTextBoxColumn.HeaderText = "id_crucero";
            this.idcruceroDataGridViewTextBoxColumn.Name = "idcruceroDataGridViewTextBoxColumn";
            this.idcruceroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idfabricanteDataGridViewTextBoxColumn
            // 
            this.idfabricanteDataGridViewTextBoxColumn.DataPropertyName = "id_fabricante";
            this.idfabricanteDataGridViewTextBoxColumn.HeaderText = "id_fabricante";
            this.idfabricanteDataGridViewTextBoxColumn.Name = "idfabricanteDataGridViewTextBoxColumn";
            this.idfabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crucerosDisponiblesBindingSource
            // 
            this.crucerosDisponiblesBindingSource.DataMember = "CrucerosDisponibles";
            this.crucerosDisponiblesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(230, 122);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // crucerosDisponiblesTableAdapter
            // 
            this.crucerosDisponiblesTableAdapter.ClearBeforeFill = true;
            // 
            // VentanaListadoCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 334);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.planillaDeResultados);
            this.Controls.Add(this.grupoFiltro);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonBuscar);
            this.Name = "VentanaListadoCrucero";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaListado_Load);
            this.grupoFiltro.ResumeLayout(false);
            this.grupoFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planillaDeResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crucerosDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtro1;
        private System.Windows.Forms.TextBox filtro2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filtro3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rsFiltro2;
        private System.Windows.Forms.Button botonSeleccionar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.GroupBox grupoFiltro;
        private System.Windows.Forms.DataGridView planillaDeResultados;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource crucerosDisponiblesBindingSource;
        private DataSet1TableAdapters.CrucerosDisponiblesTableAdapter crucerosDisponiblesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcruceroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
    }
}
namespace FrbaCrucero.AbmRol
{
    partial class VentanaDeAltaRol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.funcionalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFunc = new FrbaCrucero.DataSetFunc();
            this.funcionalidadTableAdapter = new FrbaCrucero.DataSetFuncTableAdapters.FuncionalidadTableAdapter();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.dataSet2 = new FrbaCrucero.DataSet2();
            this.funcionalidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionalidadTableAdapter1 = new FrbaCrucero.DataSet2TableAdapters.FuncionalidadTableAdapter();
            this.listaFunc = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFunc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoNombre);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(111, 34);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(225, 20);
            this.textoNombre.TabIndex = 1;
            this.textoNombre.TextChanged += new System.EventHandler(this.textoNombre_TextChanged);
            // 
            // funcionalidadBindingSource
            // 
            this.funcionalidadBindingSource.DataMember = "Funcionalidad";
            this.funcionalidadBindingSource.DataSource = this.dataSetFunc;
            // 
            // dataSetFunc
            // 
            this.dataSetFunc.DataSetName = "DataSetFunc";
            this.dataSetFunc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionalidadTableAdapter
            // 
            this.funcionalidadTableAdapter.ClearBeforeFill = true;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(24, 198);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(93, 23);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(339, 198);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(93, 23);
            this.botonCrear.TabIndex = 3;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaFunc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionalidades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionalidad";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(463, 24);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 5;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionalidadBindingSource1
            // 
            this.funcionalidadBindingSource1.DataMember = "Funcionalidad";
            this.funcionalidadBindingSource1.DataSource = this.dataSet2;
            // 
            // funcionalidadTableAdapter1
            // 
            this.funcionalidadTableAdapter1.ClearBeforeFill = true;
            // 
            // listaFunc
            // 
            this.listaFunc.FormattingEnabled = true;
            this.listaFunc.Location = new System.Drawing.Point(111, 26);
            this.listaFunc.Name = "listaFunc";
            this.listaFunc.Size = new System.Drawing.Size(225, 21);
            this.listaFunc.TabIndex = 1;
            this.listaFunc.SelectedIndexChanged += new System.EventHandler(this.listaFunc_SelectedIndexChanged);
            // 
            // VentanaDeAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 246);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaDeAltaRol";
            this.Text = "Ventana De Alta Rol";
            this.Load += new System.EventHandler(this.VentanaDeAltaRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFunc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNombre;
        private DataSetFunc dataSetFunc;
        private System.Windows.Forms.BindingSource funcionalidadBindingSource;
        private DataSetFuncTableAdapters.FuncionalidadTableAdapter funcionalidadTableAdapter;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonLimpiar;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource funcionalidadBindingSource1;
        private DataSet2TableAdapters.FuncionalidadTableAdapter funcionalidadTableAdapter1;
        private System.Windows.Forms.ComboBox listaFunc;
    }
}
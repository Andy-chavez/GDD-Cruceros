namespace FrbaCrucero.AbmRol
{
    partial class VentanaCrearRol
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
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridFuncionalidades = new System.Windows.Forms.DataGridView();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.funcionalidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridSeleccionadas = new System.Windows.Forms.DataGridView();
            this.FuncionalidadesAgregadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeleccionadas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoNombre);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese nombre del Rol a crear";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(177, 19);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(225, 20);
            this.textoNombre.TabIndex = 1;
            this.textoNombre.TextChanged += new System.EventHandler(this.textoNombre_TextChanged);
            // 
            // funcionalidadBindingSource
            // 
            this.funcionalidadBindingSource.DataMember = "Funcionalidad";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(12, 378);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(93, 23);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(396, 378);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(93, 23);
            this.botonCrear.TabIndex = 3;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridFuncionalidades);
            this.groupBox2.Location = new System.Drawing.Point(24, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 260);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione las funcionalidades a agregar";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // dataGridFuncionalidades
            // 
            this.dataGridFuncionalidades.AllowUserToAddRows = false;
            this.dataGridFuncionalidades.AllowUserToDeleteRows = false;
            this.dataGridFuncionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionalidades.Location = new System.Drawing.Point(6, 20);
            this.dataGridFuncionalidades.Name = "dataGridFuncionalidades";
            this.dataGridFuncionalidades.ReadOnly = true;
            this.dataGridFuncionalidades.Size = new System.Drawing.Size(211, 234);
            this.dataGridFuncionalidades.TabIndex = 0;
            this.dataGridFuncionalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 349);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(93, 23);
            this.botonLimpiar.TabIndex = 5;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridSeleccionadas);
            this.groupBox3.Location = new System.Drawing.Point(262, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 260);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FuncionalidadesSeleccionadas";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // dataGridSeleccionadas
            // 
            this.dataGridSeleccionadas.AllowDrop = true;
            this.dataGridSeleccionadas.AllowUserToAddRows = false;
            this.dataGridSeleccionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionalidadesAgregadas});
            this.dataGridSeleccionadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridSeleccionadas.Location = new System.Drawing.Point(6, 20);
            this.dataGridSeleccionadas.Name = "dataGridSeleccionadas";
            this.dataGridSeleccionadas.Size = new System.Drawing.Size(211, 234);
            this.dataGridSeleccionadas.TabIndex = 8;
            this.dataGridSeleccionadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSeleccionadas_CellContentClick);
            // 
            // FuncionalidadesAgregadas
            // 
            this.FuncionalidadesAgregadas.HeaderText = "FuncionalidadesAgregadas";
            this.FuncionalidadesAgregadas.Name = "FuncionalidadesAgregadas";
            // 
            // Quitar
            // 
            this.Quitar.Location = new System.Drawing.Point(344, 349);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(145, 23);
            this.Quitar.TabIndex = 9;
            this.Quitar.Text = "Quitar ultima funcionalidad";
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // VentanaCrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(532, 413);
            this.Controls.Add(this.Quitar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaCrearRol";
            this.Text = "Crear Rol";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaDeAltaRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadBindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeleccionadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNombre;
       
        private System.Windows.Forms.BindingSource funcionalidadBindingSource;
       
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonLimpiar;
      
        private System.Windows.Forms.BindingSource funcionalidadBindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridFuncionalidades;
        private System.Windows.Forms.DataGridView dataGridSeleccionadas;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionalidadesAgregadas;
    }
}
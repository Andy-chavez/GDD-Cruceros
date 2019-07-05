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
            this.dataGridPuertos = new System.Windows.Forms.DataGridView();
            this.tramoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroOrigen = new System.Windows.Forms.TextBox();
            this.botonTramo = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.tramosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridTramos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonSacarTramo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramosDisponiblesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPuertos
            // 
            this.dataGridPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPuertos.Location = new System.Drawing.Point(6, 15);
            this.dataGridPuertos.Name = "dataGridPuertos";
            this.dataGridPuertos.ReadOnly = true;
            this.dataGridPuertos.Size = new System.Drawing.Size(303, 245);
            this.dataGridPuertos.TabIndex = 0;
            this.dataGridPuertos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDeTramos_CellClick);
            this.dataGridPuertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDeTramos_CellContentClick);
            // 
            // tramoBindingSource
            // 
            this.tramoBindingSource.DataMember = "Tramo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridPuertos);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puertos disponibles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonLimpiar);
            this.groupBox2.Controls.Add(this.botonBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.filtroOrigen);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Puerto";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(357, 67);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 5;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(357, 27);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // filtroOrigen
            // 
            this.filtroOrigen.Location = new System.Drawing.Point(106, 29);
            this.filtroOrigen.Name = "filtroOrigen";
            this.filtroOrigen.Size = new System.Drawing.Size(222, 20);
            this.filtroOrigen.TabIndex = 0;
            this.filtroOrigen.TextChanged += new System.EventHandler(this.filtroOrigen_TextChanged);
            // 
            // botonTramo
            // 
            this.botonTramo.Location = new System.Drawing.Point(74, 432);
            this.botonTramo.Name = "botonTramo";
            this.botonTramo.Size = new System.Drawing.Size(177, 23);
            this.botonTramo.TabIndex = 3;
            this.botonTramo.Text = "Agregar al Recorrido";
            this.botonTramo.UseVisualStyleBackColor = true;
            this.botonTramo.Click += new System.EventHandler(this.botonTramo_Click);
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(573, 475);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(118, 23);
            this.botonCrear.TabIndex = 4;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridTramos);
            this.groupBox3.Location = new System.Drawing.Point(351, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 266);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Puertos Agregados";
            // 
            // dataGridTramos
            // 
            this.dataGridTramos.AllowUserToAddRows = false;
            this.dataGridTramos.AllowUserToDeleteRows = false;
            this.dataGridTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramos.Location = new System.Drawing.Point(9, 19);
            this.dataGridTramos.Name = "dataGridTramos";
            this.dataGridTramos.Size = new System.Drawing.Size(335, 241);
            this.dataGridTramos.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar los Puertos del Recorrido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(13, 474);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(110, 23);
            this.botonVolver.TabIndex = 9;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonSacarTramo
            // 
            this.botonSacarTramo.Location = new System.Drawing.Point(444, 432);
            this.botonSacarTramo.Name = "botonSacarTramo";
            this.botonSacarTramo.Size = new System.Drawing.Size(156, 23);
            this.botonSacarTramo.TabIndex = 10;
            this.botonSacarTramo.Text = "Borrar último Puerto";
            this.botonSacarTramo.UseVisualStyleBackColor = true;
            this.botonSacarTramo.Click += new System.EventHandler(this.botonSacarTramo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vaya cargando";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "los precios correspondientes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(519, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 84);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nota:";
            // 
            // VentanaAltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 523);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.botonSacarTramo);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.botonTramo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaAltaRecorrido";
            this.Text = "Recorridos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaAltaRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramosDisponiblesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPuertos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroOrigen;
        private System.Windows.Forms.Button botonTramo;
        private System.Windows.Forms.Button botonCrear;

        private System.Windows.Forms.BindingSource tramosDisponiblesBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn idtramoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrecorridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciobaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.BindingSource tramoBindingSource;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonSacarTramo;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.DataGridView dataGridTramos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}
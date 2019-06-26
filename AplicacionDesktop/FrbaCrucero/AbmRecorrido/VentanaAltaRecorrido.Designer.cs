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
            this.listaDeTramos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroDestino = new System.Windows.Forms.TextBox();
            this.filtroOrigen = new System.Windows.Forms.TextBox();
            this.botonTramo = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.Recorrido = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonSacarTramo = new System.Windows.Forms.Button();
            this.tramoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tramosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTramos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramosDisponiblesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listaDeTramos
            // 
            this.listaDeTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDeTramos.Location = new System.Drawing.Point(0, 19);
            this.listaDeTramos.Name = "listaDeTramos";
            this.listaDeTramos.ReadOnly = true;
            this.listaDeTramos.Size = new System.Drawing.Size(447, 247);
            this.listaDeTramos.TabIndex = 0;
            this.listaDeTramos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDeTramos_CellClick);
            this.listaDeTramos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDeTramos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaDeTramos);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tramos disponibles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonLimpiar);
            this.groupBox2.Controls.Add(this.botonBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.filtroDestino);
            this.groupBox2.Controls.Add(this.filtroOrigen);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Tramo";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
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
            // filtroDestino
            // 
            this.filtroDestino.Location = new System.Drawing.Point(106, 67);
            this.filtroDestino.Name = "filtroDestino";
            this.filtroDestino.Size = new System.Drawing.Size(222, 20);
            this.filtroDestino.TabIndex = 1;
            this.filtroDestino.TextChanged += new System.EventHandler(this.filtroDestino_TextChanged);
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
            this.botonTramo.Location = new System.Drawing.Point(13, 125);
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
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // Recorrido
            // 
            this.Recorrido.FormattingEnabled = true;
            this.Recorrido.Location = new System.Drawing.Point(0, 22);
            this.Recorrido.Name = "Recorrido";
            this.Recorrido.Size = new System.Drawing.Size(334, 238);
            this.Recorrido.TabIndex = 5;
            this.Recorrido.SelectedIndexChanged += new System.EventHandler(this.Recorrido_SelectedIndexChanged);
            this.Recorrido.DoubleClick += new System.EventHandler(this.Recorrido_DoubleClick);
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
            this.botonEliminar.Location = new System.Drawing.Point(274, 125);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(191, 35);
            this.botonEliminar.TabIndex = 7;
            this.botonEliminar.Text = "Eliminar tramo";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar tramo para agregar";
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
            this.botonSacarTramo.Location = new System.Drawing.Point(572, 165);
            this.botonSacarTramo.Name = "botonSacarTramo";
            this.botonSacarTramo.Size = new System.Drawing.Size(156, 23);
            this.botonSacarTramo.TabIndex = 10;
            this.botonSacarTramo.Text = "Sacar ultimo Tramo";
            this.botonSacarTramo.UseVisualStyleBackColor = true;
            this.botonSacarTramo.Click += new System.EventHandler(this.botonSacarTramo_Click);
            // 
            // tramoBindingSource
            // 
            this.tramoBindingSource.DataMember = "Tramo";
            // 
            // VentanaAltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 523);
            this.Controls.Add(this.botonSacarTramo);
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
            ((System.ComponentModel.ISupportInitialize)(this.listaDeTramos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tramoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramosDisponiblesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaDeTramos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroDestino;
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
        private System.Windows.Forms.ListBox Recorrido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button botonEliminar;

        private System.Windows.Forms.BindingSource tramoBindingSource;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonSacarTramo;
        private System.Windows.Forms.Button botonLimpiar;
    }
}
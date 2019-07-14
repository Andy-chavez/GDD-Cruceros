namespace FrbaCrucero.AbmRecorrido
{
    partial class TrueModificarRecorrido
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
            this.label1 = new System.Windows.Forms.Label();
            this.textoRecorridoSeleccionado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filtroOrigen = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridTramosRecOrig = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridPuertos = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridTramos = new System.Windows.Forms.DataGridView();
            this.buttonAddTramo = new System.Windows.Forms.Button();
            this.buttonBorrarLastTramo = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxFiltroDestino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFiltroOrigen = new System.Windows.Forms.TextBox();
            this.buttonFiltrarRecs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLimpiarRecs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorridosActuales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramosRecOrig)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuertos)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRecorridosActuales
            // 
            this.dataGridRecorridosActuales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRecorridosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecorridosActuales.Location = new System.Drawing.Point(7, 18);
            this.dataGridRecorridosActuales.Name = "dataGridRecorridosActuales";
            this.dataGridRecorridosActuales.ReadOnly = true;
            this.dataGridRecorridosActuales.Size = new System.Drawing.Size(331, 207);
            this.dataGridRecorridosActuales.TabIndex = 0;
            this.dataGridRecorridosActuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecorridosActuales_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridRecorridosActuales);
            this.groupBox1.Location = new System.Drawing.Point(17, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos Actuales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recorrido seleccionado";
            // 
            // textoRecorridoSeleccionado
            // 
            this.textoRecorridoSeleccionado.Location = new System.Drawing.Point(160, 391);
            this.textoRecorridoSeleccionado.Name = "textoRecorridoSeleccionado";
            this.textoRecorridoSeleccionado.ReadOnly = true;
            this.textoRecorridoSeleccionado.Size = new System.Drawing.Size(173, 20);
            this.textoRecorridoSeleccionado.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filtroOrigen);
            this.groupBox2.Controls.Add(this.buttonBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.botonLimpiar);
            this.groupBox2.Location = new System.Drawing.Point(12, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 108);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Puerto";
            // 
            // filtroOrigen
            // 
            this.filtroOrigen.Location = new System.Drawing.Point(111, 30);
            this.filtroOrigen.Name = "filtroOrigen";
            this.filtroOrigen.Size = new System.Drawing.Size(174, 20);
            this.filtroOrigen.TabIndex = 10;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(311, 28);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(311, 71);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridTramosRecOrig);
            this.groupBox3.Location = new System.Drawing.Point(371, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 231);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Puertos del Recorrido Original";
            // 
            // dataGridTramosRecOrig
            // 
            this.dataGridTramosRecOrig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTramosRecOrig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramosRecOrig.Location = new System.Drawing.Point(6, 19);
            this.dataGridTramosRecOrig.Name = "dataGridTramosRecOrig";
            this.dataGridTramosRecOrig.Size = new System.Drawing.Size(330, 206);
            this.dataGridTramosRecOrig.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridPuertos);
            this.groupBox4.Location = new System.Drawing.Point(12, 560);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 238);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Puertos disponibles";
            // 
            // dataGridPuertos
            // 
            this.dataGridPuertos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPuertos.Location = new System.Drawing.Point(7, 20);
            this.dataGridPuertos.Name = "dataGridPuertos";
            this.dataGridPuertos.Size = new System.Drawing.Size(308, 212);
            this.dataGridPuertos.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridTramos);
            this.groupBox5.Location = new System.Drawing.Point(339, 560);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(367, 238);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Puertos agregados";
            // 
            // dataGridTramos
            // 
            this.dataGridTramos.AllowUserToAddRows = false;
            this.dataGridTramos.AllowUserToDeleteRows = false;
            this.dataGridTramos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramos.Location = new System.Drawing.Point(7, 20);
            this.dataGridTramos.Name = "dataGridTramos";
            this.dataGridTramos.Size = new System.Drawing.Size(354, 212);
            this.dataGridTramos.TabIndex = 0;
            this.dataGridTramos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTramos_CellContentClick);
            // 
            // buttonAddTramo
            // 
            this.buttonAddTramo.Location = new System.Drawing.Point(110, 804);
            this.buttonAddTramo.Name = "buttonAddTramo";
            this.buttonAddTramo.Size = new System.Drawing.Size(116, 23);
            this.buttonAddTramo.TabIndex = 13;
            this.buttonAddTramo.Text = "Agregar al recorrido";
            this.buttonAddTramo.UseVisualStyleBackColor = true;
            this.buttonAddTramo.Click += new System.EventHandler(this.buttonAddTramo_Click);
            // 
            // buttonBorrarLastTramo
            // 
            this.buttonBorrarLastTramo.Location = new System.Drawing.Point(466, 807);
            this.buttonBorrarLastTramo.Name = "buttonBorrarLastTramo";
            this.buttonBorrarLastTramo.Size = new System.Drawing.Size(116, 23);
            this.buttonBorrarLastTramo.TabIndex = 14;
            this.buttonBorrarLastTramo.Text = "Borrar último Puerto";
            this.buttonBorrarLastTramo.UseVisualStyleBackColor = true;
            this.buttonBorrarLastTramo.Click += new System.EventHandler(this.buttonBorrarLastTramo_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(618, 842);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(82, 23);
            this.buttonActualizar.TabIndex = 15;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(17, 842);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(72, 23);
            this.botonVolver.TabIndex = 16;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Modifique el recorrido seleccionado:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(528, 470);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(172, 84);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nota:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "los precios correspondientes";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxFiltroDestino);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.textBoxFiltroOrigen);
            this.groupBox7.Controls.Add(this.buttonFiltrarRecs);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.buttonLimpiarRecs);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(407, 108);
            this.groupBox7.TabIndex = 11;
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
            // TrueModificarRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(741, 741);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonBorrarLastTramo);
            this.Controls.Add(this.buttonAddTramo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoRecorridoSeleccionado);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrueModificarRecorrido";
            this.Text = "TrueModificarRecorrido";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TrueModificarRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorridosActuales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramosRecOrig)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuertos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramos)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRecorridosActuales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoRecorridoSeleccionado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridTramosRecOrig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAddTramo;
        private System.Windows.Forms.Button buttonBorrarLastTramo;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dataGridPuertos;
        private System.Windows.Forms.TextBox filtroOrigen;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridTramos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxFiltroOrigen;
        private System.Windows.Forms.Button buttonFiltrarRecs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLimpiarRecs;
        private System.Windows.Forms.TextBox textBoxFiltroDestino;
        private System.Windows.Forms.Label label7;
    }
}
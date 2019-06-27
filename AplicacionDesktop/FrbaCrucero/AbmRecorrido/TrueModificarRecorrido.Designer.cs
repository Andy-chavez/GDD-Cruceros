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
            this.filtroDestino = new System.Windows.Forms.TextBox();
            this.filtroOrigen = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridTramosRecOrig = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridTramosDisp = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxNuevosTramos = new System.Windows.Forms.ListBox();
            this.buttonAddTramo = new System.Windows.Forms.Button();
            this.buttonBorrarLastTramo = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorridosActuales)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramosRecOrig)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramosDisp)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRecorridosActuales
            // 
            this.dataGridRecorridosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecorridosActuales.Location = new System.Drawing.Point(64, 30);
            this.dataGridRecorridosActuales.Name = "dataGridRecorridosActuales";
            this.dataGridRecorridosActuales.ReadOnly = true;
            this.dataGridRecorridosActuales.Size = new System.Drawing.Size(589, 142);
            this.dataGridRecorridosActuales.TabIndex = 0;
            this.dataGridRecorridosActuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecorridosActuales_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(58, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos Actuales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recorrido seleccionado";
            // 
            // textoRecorridoSeleccionado
            // 
            this.textoRecorridoSeleccionado.Location = new System.Drawing.Point(203, 196);
            this.textoRecorridoSeleccionado.Name = "textoRecorridoSeleccionado";
            this.textoRecorridoSeleccionado.ReadOnly = true;
            this.textoRecorridoSeleccionado.Size = new System.Drawing.Size(263, 20);
            this.textoRecorridoSeleccionado.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filtroDestino);
            this.groupBox2.Controls.Add(this.filtroOrigen);
            this.groupBox2.Controls.Add(this.buttonBuscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.botonLimpiar);
            this.groupBox2.Location = new System.Drawing.Point(57, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 121);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Tramo";
            // 
            // filtroDestino
            // 
            this.filtroDestino.Location = new System.Drawing.Point(146, 73);
            this.filtroDestino.Name = "filtroDestino";
            this.filtroDestino.Size = new System.Drawing.Size(174, 20);
            this.filtroDestino.TabIndex = 11;
            // 
            // filtroOrigen
            // 
            this.filtroOrigen.Location = new System.Drawing.Point(146, 31);
            this.filtroOrigen.Name = "filtroOrigen";
            this.filtroOrigen.Size = new System.Drawing.Size(174, 20);
            this.filtroOrigen.TabIndex = 10;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(483, 29);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nuevo destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nuevo origen";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(483, 79);
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
            this.groupBox3.Location = new System.Drawing.Point(58, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 162);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tramos del Recorrido Original";
            // 
            // dataGridTramosRecOrig
            // 
            this.dataGridTramosRecOrig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramosRecOrig.Location = new System.Drawing.Point(7, 20);
            this.dataGridTramosRecOrig.Name = "dataGridTramosRecOrig";
            this.dataGridTramosRecOrig.Size = new System.Drawing.Size(588, 136);
            this.dataGridTramosRecOrig.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridTramosDisp);
            this.groupBox4.Location = new System.Drawing.Point(12, 571);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 193);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tramos disponibles";
            // 
            // dataGridTramosDisp
            // 
            this.dataGridTramosDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTramosDisp.Location = new System.Drawing.Point(7, 20);
            this.dataGridTramosDisp.Name = "dataGridTramosDisp";
            this.dataGridTramosDisp.Size = new System.Drawing.Size(352, 159);
            this.dataGridTramosDisp.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccionar tramo para agregar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxNuevosTramos);
            this.groupBox5.Location = new System.Drawing.Point(383, 571);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 193);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nuevos tramos";
            // 
            // listBoxNuevosTramos
            // 
            this.listBoxNuevosTramos.FormattingEnabled = true;
            this.listBoxNuevosTramos.Location = new System.Drawing.Point(6, 19);
            this.listBoxNuevosTramos.Name = "listBoxNuevosTramos";
            this.listBoxNuevosTramos.Size = new System.Drawing.Size(311, 160);
            this.listBoxNuevosTramos.TabIndex = 6;
            // 
            // buttonAddTramo
            // 
            this.buttonAddTramo.Location = new System.Drawing.Point(150, 779);
            this.buttonAddTramo.Name = "buttonAddTramo";
            this.buttonAddTramo.Size = new System.Drawing.Size(116, 23);
            this.buttonAddTramo.TabIndex = 13;
            this.buttonAddTramo.Text = "Agregar al recorrido";
            this.buttonAddTramo.UseVisualStyleBackColor = true;
            this.buttonAddTramo.Click += new System.EventHandler(this.buttonAddTramo_Click);
            // 
            // buttonBorrarLastTramo
            // 
            this.buttonBorrarLastTramo.Location = new System.Drawing.Point(463, 778);
            this.buttonBorrarLastTramo.Name = "buttonBorrarLastTramo";
            this.buttonBorrarLastTramo.Size = new System.Drawing.Size(116, 23);
            this.buttonBorrarLastTramo.TabIndex = 14;
            this.buttonBorrarLastTramo.Text = "Borrar último Tramo";
            this.buttonBorrarLastTramo.UseVisualStyleBackColor = true;
            this.buttonBorrarLastTramo.Click += new System.EventHandler(this.buttonBorrarLastTramo_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(544, 831);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(116, 23);
            this.buttonActualizar.TabIndex = 15;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(33, 831);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(110, 23);
            this.botonVolver.TabIndex = 16;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Modificación:";
            // 
            // TrueModificarRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 866);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonBorrarLastTramo);
            this.Controls.Add(this.buttonAddTramo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoRecorridoSeleccionado);
            this.Controls.Add(this.dataGridRecorridosActuales);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrueModificarRecorrido";
            this.Text = "TrueModificarRecorrido";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TrueModificarRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorridosActuales)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramosRecOrig)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTramosDisp)).EndInit();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridTramosRecOrig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAddTramo;
        private System.Windows.Forms.Button buttonBorrarLastTramo;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.ListBox listBoxNuevosTramos;
        private System.Windows.Forms.DataGridView dataGridTramosDisp;
        private System.Windows.Forms.TextBox filtroDestino;
        private System.Windows.Forms.TextBox filtroOrigen;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label5;
    }
}
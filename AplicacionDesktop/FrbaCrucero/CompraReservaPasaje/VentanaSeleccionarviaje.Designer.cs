namespace FrbaCrucero.CompraReservaPasaje
{
    partial class VentanaSeleccionarviaje
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
            this.viajesDisponibles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textoFechaInicio = new System.Windows.Forms.TextBox();
            this.botonReserva = new System.Windows.Forms.Button();
            this.botonCompra = new System.Windows.Forms.Button();
            this.listaOrigen = new System.Windows.Forms.ComboBox();
            this.listaDestino = new System.Windows.Forms.ComboBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viajesDisponibles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viajesDisponibles
            // 
            this.viajesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajesDisponibles.Location = new System.Drawing.Point(6, 19);
            this.viajesDisponibles.Name = "viajesDisponibles";
            this.viajesDisponibles.Size = new System.Drawing.Size(471, 274);
            this.viajesDisponibles.TabIndex = 0;
            this.viajesDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viajesDisponibles_CellClick);
            this.viajesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viajesDisponibles_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viajesDisponibles);
            this.groupBox1.Location = new System.Drawing.Point(30, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "seleccionar viajes disponibles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(279, 51);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.botonLimpiar);
            this.groupBox2.Controls.Add(this.listaDestino);
            this.groupBox2.Controls.Add(this.listaOrigen);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textoFechaInicio);
            this.groupBox2.Location = new System.Drawing.Point(30, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fecha inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoFechaInicio
            // 
            this.textoFechaInicio.Location = new System.Drawing.Point(362, 19);
            this.textoFechaInicio.Name = "textoFechaInicio";
            this.textoFechaInicio.ReadOnly = true;
            this.textoFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.textoFechaInicio.TabIndex = 0;
            this.textoFechaInicio.TextChanged += new System.EventHandler(this.textoFechaInicio_TextChanged);
            // 
            // botonReserva
            // 
            this.botonReserva.Location = new System.Drawing.Point(278, 439);
            this.botonReserva.Name = "botonReserva";
            this.botonReserva.Size = new System.Drawing.Size(235, 23);
            this.botonReserva.TabIndex = 3;
            this.botonReserva.Text = "Reservar viaje";
            this.botonReserva.UseVisualStyleBackColor = true;
            this.botonReserva.Click += new System.EventHandler(this.botonReserva_Click);
            // 
            // botonCompra
            // 
            this.botonCompra.Location = new System.Drawing.Point(278, 494);
            this.botonCompra.Name = "botonCompra";
            this.botonCompra.Size = new System.Drawing.Size(235, 23);
            this.botonCompra.TabIndex = 4;
            this.botonCompra.Text = "Comprar viaje";
            this.botonCompra.UseVisualStyleBackColor = true;
            // 
            // listaOrigen
            // 
            this.listaOrigen.FormattingEnabled = true;
            this.listaOrigen.Location = new System.Drawing.Point(106, 16);
            this.listaOrigen.Name = "listaOrigen";
            this.listaOrigen.Size = new System.Drawing.Size(135, 21);
            this.listaOrigen.TabIndex = 2;
            this.listaOrigen.SelectedIndexChanged += new System.EventHandler(this.listaOrigen_SelectedIndexChanged);
            // 
            // listaDestino
            // 
            this.listaDestino.FormattingEnabled = true;
            this.listaDestino.Location = new System.Drawing.Point(106, 63);
            this.listaDestino.Name = "listaDestino";
            this.listaDestino.Size = new System.Drawing.Size(135, 21);
            this.listaDestino.TabIndex = 3;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(362, 63);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(95, 23);
            this.botonLimpiar.TabIndex = 4;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino";
            // 
            // VentanaSeleccionarviaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 556);
            this.Controls.Add(this.botonCompra);
            this.Controls.Add(this.botonReserva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaSeleccionarviaje";
            this.Text = "VentanaSeleccionarviaje";
            this.Load += new System.EventHandler(this.VentanaSeleccionarviaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viajesDisponibles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viajesDisponibles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoFechaInicio;
        private System.Windows.Forms.Button botonReserva;
        private System.Windows.Forms.Button botonCompra;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.ComboBox listaDestino;
        private System.Windows.Forms.ComboBox listaOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
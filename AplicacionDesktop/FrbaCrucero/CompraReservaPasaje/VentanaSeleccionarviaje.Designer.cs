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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaDestino = new System.Windows.Forms.ComboBox();
            this.listaOrigen = new System.Windows.Forms.ComboBox();
            this.botonReserva = new System.Windows.Forms.Button();
            this.botonCompra = new System.Windows.Forms.Button();
            this.buttonCargarCli = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCantPasajes = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Location = new System.Drawing.Point(30, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "seleccionar viajes disponibles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxCantPasajes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonBuscar);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listaDestino);
            this.groupBox2.Controls.Add(this.listaOrigen);
            this.groupBox2.Location = new System.Drawing.Point(30, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(396, 66);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino";
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
            // listaDestino
            // 
            this.listaDestino.FormattingEnabled = true;
            this.listaDestino.Location = new System.Drawing.Point(106, 59);
            this.listaDestino.Name = "listaDestino";
            this.listaDestino.Size = new System.Drawing.Size(135, 21);
            this.listaDestino.TabIndex = 3;
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
            // botonReserva
            // 
            this.botonReserva.Location = new System.Drawing.Point(278, 461);
            this.botonReserva.Name = "botonReserva";
            this.botonReserva.Size = new System.Drawing.Size(235, 23);
            this.botonReserva.TabIndex = 3;
            this.botonReserva.Text = "Reservar viaje";
            this.botonReserva.UseVisualStyleBackColor = true;
            this.botonReserva.Click += new System.EventHandler(this.botonReserva_Click);
            // 
            // botonCompra
            // 
            this.botonCompra.Location = new System.Drawing.Point(278, 516);
            this.botonCompra.Name = "botonCompra";
            this.botonCompra.Size = new System.Drawing.Size(235, 23);
            this.botonCompra.TabIndex = 4;
            this.botonCompra.Text = "Comprar viaje";
            this.botonCompra.UseVisualStyleBackColor = true;
            this.botonCompra.Click += new System.EventHandler(this.botonCompra_Click);
            // 
            // buttonCargarCli
            // 
            this.buttonCargarCli.Location = new System.Drawing.Point(77, 516);
            this.buttonCargarCli.Name = "buttonCargarCli";
            this.buttonCargarCli.Size = new System.Drawing.Size(110, 23);
            this.buttonCargarCli.TabIndex = 5;
            this.buttonCargarCli.Text = "Carga tus Datos";
            this.buttonCargarCli.UseVisualStyleBackColor = true;
            this.buttonCargarCli.Click += new System.EventHandler(this.buttonCargarCli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad de Pasajes";
            // 
            // comboBoxCantPasajes
            // 
            this.comboBoxCantPasajes.FormattingEnabled = true;
            this.comboBoxCantPasajes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxCantPasajes.Location = new System.Drawing.Point(154, 98);
            this.comboBoxCantPasajes.Name = "comboBoxCantPasajes";
            this.comboBoxCantPasajes.Size = new System.Drawing.Size(87, 21);
            this.comboBoxCantPasajes.TabIndex = 11;
            this.comboBoxCantPasajes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // VentanaSeleccionarviaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 556);
            this.Controls.Add(this.buttonCargarCli);
            this.Controls.Add(this.botonCompra);
            this.Controls.Add(this.botonReserva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaSeleccionarviaje";
            this.Text = "Comprar o Reservar Viaje";
            this.TopMost = true;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonReserva;
        private System.Windows.Forms.Button botonCompra;
        private System.Windows.Forms.ComboBox listaDestino;
        private System.Windows.Forms.ComboBox listaOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCargarCli;
        private System.Windows.Forms.ComboBox comboBoxCantPasajes;
        private System.Windows.Forms.Label label4;
    }
}
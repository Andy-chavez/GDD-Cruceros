namespace FrbaCrucero.AbmRecorrido
{
    partial class VentanaModificarRecorrido
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
            this.recorridosActuales = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textoRecorridoSeleccionado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonModificarRecorrido = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.nuevoOrigen = new System.Windows.Forms.ComboBox();
            this.nuevoDestino = new System.Windows.Forms.ComboBox();
            this.botonDardeBaja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recorridosActuales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // recorridosActuales
            // 
            this.recorridosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recorridosActuales.Location = new System.Drawing.Point(7, 19);
            this.recorridosActuales.Name = "recorridosActuales";
            this.recorridosActuales.ReadOnly = true;
            this.recorridosActuales.Size = new System.Drawing.Size(589, 142);
            this.recorridosActuales.TabIndex = 0;
            this.recorridosActuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosActuales_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.recorridosActuales);
            this.groupBox1.Location = new System.Drawing.Point(21, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos Actuales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.botonLimpiar);
            this.groupBox2.Controls.Add(this.nuevoDestino);
            this.groupBox2.Controls.Add(this.nuevoOrigen);
            this.groupBox2.Location = new System.Drawing.Point(21, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campos a actualizar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textoRecorridoSeleccionado
            // 
            this.textoRecorridoSeleccionado.Location = new System.Drawing.Point(167, 229);
            this.textoRecorridoSeleccionado.Name = "textoRecorridoSeleccionado";
            this.textoRecorridoSeleccionado.ReadOnly = true;
            this.textoRecorridoSeleccionado.Size = new System.Drawing.Size(263, 20);
            this.textoRecorridoSeleccionado.TabIndex = 3;
            this.textoRecorridoSeleccionado.TextChanged += new System.EventHandler(this.textoRecorridoSeleccionado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recorrido seleccionado";
            // 
            // botonModificarRecorrido
            // 
            this.botonModificarRecorrido.Location = new System.Drawing.Point(454, 399);
            this.botonModificarRecorrido.Name = "botonModificarRecorrido";
            this.botonModificarRecorrido.Size = new System.Drawing.Size(163, 23);
            this.botonModificarRecorrido.TabIndex = 5;
            this.botonModificarRecorrido.Text = "Modificar recorrido";
            this.botonModificarRecorrido.UseVisualStyleBackColor = true;
            this.botonModificarRecorrido.Click += new System.EventHandler(this.botonModificarRecorrido_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(483, 51);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // nuevoOrigen
            // 
            this.nuevoOrigen.FormattingEnabled = true;
            this.nuevoOrigen.Location = new System.Drawing.Point(165, 32);
            this.nuevoOrigen.Name = "nuevoOrigen";
            this.nuevoOrigen.Size = new System.Drawing.Size(174, 21);
            this.nuevoOrigen.TabIndex = 0;
            this.nuevoOrigen.SelectedIndexChanged += new System.EventHandler(this.nuevoOrigen_SelectedIndexChanged);
            // 
            // nuevoDestino
            // 
            this.nuevoDestino.FormattingEnabled = true;
            this.nuevoDestino.Location = new System.Drawing.Point(165, 73);
            this.nuevoDestino.Name = "nuevoDestino";
            this.nuevoDestino.Size = new System.Drawing.Size(174, 21);
            this.nuevoDestino.TabIndex = 1;
            this.nuevoDestino.SelectedIndexChanged += new System.EventHandler(this.nuevoDestino_SelectedIndexChanged);
            // 
            // botonDardeBaja
            // 
            this.botonDardeBaja.Location = new System.Drawing.Point(485, 229);
            this.botonDardeBaja.Name = "botonDardeBaja";
            this.botonDardeBaja.Size = new System.Drawing.Size(132, 23);
            this.botonDardeBaja.TabIndex = 6;
            this.botonDardeBaja.Text = "Dar de baja";
            this.botonDardeBaja.UseVisualStyleBackColor = true;
            this.botonDardeBaja.Click += new System.EventHandler(this.botonDardeBaja_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nuevo destino";
            // 
            // VentanaModificarRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 441);
            this.Controls.Add(this.botonDardeBaja);
            this.Controls.Add(this.botonModificarRecorrido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoRecorridoSeleccionado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaModificarRecorrido";
            this.Text = "VentanaBajaRecorrido";
            this.Load += new System.EventHandler(this.VentanaModificarRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recorridosActuales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recorridosActuales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textoRecorridoSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonModificarRecorrido;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.ComboBox nuevoDestino;
        private System.Windows.Forms.ComboBox nuevoOrigen;
        private System.Windows.Forms.Button botonDardeBaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
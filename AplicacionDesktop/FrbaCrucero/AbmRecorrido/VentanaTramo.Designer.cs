namespace FrbaCrucero.AbmRecorrido
{
    partial class VentanaTramo
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
            this.listaOrigen = new System.Windows.Forms.ComboBox();
            this.listaDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaOrigen
            // 
            this.listaOrigen.FormattingEnabled = true;
            this.listaOrigen.Location = new System.Drawing.Point(97, 40);
            this.listaOrigen.Name = "listaOrigen";
            this.listaOrigen.Size = new System.Drawing.Size(188, 21);
            this.listaOrigen.TabIndex = 0;
            this.listaOrigen.SelectedIndexChanged += new System.EventHandler(this.listaOrigen_SelectedIndexChanged);
            // 
            // listaDestino
            // 
            this.listaDestino.FormattingEnabled = true;
            this.listaDestino.Location = new System.Drawing.Point(97, 93);
            this.listaDestino.Name = "listaDestino";
            this.listaDestino.Size = new System.Drawing.Size(188, 21);
            this.listaDestino.TabIndex = 1;
            this.listaDestino.SelectedIndexChanged += new System.EventHandler(this.listaDestino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // textoPrecio
            // 
            this.textoPrecio.Location = new System.Drawing.Point(97, 144);
            this.textoPrecio.Name = "textoPrecio";
            this.textoPrecio.Size = new System.Drawing.Size(89, 20);
            this.textoPrecio.TabIndex = 4;
            this.textoPrecio.TextChanged += new System.EventHandler(this.textoPrecio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(43, 194);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(42, 255);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(76, 23);
            this.botonVolver.TabIndex = 7;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(210, 255);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(75, 23);
            this.botonCrear.TabIndex = 8;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(210, 255);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 9;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // VentanaTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 309);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaDestino);
            this.Controls.Add(this.listaOrigen);
            this.Name = "VentanaTramo";
            this.Text = "VentanaTramo";
            this.Load += new System.EventHandler(this.VentanaTramo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaOrigen;
        private System.Windows.Forms.ComboBox listaDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Button botonEliminar;
    }
}
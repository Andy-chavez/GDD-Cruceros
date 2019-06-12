namespace FrbaCrucero.AbmCrucero
{
    partial class VentanaAltaCrucero
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
            this.botonCrear = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.textoIdCrucero = new System.Windows.Forms.TextBox();
            this.texoIdFabricante = new System.Windows.Forms.TextBox();
            this.textoModelo = new System.Windows.Forms.TextBox();
            this.Crucero_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoCabina = new System.Windows.Forms.TextBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(322, 249);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(75, 23);
            this.botonCrear.TabIndex = 0;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(32, 249);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 1;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // textoIdCrucero
            // 
            this.textoIdCrucero.Location = new System.Drawing.Point(137, 43);
            this.textoIdCrucero.Name = "textoIdCrucero";
            this.textoIdCrucero.Size = new System.Drawing.Size(176, 20);
            this.textoIdCrucero.TabIndex = 2;
            this.textoIdCrucero.TextChanged += new System.EventHandler(this.textoIdCrucero_TextChanged);
            // 
            // texoIdFabricante
            // 
            this.texoIdFabricante.Location = new System.Drawing.Point(137, 84);
            this.texoIdFabricante.Name = "texoIdFabricante";
            this.texoIdFabricante.Size = new System.Drawing.Size(176, 20);
            this.texoIdFabricante.TabIndex = 3;
            this.texoIdFabricante.TextChanged += new System.EventHandler(this.texoIdFabricante_TextChanged);
            // 
            // textoModelo
            // 
            this.textoModelo.Location = new System.Drawing.Point(137, 134);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(176, 20);
            this.textoModelo.TabIndex = 4;
            this.textoModelo.TextChanged += new System.EventHandler(this.textoModelo_TextChanged);
            // 
            // Crucero_id
            // 
            this.Crucero_id.AutoSize = true;
            this.Crucero_id.Location = new System.Drawing.Point(49, 46);
            this.Crucero_id.Name = "Crucero_id";
            this.Crucero_id.Size = new System.Drawing.Size(58, 13);
            this.Crucero_id.TabIndex = 5;
            this.Crucero_id.Text = "Crucero_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fabricante_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidada De Cabinas";
            // 
            // textoCabina
            // 
            this.textoCabina.Location = new System.Drawing.Point(171, 169);
            this.textoCabina.Name = "textoCabina";
            this.textoCabina.Size = new System.Drawing.Size(142, 20);
            this.textoCabina.TabIndex = 9;
            this.textoCabina.TextChanged += new System.EventHandler(this.textoCabina_TextChanged);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(322, 210);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 10;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // VentanaAltaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 304);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.textoCabina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Crucero_id);
            this.Controls.Add(this.textoModelo);
            this.Controls.Add(this.texoIdFabricante);
            this.Controls.Add(this.textoIdCrucero);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonCrear);
            this.Name = "VentanaAltaCrucero";
            this.Text = "Alta Crucero";
            this.Load += new System.EventHandler(this.VentanaAltaCrucero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TextBox textoIdCrucero;
        private System.Windows.Forms.TextBox texoIdFabricante;
        private System.Windows.Forms.TextBox textoModelo;
        private System.Windows.Forms.Label Crucero_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoCabina;
        private System.Windows.Forms.Button botonLimpiar;
    }
}
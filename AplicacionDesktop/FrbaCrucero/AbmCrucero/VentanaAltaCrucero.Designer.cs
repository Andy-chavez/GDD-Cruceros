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
            this.Crucero_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ejecutiva = new System.Windows.Forms.TextBox();
            this.comboBoxFabID = new System.Windows.Forms.ComboBox();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estandarLabel = new System.Windows.Forms.Label();
            this.balconLabel = new System.Windows.Forms.Label();
            this.estandar = new System.Windows.Forms.TextBox();
            this.balcon = new System.Windows.Forms.TextBox();
            this.exterior = new System.Windows.Forms.TextBox();
            this.suite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(606, 248);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(75, 23);
            this.botonCrear.TabIndex = 0;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(32, 248);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 1;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click_1);
            // 
            // textoIdCrucero
            // 
            this.textoIdCrucero.Location = new System.Drawing.Point(144, 17);
            this.textoIdCrucero.Name = "textoIdCrucero";
            this.textoIdCrucero.Size = new System.Drawing.Size(176, 20);
            this.textoIdCrucero.TabIndex = 2;
            this.textoIdCrucero.TextChanged += new System.EventHandler(this.textoIdCrucero_TextChanged);
            // 
            // Crucero_id
            // 
            this.Crucero_id.AutoSize = true;
            this.Crucero_id.Location = new System.Drawing.Point(39, 20);
            this.Crucero_id.Name = "Crucero_id";
            this.Crucero_id.Size = new System.Drawing.Size(58, 13);
            this.Crucero_id.TabIndex = 5;
            this.Crucero_id.Text = "Crucero_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fabricante_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo";
            // 
            // ejecutiva
            // 
            this.ejecutiva.Location = new System.Drawing.Point(150, 56);
            this.ejecutiva.Name = "ejecutiva";
            this.ejecutiva.Size = new System.Drawing.Size(176, 20);
            this.ejecutiva.TabIndex = 9;
            this.ejecutiva.TextChanged += new System.EventHandler(this.textoCabina_TextChanged);
            // 
            // comboBoxFabID
            // 
            this.comboBoxFabID.FormattingEnabled = true;
            this.comboBoxFabID.Location = new System.Drawing.Point(144, 55);
            this.comboBoxFabID.Name = "comboBoxFabID";
            this.comboBoxFabID.Size = new System.Drawing.Size(176, 21);
            this.comboBoxFabID.TabIndex = 11;
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(442, 17);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(176, 21);
            this.comboModelo.TabIndex = 12;
            this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.ComboModelo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estandarLabel);
            this.groupBox1.Controls.Add(this.balconLabel);
            this.groupBox1.Controls.Add(this.estandar);
            this.groupBox1.Controls.Add(this.balcon);
            this.groupBox1.Controls.Add(this.exterior);
            this.groupBox1.Controls.Add(this.suite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ejecutiva);
            this.groupBox1.Location = new System.Drawing.Point(32, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese cantidad de cabinas";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // estandarLabel
            // 
            this.estandarLabel.AutoSize = true;
            this.estandarLabel.Location = new System.Drawing.Point(362, 59);
            this.estandarLabel.Name = "estandarLabel";
            this.estandarLabel.Size = new System.Drawing.Size(49, 13);
            this.estandarLabel.TabIndex = 17;
            this.estandarLabel.Text = "Estandar";
            // 
            // balconLabel
            // 
            this.balconLabel.AutoSize = true;
            this.balconLabel.Location = new System.Drawing.Point(362, 26);
            this.balconLabel.Name = "balconLabel";
            this.balconLabel.Size = new System.Drawing.Size(40, 13);
            this.balconLabel.TabIndex = 16;
            this.balconLabel.Text = "Balcón";
            // 
            // estandar
            // 
            this.estandar.Location = new System.Drawing.Point(440, 56);
            this.estandar.Name = "estandar";
            this.estandar.Size = new System.Drawing.Size(176, 20);
            this.estandar.TabIndex = 15;
            // 
            // balcon
            // 
            this.balcon.Location = new System.Drawing.Point(440, 23);
            this.balcon.Name = "balcon";
            this.balcon.Size = new System.Drawing.Size(176, 20);
            this.balcon.TabIndex = 14;
            // 
            // exterior
            // 
            this.exterior.Location = new System.Drawing.Point(150, 90);
            this.exterior.Name = "exterior";
            this.exterior.Size = new System.Drawing.Size(176, 20);
            this.exterior.TabIndex = 13;
            // 
            // suite
            // 
            this.suite.Location = new System.Drawing.Point(150, 23);
            this.suite.Name = "suite";
            this.suite.Size = new System.Drawing.Size(176, 20);
            this.suite.TabIndex = 12;
            this.suite.TextChanged += new System.EventHandler(this.Suite_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Exterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ejeutiva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suite";
            // 
            // VentanaAltaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 286);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.comboBoxFabID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Crucero_id);
            this.Controls.Add(this.textoIdCrucero);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonCrear);
            this.Name = "VentanaAltaCrucero";
            this.Text = "Alta Crucero";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaAltaCrucero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TextBox textoIdCrucero;
        private System.Windows.Forms.Label Crucero_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ejecutiva;
        private System.Windows.Forms.ComboBox comboBoxFabID;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label estandarLabel;
        private System.Windows.Forms.Label balconLabel;
        private System.Windows.Forms.TextBox estandar;
        private System.Windows.Forms.TextBox balcon;
        private System.Windows.Forms.TextBox exterior;
        private System.Windows.Forms.TextBox suite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}
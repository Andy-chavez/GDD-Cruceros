namespace FrbaCrucero.CompraReservaPasaje
{
    partial class VentanaMedioDePago
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
            this.MediosDePagosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedios = new System.Windows.Forms.ComboBox();
            this.MediosDePagosDisponiblesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.botonSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MediosDePagosDisponiblesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediosDePagosDisponiblesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // MediosDePagosDisponiblesBindingSource
            // 
            this.MediosDePagosDisponiblesBindingSource.DataMember = "MediosDePagosDisponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxMedios);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Medio De Pago";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MedioDePago";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxMedios
            // 
            this.comboBoxMedios.DataSource = this.MediosDePagosDisponiblesBindingSource1;
            this.comboBoxMedios.FormattingEnabled = true;
            this.comboBoxMedios.Location = new System.Drawing.Point(83, 42);
            this.comboBoxMedios.Name = "comboBoxMedios";
            this.comboBoxMedios.Size = new System.Drawing.Size(267, 21);
            this.comboBoxMedios.TabIndex = 0;
            this.comboBoxMedios.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // botonEliminar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(329, 156);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.botonSeleccionar.TabIndex = 4;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // VentanaMedioDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 196);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaMedioDePago";
            this.Text = "Medio De Pago";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaMedioDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediosDePagosDisponiblesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediosDePagosDisponiblesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource MediosDePagosDisponiblesBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedios;
        private System.Windows.Forms.BindingSource MediosDePagosDisponiblesBindingSource1;
        private System.Windows.Forms.Button botonSeleccionar;
    }
}
namespace FrbaCrucero.GeneracionViaje
{
    partial class GenerarViaje
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
            this.buttonRecorrido = new System.Windows.Forms.Button();
            this.buttonCrucero = new System.Windows.Forms.Button();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRecorrido
            // 
            this.buttonRecorrido.Location = new System.Drawing.Point(251, 73);
            this.buttonRecorrido.Name = "buttonRecorrido";
            this.buttonRecorrido.Size = new System.Drawing.Size(95, 23);
            this.buttonRecorrido.TabIndex = 0;
            this.buttonRecorrido.Text = "Elegir Recorrido";
            this.buttonRecorrido.UseVisualStyleBackColor = true;
            // 
            // buttonCrucero
            // 
            this.buttonCrucero.Location = new System.Drawing.Point(251, 111);
            this.buttonCrucero.Name = "buttonCrucero";
            this.buttonCrucero.Size = new System.Drawing.Size(95, 23);
            this.buttonCrucero.TabIndex = 1;
            this.buttonCrucero.Text = "Elegir Crucero";
            this.buttonCrucero.UseVisualStyleBackColor = true;
            this.buttonCrucero.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(206, 186);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicio.TabIndex = 2;
            this.dateTimePickerInicio.TabStop = false;
            this.dateTimePickerInicio.MinDate = System.DateTime.Now;//System.DateTime.Today;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dateTimePickerFin.Location = new System.Drawing.Point(206, 279);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFin.TabIndex = 3;
            this.dateTimePickerFin.MinDate = System.DateTime.Now;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Elegir Fecha de Inicio";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Elegir Fecha de Finalización";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 532);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.buttonCrucero);
            this.Controls.Add(this.buttonRecorrido);
            this.Name = "GenerarViaje";
            this.Text = "Generar Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecorrido;
        private System.Windows.Forms.Button buttonCrucero;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
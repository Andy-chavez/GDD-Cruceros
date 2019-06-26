using FrbaCrucero.Clases;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridViewRec = new System.Windows.Forms.DataGridView();
            this.dataGridViewCruc = new System.Windows.Forms.DataGridView();
            this.buttonGenViaje = new System.Windows.Forms.Button();
            this.buttonCruc = new System.Windows.Forms.Button();
            this.generarViajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCruc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarViajeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(208, 318);
            this.dateTimePickerInicio.MinDate = new System.DateTime(2019, 6, 13, 12, 47, 28, 975);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicio.TabIndex = 2;
            this.dateTimePickerInicio.Value = new System.DateTime(2019, 6, 13, 12, 47, 28, 975);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.Location = new System.Drawing.Point(208, 416);
            this.dateTimePickerFin.MinDate = new System.DateTime(2019, 6, 13, 12, 47, 28, 975);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFin.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 277);
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
            this.textBox2.Location = new System.Drawing.Point(236, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Elegir Fecha de Finalización";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Elegir Recorrido";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewRec
            // 
            this.dataGridViewRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRec.Location = new System.Drawing.Point(49, 87);
            this.dataGridViewRec.Name = "dataGridViewRec";
            this.dataGridViewRec.Size = new System.Drawing.Size(515, 150);
            this.dataGridViewRec.TabIndex = 8;
            this.dataGridViewRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRec_CellContentClick);
            // 
            // dataGridViewCruc
            // 
            this.dataGridViewCruc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCruc.Location = new System.Drawing.Point(49, 517);
            this.dataGridViewCruc.Name = "dataGridViewCruc";
            this.dataGridViewCruc.Size = new System.Drawing.Size(515, 150);
            this.dataGridViewCruc.TabIndex = 9;
            // 
            // buttonGenViaje
            // 
            this.buttonGenViaje.Location = new System.Drawing.Point(274, 691);
            this.buttonGenViaje.Name = "buttonGenViaje";
            this.buttonGenViaje.Size = new System.Drawing.Size(75, 23);
            this.buttonGenViaje.TabIndex = 10;
            this.buttonGenViaje.Text = "Crear Viaje";
            this.buttonGenViaje.UseVisualStyleBackColor = true;
            this.buttonGenViaje.Click += new System.EventHandler(this.buttonGenViaje_Click);
            // 
            // buttonCruc
            // 
            this.buttonCruc.Location = new System.Drawing.Point(257, 462);
            this.buttonCruc.Name = "buttonCruc";
            this.buttonCruc.Size = new System.Drawing.Size(102, 23);
            this.buttonCruc.TabIndex = 11;
            this.buttonCruc.Text = "Elegir Crucero";
            this.buttonCruc.UseVisualStyleBackColor = true;
            this.buttonCruc.Click += new System.EventHandler(this.buttonCruc_Click);
            // 
            // generarViajeBindingSource
            // 
            this.generarViajeBindingSource.DataSource = typeof(FrbaCrucero.GeneracionViaje.GenerarViaje);
            // 
            // GenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 729);
            this.Controls.Add(this.buttonCruc);
            this.Controls.Add(this.buttonGenViaje);
            this.Controls.Add(this.dataGridViewCruc);
            this.Controls.Add(this.dataGridViewRec);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Name = "GenerarViaje";
            this.Text = "Generar Viaje";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GenerarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCruc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generarViajeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridViewRec;
        private System.Windows.Forms.DataGridView dataGridViewCruc;
        private System.Windows.Forms.Button buttonGenViaje;
        private System.Windows.Forms.Button buttonCruc;
        private BindingSource generarViajeBindingSource;
    }
}
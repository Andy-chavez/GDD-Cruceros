using System;

namespace FrbaCrucero.AbmRol
{
    partial class VentanaModificarRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.funcionalidadPorRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonFinalizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rolSelect = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridNoTiene = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridTiene = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.botonAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadPorRolBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNoTiene)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiene)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol seleccionado";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(30, 431);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(179, 270);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(125, 23);
            this.botonEliminar.TabIndex = 4;
            this.botonEliminar.Text = "Quitar Funcionalidad";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonFinalizar
            // 
            this.botonFinalizar.Location = new System.Drawing.Point(549, 442);
            this.botonFinalizar.Name = "botonFinalizar";
            this.botonFinalizar.Size = new System.Drawing.Size(125, 23);
            this.botonFinalizar.TabIndex = 5;
            this.botonFinalizar.Text = "Finalizar cambios";
            this.botonFinalizar.UseVisualStyleBackColor = true;
            this.botonFinalizar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Presione finalizar al concluir sus cambios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // rolSelect
            // 
            this.rolSelect.Location = new System.Drawing.Point(142, 23);
            this.rolSelect.Name = "rolSelect";
            this.rolSelect.Size = new System.Drawing.Size(184, 20);
            this.rolSelect.TabIndex = 13;
            this.rolSelect.TextChanged += new System.EventHandler(this.RolSelect_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textoNombre);
            this.groupBox1.Location = new System.Drawing.Point(362, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 53);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese nombre del nuevo rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(133, 19);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(225, 20);
            this.textoNombre.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridNoTiene);
            this.groupBox2.Location = new System.Drawing.Point(30, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 303);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione de esta tabla las funcionalidades que desea agregarle al rol elegido";
            // 
            // dataGridNoTiene
            // 
            this.dataGridNoTiene.AllowUserToAddRows = false;
            this.dataGridNoTiene.AllowUserToDeleteRows = false;
            this.dataGridNoTiene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNoTiene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNoTiene.Location = new System.Drawing.Point(44, 30);
            this.dataGridNoTiene.Name = "dataGridNoTiene";
            this.dataGridNoTiene.ReadOnly = true;
            this.dataGridNoTiene.Size = new System.Drawing.Size(220, 234);
            this.dataGridNoTiene.TabIndex = 0;
            this.dataGridNoTiene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridNoTiene.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridNoTiene_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridTiene);
            this.groupBox3.Controls.Add(this.botonEliminar);
            this.groupBox3.Location = new System.Drawing.Point(370, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 303);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estas son las funcionalidades que posee el rol, quite las que desee con el boton " +
    "de quitar";
            // 
            // dataGridTiene
            // 
            this.dataGridTiene.AllowUserToAddRows = false;
            this.dataGridTiene.AllowUserToDeleteRows = false;
            this.dataGridTiene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTiene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTiene.Location = new System.Drawing.Point(46, 30);
            this.dataGridTiene.Name = "dataGridTiene";
            this.dataGridTiene.ReadOnly = true;
            this.dataGridTiene.Size = new System.Drawing.Size(220, 234);
            this.dataGridTiene.TabIndex = 0;
            this.dataGridTiene.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTiene_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Deshabilitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(229, 62);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(111, 23);
            this.botonAlta.TabIndex = 18;
            this.botonAlta.Text = "Habilitar";
            this.botonAlta.UseVisualStyleBackColor = true;
            this.botonAlta.Click += new System.EventHandler(this.BotonAlta_Click);
            // 
            // VentanaModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(750, 477);
            this.Controls.Add(this.botonAlta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rolSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonFinalizar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label1);
            this.Name = "VentanaModificarRol";
            this.Text = "Modificar Rol";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaRolSeleccionado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadPorRolBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNoTiene)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.BindingSource funcionalidadPorRolBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonFinalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rolSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridNoTiene;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridTiene;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonAlta;
    }
}
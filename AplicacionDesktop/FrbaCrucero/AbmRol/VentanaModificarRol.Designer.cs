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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaFunc = new System.Windows.Forms.DataGridView();
            this.funcionalidadPorRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.comboBoxFuncionalidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.casillaUsuario = new System.Windows.Forms.TextBox();
            this.comboBoxFuncAgregar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadPorRolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol seleccionado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaFunc);
            this.groupBox1.Location = new System.Drawing.Point(39, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades por Rol hasta el momento";
            // 
            // listaFunc
            // 
            this.listaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaFunc.Location = new System.Drawing.Point(32, 30);
            this.listaFunc.Name = "listaFunc";
            this.listaFunc.Size = new System.Drawing.Size(267, 168);
            this.listaFunc.TabIndex = 0;
            this.listaFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaFunc_CellClick);
            this.listaFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaFunc_CellContentClick);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(30, 462);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(378, 435);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 4;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(378, 474);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 5;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // comboBoxFuncionalidades
            // 
            this.comboBoxFuncionalidades.FormattingEnabled = true;
            this.comboBoxFuncionalidades.Location = new System.Drawing.Point(239, 78);
            this.comboBoxFuncionalidades.Name = "comboBoxFuncionalidades";
            this.comboBoxFuncionalidades.Size = new System.Drawing.Size(214, 21);
            this.comboBoxFuncionalidades.TabIndex = 6;
            this.comboBoxFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Funcionalidades del Rol seleccionado";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(239, 32);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(214, 21);
            this.comboBoxRoles.TabIndex = 8;
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRoles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese nuevo nombre de Rol";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // casillaUsuario
            // 
            this.casillaUsuario.Location = new System.Drawing.Point(239, 165);
            this.casillaUsuario.Name = "casillaUsuario";
            this.casillaUsuario.Size = new System.Drawing.Size(214, 20);
            this.casillaUsuario.TabIndex = 10;
            this.casillaUsuario.TextChanged += new System.EventHandler(this.CasillaUsuario_TextChanged);
            // 
            // comboBoxFuncAgregar
            // 
            this.comboBoxFuncAgregar.FormattingEnabled = true;
            this.comboBoxFuncAgregar.Location = new System.Drawing.Point(239, 123);
            this.comboBoxFuncAgregar.Name = "comboBoxFuncAgregar";
            this.comboBoxFuncAgregar.Size = new System.Drawing.Size(214, 21);
            this.comboBoxFuncAgregar.TabIndex = 11;
            this.comboBoxFuncAgregar.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Funcionalidades que pueden agregarse:";
            // 
            // VentanaModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxFuncAgregar);
            this.Controls.Add(this.casillaUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFuncionalidades);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "VentanaModificarRol";
            this.Text = "Modificar Rol";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaRolSeleccionado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadPorRolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listaFunc;

        private System.Windows.Forms.BindingSource funcionalidadPorRolBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.ComboBox comboBoxFuncionalidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox casillaUsuario;
        private System.Windows.Forms.ComboBox comboBoxFuncAgregar;
        private System.Windows.Forms.Label label4;
    }
}
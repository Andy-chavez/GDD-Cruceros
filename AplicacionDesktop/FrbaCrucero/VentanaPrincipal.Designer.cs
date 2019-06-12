namespace FrbaCrucero
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonSesionUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.botonSesionCliente = new System.Windows.Forms.Button();
            this.casillaContraseña = new System.Windows.Forms.TextBox();
            this.casillaUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inicio de sesion con Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // botonSesionUsuario
            // 
            this.botonSesionUsuario.Location = new System.Drawing.Point(197, 159);
            this.botonSesionUsuario.Name = "botonSesionUsuario";
            this.botonSesionUsuario.Size = new System.Drawing.Size(145, 23);
            this.botonSesionUsuario.TabIndex = 7;
            this.botonSesionUsuario.Text = "Iiniciar Sesion";
            this.botonSesionUsuario.UseVisualStyleBackColor = true;
            this.botonSesionUsuario.Click += new System.EventHandler(this.botonSesionUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iinicio de sesion para Clientes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // botonSesionCliente
            // 
            this.botonSesionCliente.Location = new System.Drawing.Point(197, 212);
            this.botonSesionCliente.Name = "botonSesionCliente";
            this.botonSesionCliente.Size = new System.Drawing.Size(146, 23);
            this.botonSesionCliente.TabIndex = 9;
            this.botonSesionCliente.Text = "Iniciar Sesion Cliente";
            this.botonSesionCliente.UseVisualStyleBackColor = true;
            this.botonSesionCliente.Click += new System.EventHandler(this.botonSesionCliente_Click);
            // 
            // casillaContraseña
            // 
            this.casillaContraseña.Location = new System.Drawing.Point(197, 114);
            this.casillaContraseña.Name = "casillaContraseña";
            this.casillaContraseña.Size = new System.Drawing.Size(145, 20);
            this.casillaContraseña.TabIndex = 10;
            this.casillaContraseña.UseSystemPasswordChar = true;
            // 
            // casillaUsuario
            // 
            this.casillaUsuario.Location = new System.Drawing.Point(197, 78);
            this.casillaUsuario.Name = "casillaUsuario";
            this.casillaUsuario.Size = new System.Drawing.Size(145, 20);
            this.casillaUsuario.TabIndex = 11;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 323);
            this.Controls.Add(this.casillaUsuario);
            this.Controls.Add(this.casillaContraseña);
            this.Controls.Add(this.botonSesionCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonSesionUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPrincipal";
            this.Text = "Inicio de sesión";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonSesionUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonSesionCliente;
        private System.Windows.Forms.TextBox casillaContraseña;
        private System.Windows.Forms.TextBox casillaUsuario;
    }
}


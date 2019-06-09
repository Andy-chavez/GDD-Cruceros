namespace FrbaCrucero
{
    partial class VentanaMenu
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
            this.botonAdmCrucero = new System.Windows.Forms.Button();
            this.botonAdmPuertos = new System.Windows.Forms.Button();
            this.botonAdmRecorrido = new System.Windows.Forms.Button();
            this.botonAbmRol = new System.Windows.Forms.Button();
            this.botonReserva = new System.Windows.Forms.Button();
            this.botonViaje = new System.Windows.Forms.Button();
            this.botonPago = new System.Windows.Forms.Button();
            this.botonEstadisticas = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAdmCrucero
            // 
            this.botonAdmCrucero.Location = new System.Drawing.Point(77, 127);
            this.botonAdmCrucero.Name = "botonAdmCrucero";
            this.botonAdmCrucero.Size = new System.Drawing.Size(229, 23);
            this.botonAdmCrucero.TabIndex = 0;
            this.botonAdmCrucero.Text = "Gestionar Cruceros";
            this.botonAdmCrucero.UseVisualStyleBackColor = true;
            this.botonAdmCrucero.Click += new System.EventHandler(this.botonAdmCrucero_Click);
            // 
            // botonAdmPuertos
            // 
            this.botonAdmPuertos.Location = new System.Drawing.Point(77, 173);
            this.botonAdmPuertos.Name = "botonAdmPuertos";
            this.botonAdmPuertos.Size = new System.Drawing.Size(229, 23);
            this.botonAdmPuertos.TabIndex = 1;
            this.botonAdmPuertos.Text = "Gestionar Puertos";
            this.botonAdmPuertos.UseVisualStyleBackColor = true;
            this.botonAdmPuertos.Click += new System.EventHandler(this.botonAdmPuertos_Click);
            // 
            // botonAdmRecorrido
            // 
            this.botonAdmRecorrido.Location = new System.Drawing.Point(77, 214);
            this.botonAdmRecorrido.Name = "botonAdmRecorrido";
            this.botonAdmRecorrido.Size = new System.Drawing.Size(229, 23);
            this.botonAdmRecorrido.TabIndex = 2;
            this.botonAdmRecorrido.Text = "Gestionar Recorrido";
            this.botonAdmRecorrido.UseVisualStyleBackColor = true;
            this.botonAdmRecorrido.Click += new System.EventHandler(this.botonAdmRecorrido_Click);
            // 
            // botonAbmRol
            // 
            this.botonAbmRol.Location = new System.Drawing.Point(77, 253);
            this.botonAbmRol.Name = "botonAbmRol";
            this.botonAbmRol.Size = new System.Drawing.Size(229, 23);
            this.botonAbmRol.TabIndex = 3;
            this.botonAbmRol.Text = "Gestionar Rol";
            this.botonAbmRol.UseVisualStyleBackColor = true;
            this.botonAbmRol.Click += new System.EventHandler(this.botonAbmRol_Click);
            // 
            // botonReserva
            // 
            this.botonReserva.Location = new System.Drawing.Point(77, 38);
            this.botonReserva.Name = "botonReserva";
            this.botonReserva.Size = new System.Drawing.Size(229, 23);
            this.botonReserva.TabIndex = 4;
            this.botonReserva.Text = "Comprar Reserva de Pasaje";
            this.botonReserva.UseVisualStyleBackColor = true;
            this.botonReserva.Click += new System.EventHandler(this.botonReserva_Click);
            // 
            // botonViaje
            // 
            this.botonViaje.Location = new System.Drawing.Point(77, 297);
            this.botonViaje.Name = "botonViaje";
            this.botonViaje.Size = new System.Drawing.Size(229, 23);
            this.botonViaje.TabIndex = 5;
            this.botonViaje.Text = "Generar Viaje";
            this.botonViaje.UseVisualStyleBackColor = true;
            this.botonViaje.Click += new System.EventHandler(this.botonViaje_Click);
            // 
            // botonPago
            // 
            this.botonPago.Location = new System.Drawing.Point(77, 84);
            this.botonPago.Name = "botonPago";
            this.botonPago.Size = new System.Drawing.Size(229, 23);
            this.botonPago.TabIndex = 6;
            this.botonPago.Text = "Pagar Reserva";
            this.botonPago.UseVisualStyleBackColor = true;
            this.botonPago.Click += new System.EventHandler(this.botonPago_Click);
            // 
            // botonEstadisticas
            // 
            this.botonEstadisticas.Location = new System.Drawing.Point(77, 336);
            this.botonEstadisticas.Name = "botonEstadisticas";
            this.botonEstadisticas.Size = new System.Drawing.Size(229, 23);
            this.botonEstadisticas.TabIndex = 7;
            this.botonEstadisticas.Text = "Estadisticas";
            this.botonEstadisticas.UseVisualStyleBackColor = true;
            this.botonEstadisticas.Click += new System.EventHandler(this.botonEstadisticas_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(77, 378);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(229, 23);
            this.botonSalir.TabIndex = 8;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // VentanaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 416);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonEstadisticas);
            this.Controls.Add(this.botonPago);
            this.Controls.Add(this.botonViaje);
            this.Controls.Add(this.botonReserva);
            this.Controls.Add(this.botonAbmRol);
            this.Controls.Add(this.botonAdmRecorrido);
            this.Controls.Add(this.botonAdmPuertos);
            this.Controls.Add(this.botonAdmCrucero);
            this.Name = "VentanaMenu";
            this.Text = "Menu operaciones";
            this.Load += new System.EventHandler(this.VentanaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAdmCrucero;
        private System.Windows.Forms.Button botonAdmPuertos;
        private System.Windows.Forms.Button botonAdmRecorrido;
        private System.Windows.Forms.Button botonAbmRol;
        private System.Windows.Forms.Button botonReserva;
        private System.Windows.Forms.Button botonViaje;
        private System.Windows.Forms.Button botonPago;
        private System.Windows.Forms.Button botonEstadisticas;
        private System.Windows.Forms.Button botonSalir;
    }
}
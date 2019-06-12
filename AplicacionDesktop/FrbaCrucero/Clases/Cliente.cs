using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Cliente
    {
        #region Atributos

        public string id { get; set; }
        public string idRol { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
      

        #endregion

        #region Constructores

        public Cliente(string id, string idRol, string nombre, string apellido, int dni, string direccion, string telefono, string mail, DateTime fechaNacimiento)
        {
            this.id = id;
            this.idRol = idRol;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.mail = mail;
            this.fechaNacimiento = fechaNacimiento;
        }

        

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Usuario
    {

        #region Atributos

        public string id { get; set; }
        public string nombre { get; set; }
        public string contrasenia { get; set; }
        public int intentosPosibles { get; set; }
        public string idRol { get; set; }
        

        #endregion

        #region Constructores

        public Usuario(string id, string nombre, string contrasenia, int intentosPosibles, string idRol)
        {
            this.id = id;
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.intentosPosibles = intentosPosibles;
            this.idRol = idRol;
           
        }

        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }

        public Usuario(string idN, string nombreN, string contraseniaN)
        {
            this.id = idN;
            this.nombre = nombreN;
            this.contrasenia = contraseniaN;
        }

        public Usuario()
        {
            // TODO: Complete member initialization
        }

        #endregion
    }
}

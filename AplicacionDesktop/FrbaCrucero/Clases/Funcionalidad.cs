using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Funcionalidad
    {
         
        #region Atributos

        public string id { get; set; }
        public string descripcion { get; set; }

        #endregion

        #region Constructores

        public Funcionalidad(string id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;       
        }

        #endregion
    }
}

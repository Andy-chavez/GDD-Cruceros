
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Puerto
    {
        #region Atributos

        public string id { get; set; }
        public string nombre { get; set; }

        #endregion

        #region Constructores

        public Puerto(string id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        #endregion
    }
}

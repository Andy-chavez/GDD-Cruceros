using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Cabina
    {
        #region Atributos

        public int id { get; set; }
        public string idTipo { get; set; }
        public string idCrucero { get; set; }
        public int numero { get; set; }
        public int piso { get; set; }
       

        #endregion

        #region Constructores

        public Cabina(int id, string idTipo,string idCrucero ,int numero, int piso)
        {
            this.id = id;
            this.idTipo = idTipo;
            this.idCrucero = idCrucero;
            this.numero = numero;
            this.piso = piso;
        }
        public Cabina(string idTipo)
        {
            this.idTipo = idTipo;
        }

        #endregion
    }
}

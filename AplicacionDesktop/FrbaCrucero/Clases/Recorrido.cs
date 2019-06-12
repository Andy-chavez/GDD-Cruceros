using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Recorrido
    {
         #region Atributos

        public string id { get; set; }
        public Puerto origen { get; set; }
        public Puerto destino { get; set; }
        public string estado { get; set; }
        public List<Tramo> tramos{ get; set; }
       

        #endregion

        #region Constructores

        public Recorrido(string id, Puerto origen, Puerto destino, string estado, List<Tramo> tramos)
        {
            this.id = id;
            this.origen = origen;
            this.destino = destino;
            this.estado = estado;
            this.tramos = tramos;
         
        }
        public Recorrido(string estado)
        {
            this.estado = estado;
        }

        #endregion

    }
}

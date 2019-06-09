using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Viaje
    {
         #region Atributos

        public string id { get; set; }
        public string idRecorrido { get; set; }
        public string idCrucero { get; set; }
        public DateTime FinalizacionEstimada { get; set; }
        public DateTime FechaInicion { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        

        #endregion

        #region Constructores

        public Viaje(string id, string idRecorrido, string idCrucero, DateTime FinalizacionEstimada, DateTime FechaInicion, DateTime FechaFinalizacion)
        {
            this.id = id;
            this.idRecorrido = idRecorrido;
            this.idCrucero = idCrucero;
            this.FinalizacionEstimada = FinalizacionEstimada;
            this.FechaInicion = FechaInicion;
            this.FechaFinalizacion = FechaFinalizacion;
         
        }

        #endregion
    }
}

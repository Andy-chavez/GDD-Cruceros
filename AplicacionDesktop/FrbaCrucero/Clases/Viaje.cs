using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    public class Viaje
    {
         #region Atributos

        public int id { get; set; }
        public int idRecorrido { get; set; }
        public string idCrucero { get; set; }
        public DateTime FinalizacionEstimada { get; set; }
        public DateTime FechaInicion { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        

        #endregion

        #region Constructores

        public Viaje(int id, int idRecorrido, string idCrucero, DateTime FinalizacionEstimada, DateTime FechaInicion, DateTime FechaFinalizacion)
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

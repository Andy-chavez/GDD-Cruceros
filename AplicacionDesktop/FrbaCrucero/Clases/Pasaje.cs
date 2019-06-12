using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Pasaje
    {
         #region Atributos

        public string id { get; set; }
        public string idCliente { get; set; }
        public string idViaje { get; set; }
        public string idCrucero { get; set; }
        public string idCabina { get; set; }
        public string idPago { get; set; }
        public int precio { get; set; }
        public bool cancelacion { get; set; }
        public string motivoCancelacion { get; set; }
        public DateTime fechaCancelacion { get; set; }
        public DateTime fechaDeReprogramacion { get; set; }
        

        #endregion

        #region Constructores

        public Pasaje(string id, string idCliente, string idViaje, string idCrucero, string idCabina, string idPago, int precio, bool cancelacion, string motivoCancelacion, DateTime fechaCancelacion, DateTime fechaDeReprogramacion)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.idViaje = idViaje;
            this.idCrucero = idCrucero;
            this.idCabina = idCabina;
            this.idPago = idPago;
            this.precio = precio;
            this.cancelacion = cancelacion;
            this.motivoCancelacion = motivoCancelacion;
            this.fechaCancelacion = fechaCancelacion;
            this.fechaDeReprogramacion = fechaDeReprogramacion;
        }
        

        #endregion
    }
}

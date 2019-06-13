using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Reserva
    {
          
        #region Atributos

        public string id { get; set; }
        public string idCliente { get; set; }
        public string idViaje { get; set; }
        public string idCrucero { get; set; }
        public string idCabina { get; set; }
        public DateTime Vencimiento { get; set; }
        

        #endregion

        #region Constructores

        public Reserva(string id, string idCliente, string idViaje, string idCrucero, DateTime Vencimiento)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.idViaje = idViaje;
            this.idCrucero = idCrucero;
            this.Vencimiento = Vencimiento;
        }
        public Reserva(string idCrucero)
        {
            this.idCrucero = idCrucero;
        }

        #endregion
    }
}

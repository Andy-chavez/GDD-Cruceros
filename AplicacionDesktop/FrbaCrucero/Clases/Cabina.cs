using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    public class Cabina
    {
        #region Atributos
        public int idCabina { get; set; }
        #endregion Atributos

        #region Constructores
        public Cabina(int idCabina)
        {
            this.idCabina = idCabina;
        }
        #endregion Constructores
    }
}

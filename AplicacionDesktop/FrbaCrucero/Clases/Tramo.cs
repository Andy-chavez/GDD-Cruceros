using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Tramo
    {
       #region Atributos

        public int id { get; set; }
        public decimal idRecorrido { get; set; }
        public string id_origen { get; set; }
        public string destino { get; set; }
        public int orden { get; set; }
        public decimal precio { get; set; }
        

        #endregion

        #region Constructores

        public Tramo(int id, decimal idRecorrido, string id_origen, string destino, int orden, decimal precio)
        {
            this.id = id;
            this.idRecorrido = idRecorrido;
            this.id_origen = id_origen;
            this.destino = destino;
            this.orden = orden;
            this.precio = precio;
         
        }

        public Tramo(string origen, string destino, int precio)
        {
            this.id_origen = origen;
            this.destino = destino;
            this.precio = precio;
        }
        public Tramo( ){
        }

        #endregion

        #region Metodos

        public void crearTramo(string id_origen, string destino, int precio)
        {

            this.id_origen = id_origen;
            this.destino = destino;
            this.precio = precio;
        }

        public void eliminarTramo(string origen, string destino, decimal precio)
        {
           
     
        }

        #endregion

    }



}

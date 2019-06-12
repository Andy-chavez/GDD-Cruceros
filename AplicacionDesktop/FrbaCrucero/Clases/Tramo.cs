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

        public string id { get; set; }
        public string idRecorrido { get; set; }
        public Puerto origen { get; set; }
        public Puerto destino { get; set; }
        public int precio { get; set; }
        

        #endregion

        #region Constructores

        public Tramo(string id,string idRecorrido, Puerto origen, Puerto destino, int precio)
        {
            this.id = id;
            this.idRecorrido = idRecorrido;
            this.origen = origen;
            this.destino = destino;
            this.precio = precio;
         
        }

        public Tramo(Puerto origen, Puerto destino, int precio)
        {
            this.origen = origen;
            this.destino = destino;
            this.precio = precio;
        }
        public Tramo( ){
        }

        #endregion

        #region Metodos

        public void crearTramo(Puerto origen, Puerto destino, int precio) {

            BaseDeDato.ejecutarSP("LEISTE_EL_CODIGO?.crearTramo", "@idRecorrido", "@origen", origen, "@destino", destino,"@orden","@precio",precio);
            this.origen = origen;
            this.destino = destino;
            this.precio = precio;
        }

        public void eliminarTramo(Puerto origen, Puerto destino, int precio)
        {
            BaseDeDato.ejecutarSP("LEISTE_EL_CODIGO?.eliminarTramo", "@origen", origen, "@destino", destino, "@orden", "@precio", precio);
     
        }

        #endregion

    }



}

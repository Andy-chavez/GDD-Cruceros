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

        public decimal id { get; set; }
        public Puerto origen { get; set; }
        public Puerto destino { get; set; }
        public string estado { get; set; }
        public List<Tramo> tramos { get; set; }


        #endregion

        BaseDeDato bd = new BaseDeDato();

        #region Constructores

        public Recorrido(decimal id, Puerto origen, Puerto destino, string estado, List<Tramo> tramos)
        {
            this.id = id;
            this.origen = origen;
            this.destino = destino;
            this.estado = estado;
            this.tramos = tramos;

        }
        public Recorrido()
        {
        }



        #endregion
        public void darDeBaja(decimal id)
        {
            try
            {
                bd.conectar();
                bd.crearSP("[LEISTE_EL_CODIGO?].modificarCrucero");
                bd.setearParametroPorValor("id_crucero", id);
                bd.ejecutarSP();
            }
            catch (Exception excepcion)
            {

                bd.ventanaErrorBD(excepcion);
            }
            bd.desconectar();

        }

        public void modificarRecorrido(decimal id, string origen, string destino)
        {
            try
            {
                bd.conectar();
                bd.crearSP("[LEISTE_EL_CODIGO?].modificarRecorrido");
                bd.setearParametroPorValor("id_crucero", id);
                bd.ejecutarSP();
            }
            catch (Exception excepcion)
            {

                bd.ventanaErrorBD(excepcion);
            }
            bd.desconectar();

        }
        public void crearRecorrido(string primerOrigen, string primerDestino)
        {
            try
            {
                bd.conectar();
                bd.crearSP("[LEISTE_EL_CODIGO?].crearRecorrido");
                bd.setearParametroPorValor("origen", primerOrigen);
                bd.setearParametroPorValor("destino", primerDestino);
                bd.ejecutarSP();
            }
            catch (Exception excepcion)
            {

                bd.ventanaErrorBD(excepcion);
            }
            bd.desconectar();

        }

    }

}


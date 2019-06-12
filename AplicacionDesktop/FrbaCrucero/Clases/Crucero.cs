using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    
    class Crucero
    {
        BaseDeDato bd = new BaseDeDato();

        #region Atributos

        public string id { get; set; }
        public string idFabricante { get; set; }
        public string modelo { get; set; }
        public bool bajaPorFueraDeServicio  { get; set; }
        public bool bajaPorVidaUtil { get; set; }
        public int cantCabinas { get; set; }
        public DateTime fechaFechaBajaPorFueraDesServicio { get; set; }
        public DateTime fechaBajaPorVidaUtil { get; set; }
        public DateTime fechaReinicioDeServicio { get; set; }
        public DateTime fechaBajaDefinitiva { get; set; }

        #endregion

        #region Constructores

        public Crucero(string id, string idFabricante, string modelo, bool bajaPorFueraDeServicio, bool bajaPorVidaUtil, int cantCabinas , DateTime fechaFechaBajaPorFueraDesServicio, DateTime fechaBajaPorVidaUtil, DateTime fechaReinicioDeServicio, DateTime fechaBajaDefinitiva)
        {
            this.id = id;
            this.idFabricante = idFabricante;
            this.modelo = modelo;
            this.bajaPorFueraDeServicio = bajaPorFueraDeServicio;
            this.bajaPorVidaUtil = bajaPorVidaUtil;
            this.cantCabinas = cantCabinas;
            this.fechaFechaBajaPorFueraDesServicio = fechaFechaBajaPorFueraDesServicio;
            this.fechaBajaPorVidaUtil = fechaBajaPorVidaUtil;
            this.fechaReinicioDeServicio = fechaReinicioDeServicio;
            this.fechaBajaDefinitiva = fechaBajaDefinitiva;
           
        }

        public Crucero(string id, string idFabricante, string modelo)
        {
            this.id = id;
            this.idFabricante = idFabricante;
            this.modelo = modelo;
        }
        public Crucero()
        {          
        }

        #endregion


        public void crearCrucero(string id, string idFabricante, string modelo, int cantCabinas)
        {

            this.id = id;
            this.idFabricante = idFabricante;
            this.modelo = modelo;
            this.cantCabinas = cantCabinas;
            try
            {
                bd.conectar();
                bd.crearSP("[LEISTE_EL_CODIGO?].cargarCrucero");
                bd.setearParametroPorValor("id_crucero", id);
                bd.setearParametroPorValor("id_fabricante", idFabricante);
                bd.setearParametroPorValor("modelo", modelo);
                bd.setearParametroPorValor("cantidadDeCabinas", cantCabinas);
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

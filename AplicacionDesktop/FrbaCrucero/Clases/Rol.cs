using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Rol
    {
        
        #region Atributos

        public string id { get; set; }
        public string nombre { get; set; }
        public bool bajaLogica { get; set; }
        public List< Funcionalidad> funcionalidades { get; set; }
        public BaseDeDato bd = new BaseDeDato();
        

        #endregion

        #region Constructores

        public Rol(string id, string nombre, bool bajaLogica,List< Funcionalidad> funcionalidades)
        {
            this.id = id;
            this.nombre = nombre;
            this.bajaLogica = bajaLogica;
            this.funcionalidades = funcionalidades;      
        }

        public Rol(string nombre, List<Funcionalidad> funcionalidades)
        {
            this.nombre = nombre;
            this.funcionalidades = funcionalidades;   
        }

        public Rol() { 
        }

        #endregion

        public void crearRol(String nombreRol, String idFuncionalidad)
        {
            BaseDeDato.ejecutarSP("LEISTE_EL_CODIGO?.CrearNuevoRol", "@nombreRol", nombreRol, "@idFuncionalidad", idFuncionalidad);
        }
        public void eliminarRol(String idRol)
        {

            BaseDeDato.ejecutarSP("LEISTE_EL_CODIGO?.darBajaRol", "@idRol", idRol);
        }
    }
}

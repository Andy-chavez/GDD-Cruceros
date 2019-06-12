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

        public void crearRol(String nombreRol, int idFuncionalidad)
        {
           this.nombre = nombreRol;

            try
            {
                bd.conectar();
                bd.crearSP("[LEISTE_EL_CODIGO?].crearNuevoRol");
                bd.setearParametroPorValor("id_crucero", nombreRol);
                bd.setearParametroPorValor("id_crucero", idFuncionalidad);
                bd.ejecutarSP();
            }
            catch (Exception excepcion)
            {

                bd.ventanaErrorBD(excepcion);
            }
            bd.desconectar();
        }
        public void eliminarRol(String idRol)
        {
            this.id = idRol;
            try
            {
                bd.conectar();
                bd.crearSP("[LEISTE_EL_CODIGO?].darBajaRol");
                bd.setearParametroPorValor("idRol", idRol);
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


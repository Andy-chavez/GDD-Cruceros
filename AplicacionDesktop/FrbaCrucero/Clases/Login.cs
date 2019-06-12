using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Login
    { 
        #region Atributos 

        public string mensaje { get; set; }
        public bool loginExitoso { get; set; }

        #endregion

        #region Constructores

        public Login()
        {

        }
        #endregion

        #region Metodos 

        public Login informarExito(string nombreUsuario)
        {
            loginExitoso = true;
            mensaje = nombreUsuario;
            return this;
        }

        public Login informarUsuarioInexistente()
        {
            loginExitoso = false;
            mensaje = "Usuario no existente, verificar el nombre de usuario.";
            return this;
        }

        public Login informarContraseniaIncorrecta()
        {
            loginExitoso = false;
            mensaje = "Contraseña erronea, intente nuevamente.";
            return this;
        }

        public Login informarBloqueo()
        {
            loginExitoso = false;
            mensaje = "Usuario deshabilitado.";
            return this;
        }
        #endregion
    }
}

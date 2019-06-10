using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data.SqlTypes;
using System.Data;
using System.Configuration;
using System.Windows.Forms;   
using FrbaCrucero;


namespace FrbaCrucero.Clases
{
    public class BaseDeDato
    {
        #region Atributos

        private static string configuracionConexionSql = @"Data Source= localhost\SQLSERVER2012; Persist Security Info=True;User ID=gdCruceros2019;Password=gd2019";

        public SqlConnection conexion = new SqlConnection(configuracionConexionSql); 

        #endregion

        #region Conexion

        public  SqlConnection obtenerConexion()
        {
            return conexion;
        }

        public  void conectar()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception excepcion)
            {
                ventanaErrorBD(excepcion);
            }
        }

        public  void desconectar()
        {
            conexion.Close();
        }

        public SqlCommand ejecutarConsulta(string consulta){

            SqlCommand command = new SqlCommand(consulta, this.obtenerConexion());
            try
            {
               command.ExecuteNonQuery();
            }
            catch (Exception excepcion)
            {
                ventanaErrorBD(excepcion);
            }
            return command;
        }


        public static void ventanaErrorBD(Exception excepcion)
        {

            MessageBox.Show("ERROR EN LA BASE DE DATOS:\n" + excepcion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Consultas

        

  
        #endregion 
    }
}

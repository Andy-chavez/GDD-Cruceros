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

        public static SqlConnection conexion = new SqlConnection(configuracionConexionSql); 

        #endregion

        #region Conexion

        public  SqlConnection obtenerConexion()
        {
            return conexion;
        }

        public static void conectar()
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

        public static void desconectar()
        {
            conexion.Close();
        }

      

        public static void ventanaErrorBD(Exception excepcion)
        {

            MessageBox.Show("ERROR EN LA BASE DE DATOS:\n" + excepcion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Consultas

        public static int ejecutarConsulta(string nombreConsulta)
        {
            SqlCommand consulta = new SqlCommand(nombreConsulta, conexion);

            int resultado = 0;
            conectar();
            try
            {
                resultado = consulta.ExecuteNonQuery();
            }
            catch (Exception excepcion)
            {
                ventanaErrorBD(excepcion);
            }
            desconectar();
            return resultado;
        }

        public static DataSet obtenerDataSet(SqlCommand consulta)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta);
                dataAdapter.Fill(dataSet);
            }
            catch (Exception excepcion)
            {
                ventanaErrorBD(excepcion);
            }
            return dataSet;
        }

        public static DataTable obtenerTabla(SqlCommand consulta)
        {
            DataSet dataSet = obtenerDataSet(consulta);
            DataTable tabla = dataSet.Tables[0];
            return tabla;
        }


        #endregion

        #region Store Procider

        public static void ejecutarSP(params object[] args)
        {
            SqlConnection nuevaConexion = conexion;
            SqlCommand cmd = new SqlCommand(args[0].ToString(), nuevaConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < args.Length - 2; i++)
            {
                cmd.Parameters.AddWithValue(args[i + 1] as string, args[i + 2]);
                i++;
            }
            nuevaConexion.Open();
            cmd.ExecuteReader();
        }

        public  int obtenerIntDelSP(params object[] args)
        {
            int respuesta = 0;
            try
            {
                SqlConnection coneccion = conexion;
                SqlCommand command = new SqlCommand(args[0].ToString(), coneccion);
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 1; i < args.Length - 2; i++)
                {
                    command.Parameters.AddWithValue(args[i + 1] as string, args[i + 2]);
                    i++;
                }
                SqlParameter resultado = new SqlParameter(args[1].ToString(), SqlDbType.Int);
                resultado.Direction = ParameterDirection.Output;
                command.Parameters.Add(resultado);
                coneccion.Open();
                command.ExecuteReader();
                respuesta = Convert.ToInt32(resultado.Value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "FrbaCruceros");
            }
            return respuesta;
        }

        
  
        #endregion 
    }
}

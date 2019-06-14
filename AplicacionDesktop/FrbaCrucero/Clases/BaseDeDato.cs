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

        SqlCommand sp;

        private static string configuracionConexionSql = @"Data Source= localhost\SQLSERVER2012; Persist Security Info=True;User ID=gdCruceros2019;Password=gd2019";

        public static SqlConnection conexion = new SqlConnection(configuracionConexionSql); 

        #endregion

        #region Conexion

        public  SqlConnection obtenerConexion()
        {
            return conexion;
        }

        public void conectar()
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

        public void desconectar()
        {
            conexion.Close();
        }

      

        public  void ventanaErrorBD(Exception excepcion)
        {

            MessageBox.Show("ERROR EN LA BASE DE DATOS:\n" + excepcion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Consultas

        public static SqlCommand crearConsulta(string nombreConsulta)
        {
            return new SqlCommand(nombreConsulta, conexion);        
        }

        public void ejecutarConsulta(string nombreConsulta)
        {
            SqlCommand consulta = new SqlCommand(nombreConsulta, conexion);
            try
            {
                conectar();
                consulta.ExecuteNonQuery();
            }
            catch (Exception excepcion)
            {
                ventanaErrorBD(excepcion);
            }
            desconectar();
        }

        public void ejecutarConsultaSinResultado(SqlCommand consulta)
        {
            conectar();
            consulta.ExecuteNonQuery();
            desconectar();
        }
        public int ejecutarConsultaDevuelveInt(SqlCommand consulta)
        {
            conectar();
            int resultado= consulta.ExecuteNonQuery();
            desconectar();
            return resultado;
        }
        public int obtenerIntDeConsulta(string nombreConsulta)
        {
            SqlCommand consulta = new SqlCommand(nombreConsulta, conexion);
            int entero = 0;
            conectar();
            entero = consulta.ExecuteNonQuery();
            desconectar();
            return entero;
        }


        public  DataSet obtenerDataSet(SqlCommand consulta)
        {     
            DataSet dataSet = new DataSet(); 
            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta);
            dataAdapter.Fill(dataSet);    
            return dataSet;
        }

        public  DataTable obtenerDataTable(SqlCommand consulta)
        {
            DataSet dataSet = obtenerDataSet(consulta);
            DataTable tabla = dataSet.Tables[0];
            return tabla;
        }

        public  List<string> obtenerListaDeDatos(SqlCommand consulta)
        {
            DataTable tabla = obtenerDataTable(consulta);
            List<string> columna = new List<string>();
            if (tabla.Rows.Count > 0)
                foreach (DataRow fila in tabla.Rows)
                    columna.Add(fila[0].ToString());
            return columna;
        }


        #endregion

        #region Store Procider

        public void crearSP(string nombreConsulta) {

            SqlCommand sp = new SqlCommand(nombreConsulta, conexion);
            sp.CommandType = CommandType.StoredProcedure;
        }


        public void setearParametroPorValor(string nombre, object valor)
        {
            sp.Parameters.AddWithValue(nombre, valor);
        }

        public void setearParametroPorReferencia(string nombre, SqlDbType tipoDato)
        {
            sp.Parameters.Add(new SqlParameter(nombre, tipoDato));
            sp.Parameters[nombre].Direction = ParameterDirection.Output;
        }

        public int ejecutarSP()
        {
            try
            {
                sp.Parameters.Add("@ReturnVal", SqlDbType.Int);
                sp.Parameters["@ReturnVal"].Direction = ParameterDirection.ReturnValue;
                sp.ExecuteNonQuery();
                return Convert.ToInt32(sp.Parameters["@ReturnVal"].Value);

            }
            catch (Exception exception)
            {
                ventanaErrorBD(exception);
                return -1;
            }
        }

        
  
        #endregion 
    }
}

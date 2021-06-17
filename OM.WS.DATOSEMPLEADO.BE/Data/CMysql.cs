using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySqlConnector;

namespace OM.WS.DATOSEMPLEADO.BE.Data
{
    public class CMysql
    {
        private String Conexion()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
        }

        public DataSet EjecutarSQL_DS(String sSQL)
        {
            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cn = new MySqlConnection(Conexion());
                cmd = new MySqlCommand(sSQL, cn);
                cmd.CommandType = CommandType.Text;
                //Cmnd.CommandTimeout = 800
                cn.Open();
                da.SelectCommand = cmd;
                da.Fill(ds);
                int tablas = ds.Tables.Count;
                int contador = 0;
                while (contador <= (tablas - 1))
                {
                    DataTable dt = ds.Tables[contador];
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr.IsNull(0))
                        {
                            dr.Delete();
                        }
                    }
                    dt.AcceptChanges();
                    contador = contador + 1;
                }
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
                da.Dispose();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyDreamFoam_BE;

namespace ProyDreamFoam_ADO
{
    public class UserSystemADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarUserSystem()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarUserSystem";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "UserSystem");
                return dts.Tables["UserSystem"];
                
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UserSystemBE ConsultarUserSystem(Int16 codUser)
        {
            try
            {
                UserSystemBE objUserSystem = new UserSystemBE();

                cnx.ConnectionString= MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarUserSystem";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codUser", codUser);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if(dtr.HasRows == true)
                {
                    dtr.Read();
                    objUserSystem.codUser = Convert.ToInt16(dtr["codUser"]);
                    objUserSystem.nomUser = dtr["nomUser"].ToString();
                    objUserSystem.passUser = dtr["passUser"].ToString();
                    objUserSystem.estdUser = Convert.ToInt16(dtr["estdUser"]);
                }
                dtr.Close();
                return objUserSystem;
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if(cnx.State == ConnectionState.Open) {
                cnx.Close();
                }
            }
        }
        public UserSystemBE ConsultarUserSystemNom(String nomUser)
        {
            try
            {
                UserSystemBE objUserSystem = new UserSystemBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarUserSystemNom";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nomUser", nomUser);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUserSystem.codUser = Convert.ToInt16(dtr["codUser"]);
                    objUserSystem.nomUser = dtr["nomUser"].ToString();
                    objUserSystem.passUser = dtr["passUser"].ToString();
                    objUserSystem.estdUser = Convert.ToInt16(dtr["estdUser"]);
                }
                dtr.Close();
                return objUserSystem;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public UserSystemBE ValidarUserSystem(String nomUser,String passUser)
        {
            try
            {
                UserSystemBE objUserSystem = new UserSystemBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ValidarUserSystem";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nomUser", nomUser);
                cmd.Parameters.AddWithValue("@passUser", passUser);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUserSystem.codUser = Convert.ToInt16(dtr["codUser"]);
                    objUserSystem.nomUser = dtr["nomUser"].ToString();
                    objUserSystem.passUser = dtr["passUser"].ToString();
                    objUserSystem.estdUser = Convert.ToInt16(dtr["estdUser"]);
                }
                dtr.Close();
                return objUserSystem;
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}

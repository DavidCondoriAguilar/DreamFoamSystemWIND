using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyDreamFoam_BE;

namespace ProyDreamFoam_ADO
{
    public class HorarioADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarHorarios()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarHorarios";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Horarios");
                return dts.Tables["Horarios"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public HorarioBE ConsultarHorario(Int32 codigo)
        {
            try
            {
                HorarioBE objHorarioBE = new HorarioBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarHorario";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codHorario", codigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objHorarioBE.codHorario = Convert.ToInt32(dtr["codHorario"]);
                    objHorarioBE.desHorario = dtr["desHorario"].ToString();
                    objHorarioBE.ingLUN = Convert.ToDateTime(dtr["ingLUN"].ToString());
                    objHorarioBE.salLUN = Convert.ToDateTime(dtr["salLUN"].ToString());
                    objHorarioBE.ingMAR = Convert.ToDateTime(dtr["ingMAR"].ToString());
                    objHorarioBE.salMAR = Convert.ToDateTime(dtr["salMAR"].ToString());
                    objHorarioBE.ingMIE = Convert.ToDateTime(dtr["ingMIE"].ToString());
                    objHorarioBE.salMIE = Convert.ToDateTime(dtr["salMIE"].ToString());
                    objHorarioBE.ingJUE = Convert.ToDateTime(dtr["ingJUE"].ToString());
                    objHorarioBE.salJUE = Convert.ToDateTime(dtr["salJUE"].ToString());
                    objHorarioBE.ingVIE = Convert.ToDateTime(dtr["ingVIE"].ToString());
                    objHorarioBE.salVIE = Convert.ToDateTime(dtr["salVIE"].ToString());
                    objHorarioBE.ingSAB = Convert.ToDateTime(dtr["ingSAB"].ToString());
                    objHorarioBE.salSAB = Convert.ToDateTime(dtr["salSAB"].ToString());
                    objHorarioBE.ingDOM = Convert.ToDateTime(dtr["ingDOM"].ToString());
                    objHorarioBE.salDOM = Convert.ToDateTime(dtr["salDOM"].ToString());
                    objHorarioBE.refriger = Convert.ToInt32(dtr["refriger"]);
                    objHorarioBE.tolernc = Convert.ToInt32(dtr["tolernc"]);
                    objHorarioBE.diaDesc = Convert.ToInt16(dtr["diaDesc"]);

                }

                dtr.Close();
                return objHorarioBE;

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

        public Boolean InsertarHorario(HorarioBE objHorarioBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarHorario";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@desHorario", objHorarioBE.desHorario);
                cmd.Parameters.AddWithValue("@ingLUN", objHorarioBE.ingLUN);
                cmd.Parameters.AddWithValue("@salLUN", objHorarioBE.salLUN);
                cmd.Parameters.AddWithValue("@ingMAR", objHorarioBE.ingMAR);
                cmd.Parameters.AddWithValue("@salMAR", objHorarioBE.salMAR);
                cmd.Parameters.AddWithValue("@ingMIE", objHorarioBE.ingMIE);
                cmd.Parameters.AddWithValue("@salMIE", objHorarioBE.salMIE);
                cmd.Parameters.AddWithValue("@ingJUE", objHorarioBE.ingJUE);
                cmd.Parameters.AddWithValue("@salJUE", objHorarioBE.salJUE);
                cmd.Parameters.AddWithValue("@ingVIE", objHorarioBE.ingVIE);
                cmd.Parameters.AddWithValue("@salVIE", objHorarioBE.salVIE);
                cmd.Parameters.AddWithValue("@ingSAB", objHorarioBE.ingSAB);
                cmd.Parameters.AddWithValue("@salSAB", objHorarioBE.salSAB);
                cmd.Parameters.AddWithValue("@ingDOM", objHorarioBE.ingDOM);
                cmd.Parameters.AddWithValue("@salDOM", objHorarioBE.salDOM);
                cmd.Parameters.AddWithValue("@refriger", objHorarioBE.refriger);
                cmd.Parameters.AddWithValue("@tolernc", objHorarioBE.tolernc);
                cmd.Parameters.AddWithValue("@diaDesc", objHorarioBE.diaDesc);
                cmd.Parameters.AddWithValue("@usu_Reg", objHorarioBE.usu_Reg);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public Boolean ActualizarHorario(HorarioBE objHorarioBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarHorario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codHorario", objHorarioBE.codHorario);
                cmd.Parameters.AddWithValue("@desHorario", objHorarioBE.desHorario);
                cmd.Parameters.AddWithValue("@ingLUN", objHorarioBE.ingLUN);
                cmd.Parameters.AddWithValue("@salLUN", objHorarioBE.salLUN);
                cmd.Parameters.AddWithValue("@ingMAR", objHorarioBE.ingMAR);
                cmd.Parameters.AddWithValue("@salMAR", objHorarioBE.salMAR);
                cmd.Parameters.AddWithValue("@ingMIE", objHorarioBE.ingMIE);
                cmd.Parameters.AddWithValue("@salMIE", objHorarioBE.salMIE);
                cmd.Parameters.AddWithValue("@ingJUE", objHorarioBE.ingJUE);
                cmd.Parameters.AddWithValue("@salJUE", objHorarioBE.salJUE);
                cmd.Parameters.AddWithValue("@ingVIE", objHorarioBE.ingVIE);
                cmd.Parameters.AddWithValue("@salVIE", objHorarioBE.salVIE);
                cmd.Parameters.AddWithValue("@ingSAB", objHorarioBE.ingSAB);
                cmd.Parameters.AddWithValue("@salSAB", objHorarioBE.salSAB);
                cmd.Parameters.AddWithValue("@ingDOM", objHorarioBE.ingDOM);
                cmd.Parameters.AddWithValue("@salDOM", objHorarioBE.salDOM);
                cmd.Parameters.AddWithValue("@refriger", objHorarioBE.refriger);
                cmd.Parameters.AddWithValue("@tolernc", objHorarioBE.tolernc);
                cmd.Parameters.AddWithValue("@diaDesc", objHorarioBE.diaDesc);
                cmd.Parameters.AddWithValue("@usu_UltMod", objHorarioBE.usu_UltMod);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean EliminarHorario(Int32 codigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarHorario";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codHorario", codigo);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                //throw new Exception(x.Message);
                return false;
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

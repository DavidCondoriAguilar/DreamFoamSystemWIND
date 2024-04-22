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
    public class DiarioADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;
        
        public DataTable ListarDiario()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDiario";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Diario");
                return dts.Tables["Diario"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarDiario(DiarioBE objDiarioBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarDiario";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codDiar", objDiarioBE.codDiar);
                cmd.Parameters.AddWithValue("@fecha", objDiarioBE.fecha);
                cmd.Parameters.AddWithValue("@empleado", objDiarioBE.empleado);
                cmd.Parameters.AddWithValue("@horario", objDiarioBE.horario);
                cmd.Parameters.AddWithValue("@hIngreso", objDiarioBE.hIngreso);
                cmd.Parameters.AddWithValue("@hSalida", objDiarioBE.hSalida);
                cmd.Parameters.AddWithValue("@hora1", objDiarioBE.hora1);
                cmd.Parameters.AddWithValue("@hora2", objDiarioBE.hora2);
                cmd.Parameters.AddWithValue("@hora3", objDiarioBE.hora3);
                cmd.Parameters.AddWithValue("@hora4", objDiarioBE.hora4);
                cmd.Parameters.AddWithValue("@ingrTard", objDiarioBE.ingrTard);
                cmd.Parameters.AddWithValue("@exeRefr", objDiarioBE.exeRefr);
                cmd.Parameters.AddWithValue("@exeJornd", objDiarioBE.exeJornd);
                cmd.Parameters.AddWithValue("@observ", objDiarioBE.exeJornd);

                cmd.Parameters.AddWithValue("@usu_UltMod", objDiarioBE.usu_UltMod);

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


        public Boolean InsertarDiario(DiarioBE objDiarioBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarDiario";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@fecha", objDiarioBE.fecha);
                cmd.Parameters.AddWithValue("@empleado", objDiarioBE.empleado);
                cmd.Parameters.AddWithValue("@horario", objDiarioBE.horario);
                cmd.Parameters.AddWithValue("@hIngreso", objDiarioBE.hIngreso);
                cmd.Parameters.AddWithValue("@hSalida", objDiarioBE.hSalida);
                cmd.Parameters.AddWithValue("@hora1", objDiarioBE.hora1);
                cmd.Parameters.AddWithValue("@hora2", objDiarioBE.hora2);
                cmd.Parameters.AddWithValue("@hora3", objDiarioBE.hora3);
                cmd.Parameters.AddWithValue("@hora4", objDiarioBE.hora4);
                cmd.Parameters.AddWithValue("@ingrTard", objDiarioBE.ingrTard);
                cmd.Parameters.AddWithValue("@exeRefr", objDiarioBE.exeRefr);
                cmd.Parameters.AddWithValue("@exeJornd", objDiarioBE.exeJornd);
                cmd.Parameters.AddWithValue("@observ", objDiarioBE.exeJornd);

                cmd.Parameters.AddWithValue("@usu_UltMod", objDiarioBE.usu_UltMod);

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

        public DiarioBE ConsultarDiario(Int32 codigo)
        {
            try
            {
                DiarioBE objDiarioBE = new DiarioBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarDiario";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codDiar", codigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objDiarioBE.codDiar = Convert.ToInt32(dtr["codDiar"]);
                    objDiarioBE.fecha = Convert.ToDateTime(dtr["fecha"]);
                    objDiarioBE.empleado = Convert.ToInt32(dtr["empleado"]);
                    objDiarioBE.horario = Convert.ToInt32(dtr["horario"]);
                    objDiarioBE.hIngreso = Convert.ToDateTime(dtr["hIngreso"]);
                    objDiarioBE.hSalida = Convert.ToDateTime(dtr["hSalida"]);
                    objDiarioBE.hora1 = Convert.ToDateTime(dtr["hora1"]);
                    objDiarioBE.hora2 = Convert.ToDateTime(dtr["hora2"]);
                    objDiarioBE.hora3 = Convert.ToDateTime(dtr["hora3"]);
                    objDiarioBE.hora4 = Convert.ToDateTime(dtr["hora4"]);
                    objDiarioBE.ingrTard = Convert.ToDateTime(dtr["ingrTard"]);
                    objDiarioBE.exeRefr = Convert.ToDateTime(dtr["exeRefr"]);
                    objDiarioBE.exeJornd = Convert.ToDateTime(dtr["exeJornd"]);
                    objDiarioBE.observ = dtr["observ"].ToString();
                }

                dtr.Close();
                return objDiarioBE;

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
        public DiarioBE ConsultarDiarioFecEmpl(DateTime fecha, Int32 empleado)
        {
            try
            {
                DiarioBE objDiarioBE = new DiarioBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarDiarioFecEmpl";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@empleado", empleado);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objDiarioBE.codDiar = Convert.ToInt32(dtr["codDiar"]);
                    objDiarioBE.fecha = Convert.ToDateTime(dtr["fecha"]);
                    objDiarioBE.empleado = Convert.ToInt32(dtr["empleado"]);
                    objDiarioBE.horario = Convert.ToInt32(dtr["horario"]);
                    objDiarioBE.hIngreso = Convert.ToDateTime(dtr["hIngreso"]);
                    objDiarioBE.hSalida = Convert.ToDateTime(dtr["hSalida"]);
                    objDiarioBE.hora1 = Convert.ToDateTime(dtr["hora1"]);
                    objDiarioBE.hora2 = Convert.ToDateTime(dtr["hora2"]);
                    objDiarioBE.hora3 = Convert.ToDateTime(dtr["hora3"]);
                    objDiarioBE.hora4 = Convert.ToDateTime(dtr["hora4"]);
                    objDiarioBE.ingrTard = Convert.ToDateTime(dtr["ingrTard"]);
                    objDiarioBE.exeRefr = Convert.ToDateTime(dtr["exeRefr"]);
                    objDiarioBE.exeJornd = Convert.ToDateTime(dtr["exeJornd"]);
                    objDiarioBE.observ = dtr["observ"].ToString();
                }

                dtr.Close();
                return objDiarioBE;

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

        public DiarioBE ConsultarDiarioFecEmplMin(DateTime fecha, Int32 empleado)
        {
            try
            {
                DiarioBE objDiarioBE = new DiarioBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarDiarioFecEmpl";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@empleado", empleado);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objDiarioBE.codDiar = Convert.ToInt32(dtr["codDiar"]);
                    objDiarioBE.fecha = Convert.ToDateTime(dtr["fecha"]);
                    objDiarioBE.empleado = Convert.ToInt32(dtr["empleado"]);
                    objDiarioBE.horario = Convert.ToInt32(dtr["horario"]);
                    if (dtr["hIngreso"] != DBNull.Value)
                    {
                        objDiarioBE.hIngreso = Convert.ToDateTime(dtr["hIngreso"].ToString());
                    }
                    else
                    {
                        objDiarioBE.hIngreso = DateTime.MinValue;
                    }

                    if (dtr["hSalida"] != DBNull.Value)
                    {
                        objDiarioBE.hSalida = Convert.ToDateTime(dtr["hSalida"].ToString());
                    }
                    else
                    {
                        objDiarioBE.hSalida = DateTime.MinValue; 
                    }

                    if (dtr["hora1"] != DBNull.Value)
                    {
                        objDiarioBE.hora1 = Convert.ToDateTime(dtr["hora1"].ToString());
                    }
                    else
                    {
                        objDiarioBE.hora1 = DateTime.MinValue;
                    }

                    if (dtr["hora2"] != DBNull.Value)
                    {
                        objDiarioBE.hora2 = Convert.ToDateTime(dtr["hora2"].ToString());
                    }
                    else
                    {
                        objDiarioBE.hora2 = DateTime.MinValue;
                    }
                    if (dtr["hora3"] != DBNull.Value)
                    {
                        objDiarioBE.hora3 = Convert.ToDateTime(dtr["hora3"].ToString());
                    }
                    else
                    {
                        objDiarioBE.hora3 = DateTime.MinValue;
                    }
                    if (dtr["hora4"] != DBNull.Value)
                    {
                        objDiarioBE.hora4 = Convert.ToDateTime(dtr["hora4"].ToString());
                    }
                    else
                    {
                        objDiarioBE.hora4 = DateTime.MinValue;
                    }
                }

                dtr.Close();
                return objDiarioBE;

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
    }

    
}

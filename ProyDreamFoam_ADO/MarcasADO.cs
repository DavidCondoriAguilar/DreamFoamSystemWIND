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
    public class MarcasADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarMarcas()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarMarcas";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Marcas");
                return dts.Tables["Marcas"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean InsertarMarca(MarcasBE objMarcaBE,Int32 horario,DateTime fecha)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarMarca";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@empleado", objMarcaBE.empleado);
                cmd.Parameters.AddWithValue("@horario", horario);
                cmd.Parameters.AddWithValue("@usu_Reg",objMarcaBE.usu_Reg);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@tipo", objMarcaBE.tipo);
                
                
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
        public MarcasBE ConsultarMarca(Int32 codigo)
        {
            try
            {
                MarcasBE objMarcaBE= new MarcasBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarMarca";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codMarc", codigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objMarcaBE.codMarc = Convert.ToInt32(dtr["codMarc"]);
                    objMarcaBE.empleado = Convert.ToInt32(dtr["empelado"]);
                    objMarcaBE.fecha = Convert.ToDateTime(dtr["fecha"]);
                    objMarcaBE.hora = Convert.ToDateTime(dtr["hora"]);
                    objMarcaBE.tipo = Convert.ToInt32(dtr["tipo"]);
                }

                dtr.Close();
                return objMarcaBE;

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

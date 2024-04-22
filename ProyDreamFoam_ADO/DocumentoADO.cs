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
    public class DocumentoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarDocumentos()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDocumentos";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Documentos");
                return dts.Tables["Documentos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DocumentoBE ConsultarDocumento(String codDoc)
        {
            try
            {
                DocumentoBE objDoc = new DocumentoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarDocumento";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codDoc", codDoc);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objDoc.codDoc = dtr["codDoc"].ToString(); ;
                    objDoc.descrCorta = dtr["descrCorta"].ToString();
                    objDoc.descrLarga = dtr["descrLarga"].ToString();
                    objDoc.longitud = Convert.ToInt16(dtr["longitud"]);
                }
                dtr.Close();
                return objDoc;
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

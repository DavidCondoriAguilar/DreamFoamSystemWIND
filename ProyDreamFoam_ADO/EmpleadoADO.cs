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
    public  class EmpleadoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarEmpleado()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleados";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleado");

                
                TraducirCodigos(dts.Tables["Empleado"], "tipoDoc", "nombreDocumento", "Tb_Documento","codDoc","descrCorta");
                TraducirCodigos(dts.Tables["Empleado"], "codArea", "nombreArea", "Tb_Area", "codArea", "nomArea");
                TraducirCodigos(dts.Tables["Empleado"], "codSede", "nombreSede", "Tb_Sede", "codSede", "nomSede");
                TraducirCodigos(dts.Tables["Empleado"], "codHorario", "nombreHorario", "Tb_Horario", "codHorario", "desHorario");
                TraducirCodigos(dts.Tables["Empleado"], "codCargo", "nombreCargo", "Tb_Cargo", "codCargo", "nomCargo");

                return dts.Tables["Empleado"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void TraducirCodigos(DataTable dataTable, string codigoColumna, string nombreColumna, string tablaTraduccion,string codTablaTrad, string valAcceso)
        {
            DataTable tablaTraduccionDT = ObtenerTablaTraduccion(tablaTraduccion);

            dataTable.Columns.Add(nombreColumna, typeof(string));

            foreach (DataRow row in dataTable.Rows)
            {
                int cod = Convert.ToInt32(row[codigoColumna]);

                DataRow[] foundRows = tablaTraduccionDT.Select($"{codTablaTrad} = {cod}");
                if (foundRows.Length > 0)
                {
                    string nombre = foundRows[0][valAcceso].ToString(); 
                    row[nombreColumna] = nombre;
                }
            }
        }

        private DataTable ObtenerTablaTraduccion(string nombreTabla)
        {
            using (SqlConnection connection = new SqlConnection(MiConexion.GetCnx()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"SELECT * FROM {nombreTabla}", connection))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public EmpleadoBE ConsultarEmpleado(Int32 codigo)
        {
            try
            {
                EmpleadoBE objEmpleadoBE = new EmpleadoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codEmpleado", codigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpleadoBE.codEmpleado = Convert.ToInt32(dtr["codEmpleado"]);
                    objEmpleadoBE.numroDoc = dtr["numroDoc"].ToString();
                    objEmpleadoBE.tipoDoc = dtr["tipoDoc"].ToString();
                    objEmpleadoBE.apellidos = dtr["apellidos"].ToString();
                    objEmpleadoBE.nombres = dtr["nombres"].ToString();

                    objEmpleadoBE.fecNacimiento = Convert.ToDateTime(dtr["fecNacimiento"]);

                    objEmpleadoBE.genero = dtr["genero"].ToString();
                    objEmpleadoBE.correo = dtr["correo"].ToString();
                    objEmpleadoBE.direccion = dtr["direccion"].ToString();
                    objEmpleadoBE.telefono = Convert.ToInt64(dtr["telefono"]);

                    objEmpleadoBE.fecIngreso = Convert.ToDateTime(dtr["fecIngreso"]);

                    objEmpleadoBE.codCargo = Convert.ToInt16(dtr["codCargo"]);
                    objEmpleadoBE.codArea = Convert.ToInt16(dtr["codArea"]);
                    objEmpleadoBE.codSede = Convert.ToInt16(dtr["codSede"]);
                    objEmpleadoBE.codHorario = Convert.ToInt16(dtr["codHorario"]);
                    if (dtr["foto"] != DBNull.Value)
                    {
                        objEmpleadoBE.foto = (byte[])dtr["foto"];
                    }
                    else
                    {
                        objEmpleadoBE.foto = new byte[0];
                    }
                    objEmpleadoBE.estado = Convert.ToInt16(dtr["estado"]);
                }

                dtr.Close();
                return objEmpleadoBE;

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

        public EmpleadoBE ConsultarEmpleadoCodDoc(Int32 codigo, String numroDoc)
        {
            try
            {
                EmpleadoBE objEmpleadoBE = new EmpleadoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleadoCodDoc";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codEmpleado", codigo);
                cmd.Parameters.AddWithValue("@numroDoc", numroDoc);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpleadoBE.codEmpleado = Convert.ToInt32(dtr["codEmpleado"]);
                    objEmpleadoBE.numroDoc = dtr["numroDoc"].ToString();
                    objEmpleadoBE.tipoDoc = dtr["tipoDoc"].ToString();
                    objEmpleadoBE.apellidos = dtr["apellidos"].ToString();
                    objEmpleadoBE.nombres = dtr["nombres"].ToString();

                    objEmpleadoBE.fecNacimiento = Convert.ToDateTime(dtr["fecNacimiento"]);

                    objEmpleadoBE.genero = dtr["genero"].ToString();
                    objEmpleadoBE.correo = dtr["correo"].ToString();
                    objEmpleadoBE.direccion = dtr["direccion"].ToString();
                    objEmpleadoBE.telefono = Convert.ToInt64(dtr["telefono"]);

                    objEmpleadoBE.fecIngreso = Convert.ToDateTime(dtr["fecIngreso"]);

                    objEmpleadoBE.codCargo = Convert.ToInt16(dtr["codCargo"]);
                    objEmpleadoBE.codArea = Convert.ToInt16(dtr["codArea"]);
                    objEmpleadoBE.codSede = Convert.ToInt16(dtr["codSede"]);
                    objEmpleadoBE.codHorario = Convert.ToInt16(dtr["codHorario"]);
                    if (dtr["foto"] != DBNull.Value)
                    {
                        objEmpleadoBE.foto = (byte[])dtr["foto"];
                    }
                    else
                    {
                        objEmpleadoBE.foto = new byte[0];
                    }
                    objEmpleadoBE.estado = Convert.ToInt16(dtr["estado"]);
                }

                dtr.Close();
                return objEmpleadoBE;

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

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEmpleado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@numroDoc", objEmpleadoBE.numroDoc);
                cmd.Parameters.AddWithValue("@tipoDoc", objEmpleadoBE.tipoDoc);
                cmd.Parameters.AddWithValue("@apellidos", objEmpleadoBE.apellidos);
                cmd.Parameters.AddWithValue("@nombres", objEmpleadoBE.nombres);
                
                cmd.Parameters.AddWithValue("@fecNacimiento", objEmpleadoBE.fecNacimiento);
                cmd.Parameters.AddWithValue("@genero", objEmpleadoBE.genero);
                cmd.Parameters.AddWithValue("@correo", objEmpleadoBE.correo);
                cmd.Parameters.AddWithValue("@direccion", objEmpleadoBE.direccion);
                cmd.Parameters.AddWithValue("@telefono", objEmpleadoBE.telefono);
                cmd.Parameters.AddWithValue("@fecIngreso", objEmpleadoBE.fecIngreso);
                cmd.Parameters.AddWithValue("@codCargo", objEmpleadoBE.codCargo);
                cmd.Parameters.AddWithValue("@codArea", objEmpleadoBE.codArea);
                cmd.Parameters.AddWithValue("@codSede", objEmpleadoBE.codSede);
                cmd.Parameters.AddWithValue("@codHorario", objEmpleadoBE.codHorario);
                cmd.Parameters.AddWithValue("@foto", objEmpleadoBE.foto);
                cmd.Parameters.AddWithValue("@usu_Reg", objEmpleadoBE.usu_Reg);
                cmd.Parameters.AddWithValue("@estado", objEmpleadoBE.estado);

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
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codEmpleado", objEmpleadoBE.codEmpleado);
                cmd.Parameters.AddWithValue("@numroDoc", objEmpleadoBE.numroDoc);
                cmd.Parameters.AddWithValue("@tipoDoc", objEmpleadoBE.tipoDoc);
                cmd.Parameters.AddWithValue("@apellidos", objEmpleadoBE.apellidos);
                cmd.Parameters.AddWithValue("@nombres", objEmpleadoBE.nombres);

                cmd.Parameters.AddWithValue("@fecNacimiento", objEmpleadoBE.fecNacimiento);
                cmd.Parameters.AddWithValue("@genero", objEmpleadoBE.genero);
                cmd.Parameters.AddWithValue("@correo", objEmpleadoBE.correo);
                cmd.Parameters.AddWithValue("@direccion", objEmpleadoBE.direccion);
                cmd.Parameters.AddWithValue("@telefono", objEmpleadoBE.telefono);
                cmd.Parameters.AddWithValue("@fecIngreso", objEmpleadoBE.fecIngreso);
                cmd.Parameters.AddWithValue("@codCargo", objEmpleadoBE.codCargo);
                cmd.Parameters.AddWithValue("@codArea", objEmpleadoBE.codArea);
                cmd.Parameters.AddWithValue("@codSede", objEmpleadoBE.codSede);
                cmd.Parameters.AddWithValue("@codHorario", objEmpleadoBE.codHorario);
                cmd.Parameters.AddWithValue("@foto", objEmpleadoBE.foto);
                cmd.Parameters.AddWithValue("@usu_UltMod", objEmpleadoBE.usu_UltMod);
                cmd.Parameters.AddWithValue("@estado", objEmpleadoBE.estado);

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
        public Boolean EliminarEmpleado(Int32 codigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEmpleado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codEmpleado", codigo);

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

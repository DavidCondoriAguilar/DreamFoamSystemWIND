using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyDreamFoam_ADO;
using ProyDreamFoam_BE;

namespace ProyDreamFoam_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();
        public DataTable ListarEmpleados()
        {
            return objEmpleadoADO.ListarEmpleado();
        }

        public EmpleadoBE ConsultarEmpleado(Int32 codigo) {
            return objEmpleadoADO.ConsultarEmpleado(codigo);
        }
        public EmpleadoBE ConsultarEmpleadoCodDoc(Int32 codigo, String doc)
        {
            return objEmpleadoADO.ConsultarEmpleadoCodDoc(codigo,doc);
        }

        public Boolean InsertarEmpleado(EmpleadoBE empleadoBE)
        {
            return objEmpleadoADO.InsertarEmpleado(empleadoBE);
        }

        public Boolean ActualizarEmpleado(EmpleadoBE empleadoBE)
        {
            return objEmpleadoADO.ActualizarEmpleado(empleadoBE);
        }

        public Boolean EliminarEmpleado(Int32 codigo)
        {
            return objEmpleadoADO.EliminarEmpleado(codigo);
        }
    }
}

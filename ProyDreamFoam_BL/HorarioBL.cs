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
    public class HorarioBL
    {
        HorarioADO objHorarioADO = new HorarioADO();   
        public DataTable ListarHorarios()
        {
            return objHorarioADO.ListarHorarios();
        }

        public HorarioBE ConsultarHorario(Int32 codHorario)
        {
            return objHorarioADO.ConsultarHorario(codHorario);
        }

        public Boolean InsertarHorario(HorarioBE objHorarioBE)
        {
            return objHorarioADO.InsertarHorario(objHorarioBE);
        }
        public Boolean ActualizarHorario(HorarioBE objHorarioBE)
        {
            return objHorarioADO.ActualizarHorario(objHorarioBE);
        }

        public Boolean EliminarHorario(Int32 cod)
        {
            return objHorarioADO.EliminarHorario(cod);
        }
    }
}

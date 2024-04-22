using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

using ProyDreamFoam_ADO;
using ProyDreamFoam_BE;

namespace ProyDreamFoam_BL
{
    public class DiarioBL
    {
        DiarioADO objDiarioADO = new DiarioADO();
        public DataTable ListarDiario()
        {
            return objDiarioADO.ListarDiario();
        }

        public Boolean ActualizarDiario(DiarioBE objDiarioBE)
        {
            return objDiarioADO.ActualizarDiario(objDiarioBE);
        }
        public Boolean InsertarDiario(DiarioBE objDiarioBE)
        {
            return objDiarioADO.InsertarDiario(objDiarioBE);
        }
        public DiarioBE ConsultarDiario(Int32 codigo)
        {
            return objDiarioADO.ConsultarDiario(codigo);
        } 

        public DiarioBE ConsultarDiarioFecEmpl(DateTime fec, Int32 empleado)
        {
            return objDiarioADO.ConsultarDiarioFecEmpl(fec, empleado);
        }
        public DiarioBE ConsultarDiarioFecEmplMin(DateTime fec, Int32 empleado)
        {
            return objDiarioADO.ConsultarDiarioFecEmplMin(fec, empleado);
        }
    }
}

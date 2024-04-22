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
    public class SedeBL
    {
        SedeADO objSedeADO = new SedeADO();
        public DataTable ListarSede()
        {
            return objSedeADO.ListarSede();
        }
    }
}

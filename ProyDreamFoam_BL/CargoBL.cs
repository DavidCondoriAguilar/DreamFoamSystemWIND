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
    public class CargoBL
    {
        CargoADO objCargoADO = new CargoADO();  
        public DataTable ListarCargo()
        {
            return objCargoADO.ListarCargo();
        }
    }
}

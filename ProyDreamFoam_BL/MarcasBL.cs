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
    public class MarcasBL
    {
        MarcasADO objMarcasADO = new MarcasADO();

        public DataTable ListarMarcas()
        {
            return objMarcasADO.ListarMarcas();
        }

        public Boolean InsertarMarca(MarcasBE objMarcaBE, Int32 horario,DateTime fecha)
        {
            return objMarcasADO.InsertarMarca(objMarcaBE,horario,fecha);
        }

        public MarcasBE ConsultarMarca(Int32 codMarca)
        {
            return objMarcasADO.ConsultarMarca(codMarca);
        }
    }
}

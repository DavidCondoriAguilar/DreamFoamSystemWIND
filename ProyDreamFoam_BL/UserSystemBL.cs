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
    public class UserSystemBL
    {
        UserSystemADO objUserSystemADO = new UserSystemADO();

        public DataTable ListarUserSystem()
        {
            return objUserSystemADO.ListarUserSystem();
        }

        public UserSystemBE ConsultarUserSystem(Int16 codUser) 
        {
            return objUserSystemADO.ConsultarUserSystem(codUser);
        }
        public UserSystemBE ConsultarUserSystemNom(String nomUser)
        {
            return objUserSystemADO.ConsultarUserSystemNom(nomUser);
        }
        public UserSystemBE ValidarUserSystem(String nomUser, String passUser)
        {
            return objUserSystemADO.ValidarUserSystem(nomUser, passUser);
        }
    }
}

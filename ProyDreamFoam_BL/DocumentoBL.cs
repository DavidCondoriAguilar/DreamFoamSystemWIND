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
    public class DocumentoBL
    {
        DocumentoADO objDocumentoADO = new DocumentoADO();

        public DataTable listarDocumentos()
        {
            return objDocumentoADO.ListarDocumentos();
        }

        public DocumentoBE ConsultarDocumento(String codDoc)
        {
            return objDocumentoADO.ConsultarDocumento(codDoc);
        }
    }
}

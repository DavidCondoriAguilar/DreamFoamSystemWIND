using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyDreamFoam_BE
{
    public class MarcasBE
    {   
        public Int32 codMarc {  get; set; }
        public Int32 empleado { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set;}
        public Int32 tipo { get; set; }
        public DateTime fec_Reg { get; set; }
        public string usu_Reg { get; set; }
        public DateTime fec_UltMod {  get; set; }
        public String usu_UltMod { get;set; }

    }
}

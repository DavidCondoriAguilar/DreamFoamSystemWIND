using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyDreamFoam_BE
{
    public class DiarioBE
    {
        public Int32 codDiar {  get; set; }
        public DateTime fecha { get; set; }
        public Int32 empleado { get; set; }
        public Int32 horario { get; set; }
        public DateTime hIngreso { get; set; }
        public DateTime hSalida { get; set; }
        public DateTime hora1 { get; set; }
        public DateTime hora2 { get; set; }
        public DateTime hora3 { get; set; }
        public DateTime hora4 { get; set; }
        public DateTime ingrTard { get; set; }
        public DateTime exeRefr { get; set; }
        public DateTime exeJornd { get; set; }
        public String observ {  get; set; }
        public DateTime fec_Reg { get; set; }
        public string usu_Reg { get; set; }
        public DateTime fec_UltMod { get; set; }
        public String usu_UltMod { get; set; }


    }
}

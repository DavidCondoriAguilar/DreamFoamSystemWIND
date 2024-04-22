using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyDreamFoam_GUI
{
    
    public partial class AsistenciaModificar : Form
    {
        public string nomUser;
        public int codDiario;
        public AsistenciaModificar(string nomUser, int codDiario)
        {
            InitializeComponent();
            this.codDiario = codDiario;
            this.nomUser = nomUser;
        }


    }
}

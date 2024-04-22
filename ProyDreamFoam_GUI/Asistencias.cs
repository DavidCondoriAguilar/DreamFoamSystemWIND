using ProyDreamFoam_BE;
using ProyDreamFoam_BL;
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
    public partial class Asistencias : Form
    {
        DiarioBL objDiarioBL = new DiarioBL();

        AsistenciaModificar formAsistenciaModificar;

        public string nomUser;
        int codDiario;
        DataView dtv;
        public Asistencias(string nomUser)
        {
            InitializeComponent();
            this.nomUser = nomUser;
        }

        private void cargardtgDiario()
        {
            dtv = new DataView(objDiarioBL.ListarDiario());
            dtgDiario.DataSource = dtv;
            txtNumReg.Text = dtgDiario.Rows.Count.ToString();
        }
        private void filtrarDatosEmpleado(String strFilter)
        {
            dtv = new DataView(objDiarioBL.ListarDiario());
            dtv.RowFilter = $"CONVERT(empleado, 'System.String') LIKE '%{strFilter}%'";
            dtgDiario.DataSource = dtv;
            txtNumReg.Text = dtgDiario.Rows.Count.ToString();
        }
        private void Asistencias_Load(object sender, EventArgs e)
        {
            cargardtgDiario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (formAsistenciaModificar == null && codDiario != 0)
            {
                formAsistenciaModificar = new AsistenciaModificar(nomUser, codDiario);
                formAsistenciaModificar.FormClosed += new FormClosedEventHandler(EstaCerradoDiarioModificar);
                formAsistenciaModificar.BringToFront();
                formAsistenciaModificar.ShowDialog();
                cargardtgDiario();
            }
            else if (codDiario == 0)
            {
                MessageBox.Show("Por favor, haga click en algun valor de la tabla para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                formAsistenciaModificar.BringToFront();
            }
        }

        private void EstaCerradoDiarioModificar(object sender, EventArgs e)
        {
            formAsistenciaModificar = null;
        }

        private void txtFiltCodEmple_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filtrarDatosEmpleado(txtFiltCodEmple.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltCodEmple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgDiario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDiario.Rows.Count > 0)
            {
                codDiario = int.Parse(dtgDiario.SelectedCells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargardtgDiario();
        }

        private void dtgDiario_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            string val = (dtgDiario.Rows[e.RowIndex].Cells[12].Value).ToString();

            if (val == "TARDE")
            {
                dtgDiario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
               
            }
            else if (val == "PUNTUAL")
            {
                dtgDiario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

            }


        }
    }
}

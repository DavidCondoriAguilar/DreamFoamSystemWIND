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
    public partial class Horarios : Form
    {
        HorarioBL objHorarioBL = new HorarioBL();
        HorarioModificar formHorarioModificar;
        HorarioNuevo formHorarioNuevo;

        int codHorario;
        public String nomUser;
        DataView dtv;
        public Horarios(String nomUser)
        {
            InitializeComponent();
            this.nomUser = nomUser;
        }
        private void cargardtgHorarios()
        {
            dtv = new DataView(objHorarioBL.ListarHorarios());
            dtgHorarios.DataSource = dtv;
            txtNumReg.Text = dtgHorarios.Rows.Count.ToString();
        }

        private void filtrarDatosNombre(String strFilter)
        {
            dtv = new DataView(objHorarioBL.ListarHorarios());
            dtv.RowFilter = "desHorario like '%" + strFilter + "%'";
            dtgHorarios.DataSource = dtv;
            txtNumReg.Text = dtgHorarios.Rows.Count.ToString();
        }
        private void Horarios_Load(object sender, EventArgs e)
        {
            cargardtgHorarios();
        }

        private void txtHorNom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filtrarDatosNombre(txtHorNom.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void dtgHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgHorarios.Rows.Count > 0)
            {
                codHorario = int.Parse(dtgHorarios.SelectedCells[0].Value.ToString());
            }
        }

        private void dtgHorarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (this.dtgHorarios.Columns[e.ColumnIndex].Name == "ingLUNDataGridViewTextBoxColumn")
            //{
            //    if (e.Value != null && e.Value != DBNull.Value)
            //    {
            //        DateTime valorFecha = (DateTime)e.Value;

            //        if (valorFecha.TimeOfDay == TimeSpan.Zero)
            //        {
            //            e.CellStyle.ForeColor = Color.Red;
            //        }
            //    }
            //}
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (formHorarioModificar == null && codHorario != 0)
            {
                formHorarioModificar = new HorarioModificar(nomUser,codHorario);
                formHorarioModificar.FormClosed += new FormClosedEventHandler(EstaCerradoHorarioModificar);
                formHorarioModificar.BringToFront();
                formHorarioModificar.ShowDialog();
                cargardtgHorarios();
            }
            else if (codHorario == 0)
            {
                MessageBox.Show("Por favor, haga click en algun valor de la tabla para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                formHorarioModificar.BringToFront();
            }
        }
        void EstaCerradoHorarioModificar(object sender, EventArgs e)
        {
            formHorarioModificar = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (formHorarioNuevo== null)
            {
                formHorarioNuevo = new HorarioNuevo(nomUser);
                formHorarioNuevo.FormClosed += new FormClosedEventHandler(EstaCerradoHorarioNuevo);
                formHorarioNuevo.BringToFront();
                formHorarioNuevo.ShowDialog();
                cargardtgHorarios();
            }
            else
            {
                formHorarioNuevo.BringToFront();
            }
        }
        void EstaCerradoHorarioNuevo(object sender, EventArgs e)
        {
            formHorarioNuevo= null;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objHorarioBL.EliminarHorario(codHorario))
            {
                cargardtgHorarios();
                lblMensaje.Text = "Se elimino el horario correctamente.";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el horario. Puede ser que el horario ya se encuentre referenciado con algun registro.";
            }
        }
    }
}

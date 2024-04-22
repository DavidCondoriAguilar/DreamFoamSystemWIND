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
    public partial class HorarioModificar : Form
    {
        HorarioBE objHorarioBE;
        HorarioBL objHorarioBL = new HorarioBL();

        public string nomUser;
        public int codHorario;
        public HorarioModificar(string nomUser, int codHorario)
        {
            InitializeComponent();
            this.nomUser = nomUser;
            this.codHorario = codHorario;
        }

        private void HorarioModificar_Load(object sender, EventArgs e)
        {
            objHorarioBE = new HorarioBE();
            objHorarioBE = objHorarioBL.ConsultarHorario(Convert.ToInt32(codHorario));

            lblCodigo.Text = codHorario.ToString();
            txtNomHorar.Text = objHorarioBE.desHorario;
            txtRefrigr.Text = objHorarioBE.refriger.ToString();
            txtDiaDesc.Text = objHorarioBE.diaDesc.ToString();
            txtToler.Text = objHorarioBE.tolernc.ToString();

            dtpIngLUN.Value = objHorarioBE.ingLUN;
            dtpSalLUN.Value = objHorarioBE.salLUN;
            dtpIngMAR.Value = objHorarioBE.ingMAR;
            dtpSalMAR.Value = objHorarioBE.salMAR;
            dtpIngMIE.Value = objHorarioBE.ingMIE;
            dtpSalMIE.Value = objHorarioBE.salMIE;
            dtpIngJUE.Value = objHorarioBE.ingJUE;
            dtpSalJUE.Value = objHorarioBE.salJUE;
            dtpIngVIE.Value = objHorarioBE.ingVIE;
            dtpSalVIE.Value = objHorarioBE.salVIE;
            dtpIngSAB.Value = objHorarioBE.ingSAB;
            dtpSalSAB.Value = objHorarioBE.salSAB;
            dtpIngDOM.Value = objHorarioBE.ingDOM;
            dtpSalDOM.Value = objHorarioBE.salDOM;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomHorar.Text) ||
              string.IsNullOrWhiteSpace(txtRefrigr.Text) ||
              string.IsNullOrWhiteSpace(txtDiaDesc.Text) ||
              string.IsNullOrWhiteSpace(txtToler.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                objHorarioBE = new HorarioBE();
                objHorarioBE.codHorario = Convert.ToInt32(codHorario);
                objHorarioBE.desHorario = txtNomHorar.Text;
                objHorarioBE.diaDesc = Convert.ToInt16(txtDiaDesc.Text);
                objHorarioBE.refriger = Convert.ToInt32(txtRefrigr.Text);
                objHorarioBE.tolernc = Convert.ToInt32(txtToler.Text);
                objHorarioBE.usu_UltMod = nomUser;

                objHorarioBE.ingLUN = dtpIngLUN.Value;
                objHorarioBE.salLUN = dtpSalLUN.Value;
                objHorarioBE.ingMAR = dtpIngMAR.Value;
                objHorarioBE.salMAR = dtpSalMAR.Value;
                objHorarioBE.ingMIE = dtpIngMIE.Value;
                objHorarioBE.salMIE = dtpSalMIE.Value;
                objHorarioBE.ingJUE = dtpIngJUE.Value;
                objHorarioBE.salJUE = dtpSalJUE.Value;
                objHorarioBE.ingVIE = dtpIngVIE.Value;
                objHorarioBE.salVIE = dtpSalVIE.Value;
                objHorarioBE.ingSAB = dtpIngSAB.Value;
                objHorarioBE.salSAB = dtpSalSAB.Value;
                objHorarioBE.ingDOM = dtpIngDOM.Value;
                objHorarioBE.salDOM = dtpSalDOM.Value;

                if (objHorarioBL.ActualizarHorario(objHorarioBE))
                {
                    MessageBox.Show("Se ingreso correctamente el horario.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el horario.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }
        }

        private void txtRefrigr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtToler_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRefrigr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtToler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiaDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

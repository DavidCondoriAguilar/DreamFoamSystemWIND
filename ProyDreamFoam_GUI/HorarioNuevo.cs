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
    public partial class HorarioNuevo : Form
    {
        HorarioBE objHorarioBE;
        HorarioBL objHorarioBL = new HorarioBL();
       
        public string nomUser;
        public HorarioNuevo(string nomUser)
        {
            InitializeComponent();
            this.nomUser = nomUser;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNomHorar.Text) ||
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
                objHorarioBE.desHorario = txtNomHorar.Text;
                objHorarioBE.diaDesc = Convert.ToInt16(txtDiaDesc.Text);
                objHorarioBE.refriger = Convert.ToInt32(txtRefrigr.Text);
                objHorarioBE.tolernc = Convert.ToInt32(txtToler.Text);
                objHorarioBE.usu_Reg = nomUser;

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

                if (objHorarioBL.InsertarHorario(objHorarioBE))
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
    }
}

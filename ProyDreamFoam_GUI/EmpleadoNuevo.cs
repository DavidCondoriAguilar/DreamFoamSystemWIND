using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyDreamFoam_BE;
using ProyDreamFoam_BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyDreamFoam_GUI
{
    public partial class EmpleadoNuevo : Form
    {
        EmpleadoBE objEmpleadoBE;
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();

        CargoBE objCargoBE = new CargoBE();
        CargoBL objCargoBL = new CargoBL();

        SedeBE objSedeBE = new SedeBE();
        SedeBL objSedeBL = new SedeBL();

        AreaBE objAreaBE = new AreaBE();
        AreaBL objAreaBL = new AreaBL();

        DocumentoBE objDocumentoBE = new DocumentoBE();
        DocumentoBL objDocumentoBL = new DocumentoBL();

        HorarioBL objHorarioBL = new HorarioBL();
        public String nomUser;
        public EmpleadoNuevo(String nomUser)
        {
            InitializeComponent();
            this.nomUser = nomUser;
        }

        private void EmpleadoNuevo_Load(object sender, EventArgs e)
        {
            cmbArea.DataSource = objAreaBL.ListarArea();
            cmbArea.SelectedIndex = 0;
            cmbArea.DisplayMember = "nomArea";
            cmbArea.ValueMember = "codArea";


            cmbCargo.DataSource = objCargoBL.ListarCargo();
            cmbCargo.SelectedIndex = 0;
            cmbCargo.DisplayMember = "nomCargo";
            cmbCargo.ValueMember = "codCargo";

            cmbSede.DataSource = objSedeBL.ListarSede();
            cmbSede.SelectedIndex = 0;
            cmbSede.DisplayMember = "nomSede";
            cmbSede.ValueMember = "codSede";

            cmbTipoDoc.DataSource = objDocumentoBL.listarDocumentos();
            cmbTipoDoc.SelectedIndex = 0;
            cmbTipoDoc.DisplayMember = "descrLarga";
            cmbTipoDoc.ValueMember = "codDoc";

            cmbHorar.DataSource = objHorarioBL.ListarHorarios();
            cmbHorar.SelectedIndex = 0;
            cmbHorar.DisplayMember = "desHorario";
            cmbHorar.ValueMember = "codHorario";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNumDoc.Text) ||
                string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtApelld.Text) ||
                string.IsNullOrWhiteSpace(txtCorr.Text)
                )
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                objEmpleadoBE = new EmpleadoBE();
                objEmpleadoBE.tipoDoc = cmbTipoDoc.SelectedValue.ToString();
                objEmpleadoBE.numroDoc = txtNumDoc.Text;
                objEmpleadoBE.apellidos = txtApelld.Text;
                objEmpleadoBE.nombres = txtNom.Text;
                objEmpleadoBE.fecNacimiento = dtpFecNac.Value;
                objEmpleadoBE.genero = rdbMasculino.Checked ? "M" : "F";
                objEmpleadoBE.correo = txtCorr.Text;
                objEmpleadoBE.direccion = txtDirec.Text;
                if (txtTelf.Text == "")
                {
                    objEmpleadoBE.telefono = 0;
                }
                else
                {
                    objEmpleadoBE.telefono = Convert.ToInt64(txtTelf.Text);
                }
                objEmpleadoBE.fecIngreso = dtpFecIngreso.Value;
                objEmpleadoBE.codCargo = Convert.ToInt16(cmbCargo.SelectedValue);
                objEmpleadoBE.codArea = Convert.ToInt16(cmbArea.SelectedValue);
                objEmpleadoBE.codSede = Convert.ToInt16(cmbSede.SelectedValue);
                objEmpleadoBE.codHorario = Convert.ToInt16(cmbHorar.SelectedValue);


                if (imgFoto.Image == null)
                {
                    string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                    string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                    imgFoto.Image = Image.FromFile(fotosTempPath + "noimage.jpg");

                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                    imgFoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    objEmpleadoBE.foto = memoryStream.GetBuffer();
                }
                else
                {
                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                    imgFoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    objEmpleadoBE.foto = memoryStream.GetBuffer();
                }

                objEmpleadoBE.usu_Reg = nomUser;
                objEmpleadoBE.estado = 1;

                if (objEmpleadoBL.InsertarEmpleado(objEmpleadoBE))
                {
                    MessageBox.Show("Se ingreso correctamente el empleado.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el empleado.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngrFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                imgFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

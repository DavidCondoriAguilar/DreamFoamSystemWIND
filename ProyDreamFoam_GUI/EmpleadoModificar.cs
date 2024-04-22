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
    public partial class EmpleadoModificar : Form
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
        public int codEmpleado;
        public EmpleadoModificar(String nomUser, int codEmpleado)
        {
            InitializeComponent();
            this.nomUser = nomUser;
            this.codEmpleado = codEmpleado;
            lblCodigo.Text = codEmpleado.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

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
                objEmpleadoBE.codEmpleado = Convert.ToInt32(codEmpleado);
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

                objEmpleadoBE.usu_UltMod = nomUser;
                objEmpleadoBE.estado = 1;

                if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE))
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

        private void btnIngrFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                imgFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void EmpleadoModificar_Load(object sender, EventArgs e)
        {
            objEmpleadoBE = new EmpleadoBE();
            objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(Convert.ToInt32(codEmpleado));

            DataTable areas = new DataTable();
            areas = objAreaBL.ListarArea();
            cmbArea.DataSource = areas;
            DataRow[] filasAreas = areas.Select($"codArea = '{objEmpleadoBE.codArea}'");

            if (filasAreas.Length > 0)
            {
                cmbArea.SelectedIndex = areas.Rows.IndexOf(filasAreas[0]);
            }
            else
            {
                cmbArea.SelectedIndex = 0;
            }
            cmbArea.DisplayMember = "nomArea";
            cmbArea.ValueMember = "codArea";

            DataTable cargos = new DataTable();
            cargos = objCargoBL.ListarCargo();
            cmbCargo.DataSource = cargos;
            DataRow[] filasCargos = cargos.Select($"codCargo = '{objEmpleadoBE.codCargo}'");
            if (filasCargos.Length > 0)
            {
                cmbCargo.SelectedIndex = cargos.Rows.IndexOf(filasCargos[0]);
            }
            else
            {
                cmbCargo.SelectedIndex = 0;
            }
            cmbCargo.DisplayMember = "nomCargo";
            cmbCargo.ValueMember = "codCargo";

            DataTable sedes = new DataTable();
            sedes = objSedeBL.ListarSede();
            cmbSede.DataSource = sedes;
            DataRow[] filasSedes = sedes.Select($"codSede = '{objEmpleadoBE.codSede}'");
            if(filasSedes.Length > 0){
                cmbSede.SelectedIndex = sedes.Rows.IndexOf(filasSedes[0]);
            }
            else
            {
                cmbSede.SelectedIndex = 0;
            }
            cmbSede.DisplayMember = "nomSede";
            cmbSede.ValueMember = "codSede";

            DataTable documentos = new DataTable();
            documentos = objDocumentoBL.listarDocumentos();
            cmbTipoDoc.DataSource = documentos;
            DataRow[] filasEncontradas = documentos.Select($"codDoc = '{objEmpleadoBE.tipoDoc}'");
            if (filasEncontradas.Length > 0)
            {
                cmbTipoDoc.SelectedIndex = documentos.Rows.IndexOf(filasEncontradas[0]);
            }
            else
            {
                cmbTipoDoc.SelectedIndex = 0;
            }
            cmbTipoDoc.DisplayMember = "descrLarga";
            cmbTipoDoc.ValueMember = "codDoc";


            if(objEmpleadoBE.genero == "F")
            {
                rdbFemenino.Checked = true;
                rdbMasculino.Checked = false;
            }
            else
            {
                rdbMasculino.Checked = true;
                rdbFemenino.Checked = false;
            }


            DataTable horarios = new DataTable();
            horarios = objHorarioBL.ListarHorarios();
            cmbHorar.DataSource = horarios;
            DataRow[] filasHor = horarios.Select($"codHorario = '{objEmpleadoBE.codHorario}'");
            if(filasHor.Length > 0)
            {
                cmbHorar.SelectedIndex = horarios.Rows.IndexOf(filasHor[0]);    
            }
            else
            {
                cmbHorar.SelectedIndex = 0;
            }
            cmbHorar.DisplayMember = "desHorario";
            cmbHorar.ValueMember = "codHorario";

            txtNumDoc.Text = objEmpleadoBE.numroDoc.ToString();
            txtApelld.Text = objEmpleadoBE.apellidos.ToString();
            txtNom.Text = objEmpleadoBE.nombres.ToString();
            txtCorr.Text = objEmpleadoBE.correo.ToString();
            txtDirec.Text = objEmpleadoBE.direccion.ToString();
            txtTelf.Text = objEmpleadoBE.telefono.ToString();
            dtpFecNac.Value = objEmpleadoBE.fecNacimiento;
            dtpFecIngreso.Value = objEmpleadoBE.fecIngreso;
            byte[] img = objEmpleadoBE.foto;
            if (img != null && img.Length > 0)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(img);
                imgFoto.Image = Image.FromStream(memoryStream);
            }
            else
            {
                string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                imgFoto.Image = Image.FromFile(fotosTempPath + "noimage.jpg");
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

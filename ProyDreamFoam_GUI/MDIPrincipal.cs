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
    public partial class MDIPrincipal : Form
    {
        public String nomUser;
        ControlAsist controlAsist;
        Empleados formEmpleado;
        Horarios formHorarios;
        Asistencias formAsistencias;
        Login formLogin;
        public MDIPrincipal(String nomUser)
        {
            InitializeComponent();
            this.nomUser = nomUser;

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        void EstaCerradoEmpleado(object sender, EventArgs e)
        {
            formEmpleado = null;
        }



        private void imgLogo_Click(object sender, EventArgs e)
        {

        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

            if (formEmpleado == null)
            {
                formEmpleado = new Empleados(nomUser);
                formEmpleado.MdiParent = this;
                formEmpleado.FormClosed += new FormClosedEventHandler(EstaCerradoEmpleado);
                formEmpleado.Show();
            }
            else
            {
                formEmpleado.BringToFront();
            }
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {

            if (controlAsist == null)
            {
                controlAsist = new ControlAsist(nomUser);
                controlAsist.MdiParent = this;
                controlAsist.FormClosed += new FormClosedEventHandler(EstaCerradoControl);
                controlAsist.BringToFront();
                controlAsist.Show();
            }
            else
            {
                controlAsist.BringToFront();
            }

        }
        void EstaCerradoControl(object sender, EventArgs e)
        {
            controlAsist = null;
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            if (formHorarios == null)
            {
                formHorarios = new Horarios(nomUser);
                formHorarios.MdiParent = this;
                formHorarios.FormClosed += new FormClosedEventHandler(EstaCerradoHorarios);
                formHorarios.BringToFront();
                formHorarios.Show();
            }
            else
            {
                formHorarios.BringToFront();
            }
        }
        void EstaCerradoHorarios(object sender, EventArgs e)
        {
            formHorarios = null;
        }

        private void btnRegAsist_Click(object sender, EventArgs e)
        {
            if (formAsistencias == null)
            {
                formAsistencias = new Asistencias(nomUser);
                formAsistencias.MdiParent = this;
                formAsistencias.FormClosed += new FormClosedEventHandler(EstaCerradoAsistencias);
                formAsistencias.BringToFront();
                formAsistencias.Show();
            }
            else
            {
                formAsistencias.BringToFront();
            }
        }
        void EstaCerradoAsistencias(object sender, EventArgs e)
        {
            formAsistencias = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar la sesion?",
                "Cerrar sesion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                //if (Application.OpenForms["Login"] != null)
                //{
                //    Application.OpenForms["Login"].Show();
                //}
                Application.Exit();
            }
        }
    }
}

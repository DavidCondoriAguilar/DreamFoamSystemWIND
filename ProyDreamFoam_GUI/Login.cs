using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyDreamFoam_BE;
using ProyDreamFoam_BL;

namespace ProyDreamFoam_GUI
{
    public partial class Login : Form
    {
        Int16 intentos = 0;
        MDIPrincipal _MDIPrincipal;
        UserSystemBE objUserSystemBE = new UserSystemBE();
        UserSystemBL objUserSystemBL = new UserSystemBL();
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNomUser.Text.Trim() != "" & txtPassUser.Text.Trim() != "")
            {
                objUserSystemBE = objUserSystemBL.ConsultarUserSystemNom(txtNomUser.Text.Trim());

                if (objUserSystemBE.nomUser == null)
                {
                    intentos += 1;
                    LimiteIntentos();
                    
                }
                else if (txtNomUser.Text.Trim() == objUserSystemBE.nomUser
                    && txtPassUser.Text.Trim() == objUserSystemBE.passUser)
                {
                    //_MDIPrincipal = new MDIPrincipal(objUserSystemBE.nomUser);
                    //_MDIPrincipal.Show();
                    //_MDIPrincipal.FormClosed += LogOut;
                    //this.Hide();
                    if (_MDIPrincipal == null)
                    {
                        _MDIPrincipal = new MDIPrincipal(objUserSystemBE.nomUser);
                        _MDIPrincipal.FormClosed += new FormClosedEventHandler(EstaCerradoMDIPrincipal);
                        _MDIPrincipal.FormClosed += LogOut;
                        _MDIPrincipal.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        _MDIPrincipal.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    LimiteIntentos();
                }
            }
            else
            {
                MessageBox.Show("El campo usuario y contraseña son obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                LimiteIntentos();
            }
        }
        void EstaCerradoMDIPrincipal(object sender, EventArgs e)
        {
            _MDIPrincipal = null;
        }
        private void LimiteIntentos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos, ha sobrepaso el numero maximo de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void txtNomUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender,true,true,true,true);
                e.Handled = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtNomUser.KeyDown += txtNomUser_KeyDown;
            txtPassUser.KeyDown += txtPassUser_KeyDown;
            this.KeyDown += Login_KeyDown;

            btnLogin.Click += btnLogin_Click;
        }
        

        private void txtPassUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtPassUser.Text) && !string.IsNullOrWhiteSpace(txtNomUser.Text)){
                btnLogin_Click(sender, new EventArgs());
                e.Handled = true;
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            txtNomUser.Clear();
            txtPassUser.Clear();
            this.Show();
            txtNomUser.Focus();
            intentos = 0;
        }
    }
}

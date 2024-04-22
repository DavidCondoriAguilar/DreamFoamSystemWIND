namespace ProyDreamFoam_GUI
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            imgLogo = new PictureBox();
            btnMarcas = new Button();
            btnEmpleados = new Button();
            btnHorarios = new Button();
            btnRegAsist = new Button();
            panel2 = new Panel();
            btnLogout = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(54, 81, 103);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnMarcas);
            flowLayoutPanel1.Controls.Add(btnEmpleados);
            flowLayoutPanel1.Controls.Add(btnHorarios);
            flowLayoutPanel1.Controls.Add(btnRegAsist);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(186, 630);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(imgLogo);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 127);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(18, 87);
            label1.Name = "label1";
            label1.Size = new Size(147, 22);
            label1.TabIndex = 1;
            label1.Text = "Dream Foam";
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.dreamLogo3W;
            imgLogo.Location = new Point(36, 23);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(106, 67);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // btnMarcas
            // 
            btnMarcas.BackColor = Color.FromArgb(54, 81, 103);
            btnMarcas.FlatAppearance.BorderSize = 0;
            btnMarcas.FlatStyle = FlatStyle.Flat;
            btnMarcas.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarcas.ForeColor = SystemColors.ControlLightLight;
            btnMarcas.Image = Properties.Resources.marcaB2;
            btnMarcas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMarcas.Location = new Point(3, 136);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Padding = new Padding(20, 0, 0, 0);
            btnMarcas.Size = new Size(183, 68);
            btnMarcas.TabIndex = 6;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = false;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(54, 81, 103);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ForeColor = SystemColors.ControlLightLight;
            btnEmpleados.Image = Properties.Resources.emplW1;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(3, 210);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(20, 0, 0, 0);
            btnEmpleados.Size = new Size(183, 68);
            btnEmpleados.TabIndex = 7;
            btnEmpleados.Text = "      Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnHorarios
            // 
            btnHorarios.BackColor = Color.FromArgb(54, 81, 103);
            btnHorarios.FlatAppearance.BorderSize = 0;
            btnHorarios.FlatStyle = FlatStyle.Flat;
            btnHorarios.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHorarios.ForeColor = SystemColors.ControlLightLight;
            btnHorarios.Image = Properties.Resources.relojW1;
            btnHorarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnHorarios.Location = new Point(3, 284);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Padding = new Padding(20, 0, 0, 0);
            btnHorarios.Size = new Size(183, 68);
            btnHorarios.TabIndex = 7;
            btnHorarios.Text = "  Horarios";
            btnHorarios.UseVisualStyleBackColor = false;
            btnHorarios.Click += btnHorarios_Click;
            // 
            // btnRegAsist
            // 
            btnRegAsist.BackColor = Color.FromArgb(54, 81, 103);
            btnRegAsist.FlatAppearance.BorderSize = 0;
            btnRegAsist.FlatStyle = FlatStyle.Flat;
            btnRegAsist.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegAsist.ForeColor = SystemColors.ControlLightLight;
            btnRegAsist.Image = Properties.Resources.calendW2;
            btnRegAsist.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegAsist.Location = new Point(3, 358);
            btnRegAsist.Name = "btnRegAsist";
            btnRegAsist.Padding = new Padding(20, 0, 0, 0);
            btnRegAsist.Size = new Size(183, 68);
            btnRegAsist.TabIndex = 7;
            btnRegAsist.Text = "      Asistencias";
            btnRegAsist.UseVisualStyleBackColor = false;
            btnRegAsist.Click += btnRegAsist_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogout);
            panel2.Location = new Point(3, 432);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 198);
            panel2.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = Properties.Resources.logoutW2;
            btnLogout.Location = new Point(63, 118);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(36, 45);
            btnLogout.TabIndex = 6;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(986, 630);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DreamFoam ";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            FormClosing += MDIPrincipal_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private PictureBox imgLogo;
        private Button btnMarcas;
        private Button btnEmpleados;
        private Button btnHorarios;
        private Button btnRegAsist;
        private Panel panel2;
        private Button btnLogout;
    }
}
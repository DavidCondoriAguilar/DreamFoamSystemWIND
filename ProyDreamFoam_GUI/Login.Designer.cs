namespace ProyDreamFoam_GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            btnLogin = new Button();
            txtPassUser = new TextBox();
            label4 = new Label();
            txtNomUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dreamLogo3;
            pictureBox1.Location = new Point(34, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 81, 103);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassUser);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNomUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(192, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 484);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(21, 449);
            label5.Name = "label5";
            label5.Size = new Size(202, 15);
            label5.TabIndex = 8;
            label5.Text = "Usuario y contraseña de test \"admin\"";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(28, 44, 70);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(21, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(227, 41);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassUser
            // 
            txtPassUser.Location = new Point(21, 269);
            txtPassUser.Name = "txtPassUser";
            txtPassUser.Size = new Size(227, 23);
            txtPassUser.TabIndex = 6;
            txtPassUser.UseSystemPasswordChar = true;
            txtPassUser.KeyDown += txtPassUser_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(21, 243);
            label4.Name = "label4";
            label4.Size = new Size(109, 14);
            label4.TabIndex = 5;
            label4.Text = "Ingrese contraseña:";
            // 
            // txtNomUser
            // 
            txtNomUser.Location = new Point(21, 206);
            txtNomUser.Name = "txtNomUser";
            txtNomUser.Size = new Size(227, 23);
            txtNomUser.TabIndex = 4;
            txtNomUser.KeyDown += txtNomUser_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(21, 180);
            label3.Name = "label3";
            label3.Size = new Size(150, 14);
            label3.TabIndex = 3;
            label3.Text = "Ingrese nombre de usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(21, 144);
            label2.Name = "label2";
            label2.Size = new Size(227, 15);
            label2.TabIndex = 2;
            label2.Text = "Por favor inicie sesión para conitnuar.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(21, 100);
            label1.Name = "label1";
            label1.Size = new Size(213, 35);
            label1.TabIndex = 1;
            label1.Text = "Inicio de Sesión";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.xpng;
            pictureBox2.Location = new Point(277, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Copperplate Gothic Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(12, 169);
            title.Name = "title";
            title.Size = new Size(176, 26);
            title.TabIndex = 2;
            title.Text = "Dream Foam ";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(501, 484);
            Controls.Add(title);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DreamFoamSystem";
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label title;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private TextBox txtNomUser;
        private Label label3;
        private TextBox txtPassUser;
        private Label label4;
        private Button btnLogin;
        private Label label5;
    }
}
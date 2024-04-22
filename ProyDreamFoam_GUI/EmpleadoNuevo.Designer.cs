namespace ProyDreamFoam_GUI
{
    partial class EmpleadoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoNuevo));
            label1 = new Label();
            gbDatosPers = new GroupBox();
            label17 = new Label();
            dtpFecNac = new DateTimePicker();
            txtTelf = new TextBox();
            label16 = new Label();
            rdbFemenino = new RadioButton();
            txtCorr = new TextBox();
            rdbMasculino = new RadioButton();
            txtDirec = new TextBox();
            txtNom = new TextBox();
            txtApelld = new TextBox();
            txtNumDoc = new TextBox();
            cmbTipoDoc = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dtpFecIngreso = new DateTimePicker();
            cmbCargo = new ComboBox();
            cmbArea = new ComboBox();
            cmbSede = new ComboBox();
            cmbHorar = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label15 = new Label();
            imgFoto = new PictureBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnIngrFoto = new Button();
            gbDatosPers.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Empleado";
            // 
            // gbDatosPers
            // 
            gbDatosPers.Controls.Add(label17);
            gbDatosPers.Controls.Add(dtpFecNac);
            gbDatosPers.Controls.Add(txtTelf);
            gbDatosPers.Controls.Add(label16);
            gbDatosPers.Controls.Add(rdbFemenino);
            gbDatosPers.Controls.Add(txtCorr);
            gbDatosPers.Controls.Add(rdbMasculino);
            gbDatosPers.Controls.Add(txtDirec);
            gbDatosPers.Controls.Add(txtNom);
            gbDatosPers.Controls.Add(txtApelld);
            gbDatosPers.Controls.Add(txtNumDoc);
            gbDatosPers.Controls.Add(cmbTipoDoc);
            gbDatosPers.Controls.Add(label9);
            gbDatosPers.Controls.Add(label8);
            gbDatosPers.Controls.Add(label7);
            gbDatosPers.Controls.Add(label6);
            gbDatosPers.Controls.Add(label5);
            gbDatosPers.Controls.Add(label4);
            gbDatosPers.Controls.Add(label3);
            gbDatosPers.Controls.Add(label2);
            gbDatosPers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbDatosPers.Location = new Point(21, 62);
            gbDatosPers.Name = "gbDatosPers";
            gbDatosPers.Size = new Size(666, 176);
            gbDatosPers.TabIndex = 1;
            gbDatosPers.TabStop = false;
            gbDatosPers.Text = "Datos Personales";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Leelawadee", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(539, 154);
            label17.Name = "label17";
            label17.Size = new Size(121, 14);
            label17.TabIndex = 14;
            label17.Text = "Campos obligatorios (*)";
            // 
            // dtpFecNac
            // 
            dtpFecNac.CustomFormat = "";
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(143, 110);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(106, 25);
            dtpFecNac.TabIndex = 13;
            // 
            // txtTelf
            // 
            txtTelf.BorderStyle = BorderStyle.FixedSingle;
            txtTelf.Location = new Point(143, 141);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(186, 25);
            txtTelf.TabIndex = 12;
            txtTelf.KeyPress += txtTelf_KeyPress;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(20, 146);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 11;
            label16.Text = "Telefono:";
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(519, 46);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(82, 21);
            rdbFemenino.TabIndex = 10;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            rdbFemenino.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtCorr
            // 
            txtCorr.BorderStyle = BorderStyle.FixedSingle;
            txtCorr.Location = new Point(415, 101);
            txtCorr.Name = "txtCorr";
            txtCorr.Size = new Size(221, 25);
            txtCorr.TabIndex = 9;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Checked = true;
            rdbMasculino.Location = new Point(415, 46);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(85, 21);
            rdbMasculino.TabIndex = 5;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtDirec
            // 
            txtDirec.BorderStyle = BorderStyle.FixedSingle;
            txtDirec.CharacterCasing = CharacterCasing.Upper;
            txtDirec.Location = new Point(415, 70);
            txtDirec.Name = "txtDirec";
            txtDirec.Size = new Size(221, 25);
            txtDirec.TabIndex = 8;
            // 
            // txtNom
            // 
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.Location = new Point(143, 79);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(186, 25);
            txtNom.TabIndex = 7;
            // 
            // txtApelld
            // 
            txtApelld.BorderStyle = BorderStyle.FixedSingle;
            txtApelld.CharacterCasing = CharacterCasing.Upper;
            txtApelld.Location = new Point(143, 48);
            txtApelld.Name = "txtApelld";
            txtApelld.Size = new Size(186, 25);
            txtApelld.TabIndex = 6;
            // 
            // txtNumDoc
            // 
            txtNumDoc.BorderStyle = BorderStyle.FixedSingle;
            txtNumDoc.Location = new Point(143, 18);
            txtNumDoc.MaxLength = 15;
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(186, 25);
            txtNumDoc.TabIndex = 3;
            txtNumDoc.KeyPress += txtNumDoc_KeyPress;
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Location = new Point(468, 18);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new Size(168, 25);
            cmbTipoDoc.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(350, 106);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 3;
            label9.Text = "Correo: *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(349, 76);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 3;
            label8.Text = "Direccion: *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(349, 50);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 3;
            label7.Text = "Sexo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 115);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 3;
            label6.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 86);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 3;
            label5.Text = "Nombres: *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 56);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellidos : *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 21);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 3;
            label3.Text = "Nro. Documento: *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(347, 21);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 0;
            label2.Text = "Tipo de Documento:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFecIngreso);
            groupBox1.Controls.Add(cmbCargo);
            groupBox1.Controls.Add(cmbArea);
            groupBox1.Controls.Add(cmbSede);
            groupBox1.Controls.Add(cmbHorar);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(21, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 215);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la empresa";
            // 
            // dtpFecIngreso
            // 
            dtpFecIngreso.CustomFormat = "";
            dtpFecIngreso.Format = DateTimePickerFormat.Short;
            dtpFecIngreso.Location = new Point(125, 32);
            dtpFecIngreso.Name = "dtpFecIngreso";
            dtpFecIngreso.Size = new Size(95, 23);
            dtpFecIngreso.TabIndex = 14;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(110, 135);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(201, 23);
            cmbCargo.TabIndex = 12;
            // 
            // cmbArea
            // 
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(110, 101);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(201, 23);
            cmbArea.TabIndex = 11;
            // 
            // cmbSede
            // 
            cmbSede.FormattingEnabled = true;
            cmbSede.Location = new Point(110, 67);
            cmbSede.Name = "cmbSede";
            cmbSede.Size = new Size(201, 23);
            cmbSede.TabIndex = 10;
            // 
            // cmbHorar
            // 
            cmbHorar.FormattingEnabled = true;
            cmbHorar.Location = new Point(110, 170);
            cmbHorar.Name = "cmbHorar";
            cmbHorar.Size = new Size(201, 23);
            cmbHorar.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(20, 173);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 8;
            label14.Text = "Horario:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(20, 138);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 7;
            label13.Text = "Cargo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(20, 104);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 6;
            label12.Text = "Area:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(20, 70);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 5;
            label11.Text = "Sede:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(20, 38);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 4;
            label10.Text = "Fecha de Ingreso:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(396, 268);
            label15.Name = "label15";
            label15.Size = new Size(34, 15);
            label15.TabIndex = 3;
            label15.Text = "Foto:";
            // 
            // imgFoto
            // 
            imgFoto.BorderStyle = BorderStyle.FixedSingle;
            imgFoto.Location = new Point(436, 268);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(221, 200);
            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFoto.TabIndex = 4;
            imgFoto.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlLightLight;
            btnAceptar.Location = new Point(138, 465);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 48);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(247, 465);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 48);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIngrFoto
            // 
            btnIngrFoto.BackColor = SystemColors.WindowFrame;
            btnIngrFoto.Cursor = Cursors.Hand;
            btnIngrFoto.FlatAppearance.BorderSize = 0;
            btnIngrFoto.FlatStyle = FlatStyle.Popup;
            btnIngrFoto.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngrFoto.ForeColor = SystemColors.ControlLightLight;
            btnIngrFoto.Location = new Point(436, 474);
            btnIngrFoto.Name = "btnIngrFoto";
            btnIngrFoto.Size = new Size(221, 25);
            btnIngrFoto.TabIndex = 8;
            btnIngrFoto.Text = "Ingresar foto";
            btnIngrFoto.UseVisualStyleBackColor = false;
            btnIngrFoto.Click += btnIngrFoto_Click;
            // 
            // EmpleadoNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(727, 525);
            Controls.Add(btnIngrFoto);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(imgFoto);
            Controls.Add(label15);
            Controls.Add(groupBox1);
            Controls.Add(gbDatosPers);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoNuevo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar nuevo empleado";
            Load += EmpleadoNuevo_Load;
            gbDatosPers.ResumeLayout(false);
            gbDatosPers.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbDatosPers;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtNumDoc;
        private ComboBox cmbTipoDoc;
        private CheckBox checkF;
        private TextBox txtCorr;
        private TextBox txtDirec;
        private TextBox txtNom;
        private TextBox txtApelld;
        private ComboBox cmbCargo;
        private ComboBox cmbArea;
        private ComboBox cmbSede;
        private ComboBox cmbHorar;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label15;
        private PictureBox imgFoto;
        private RadioButton radioButton2;
        private RadioButton rdbMasculino;
        private Button btnAceptar;
        private Button btnCancelar;
        private RadioButton rdbFemenino;
        private TextBox txtTelf;
        private Label label16;
        private Button btnIngrFoto;
        private DateTimePicker dtpFecNac;
        private DateTimePicker dtpFecIngreso;
        private Label label17;
    }
}
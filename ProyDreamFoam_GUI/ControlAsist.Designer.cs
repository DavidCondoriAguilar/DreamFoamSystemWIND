namespace ProyDreamFoam_GUI
{
    partial class ControlAsist
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAsist));
            dtTimer = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            lblHoraDes = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            btnIngr = new Button();
            gpControl = new GroupBox();
            btnSald = new Button();
            btnIngRefr = new Button();
            btnSalRefr = new Button();
            label11 = new Label();
            label3 = new Label();
            gpInfor = new GroupBox();
            lblMensaje = new Label();
            label10 = new Label();
            lblSituac = new Label();
            label9 = new Label();
            lblMarca = new Label();
            label8 = new Label();
            label7 = new Label();
            imgEmpl = new PictureBox();
            txtNumDoc = new TextBox();
            label6 = new Label();
            txtDocm = new TextBox();
            label5 = new Label();
            txtCodOut = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
            gpControl.SuspendLayout();
            gpInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgEmpl).BeginInit();
            SuspendLayout();
            // 
            // dtTimer
            // 
            dtTimer.Enabled = true;
            dtTimer.Tick += dtTimer_Tick;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = SystemColors.ControlLightLight;
            lblHora.Font = new Font("Unispace", 51.7499924F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(377, 59);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(371, 83);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00";
            // 
            // lblHoraDes
            // 
            lblHoraDes.AutoSize = true;
            lblHoraDes.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoraDes.ForeColor = SystemColors.ControlDarkDark;
            lblHoraDes.Location = new Point(396, 142);
            lblHoraDes.Name = "lblHoraDes";
            lblHoraDes.Size = new Size(106, 23);
            lblHoraDes.TabIndex = 0;
            lblHoraDes.Text = "NA NA NA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 29);
            label2.Name = "label2";
            label2.Size = new Size(243, 14);
            label2.TabIndex = 0;
            label2.Text = "Ingrese el codigo o documento de identidad:";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Leelawadee", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(13, 52);
            txtCodigo.MaxLength = 15;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(318, 30);
            txtCodigo.TabIndex = 1;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // btnIngr
            // 
            btnIngr.BackColor = Color.Black;
            btnIngr.FlatAppearance.BorderSize = 0;
            btnIngr.FlatStyle = FlatStyle.Flat;
            btnIngr.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngr.ForeColor = SystemColors.ControlLightLight;
            btnIngr.Location = new Point(14, 102);
            btnIngr.Name = "btnIngr";
            btnIngr.Size = new Size(77, 48);
            btnIngr.TabIndex = 2;
            btnIngr.Text = "INGRESO";
            btnIngr.UseVisualStyleBackColor = false;
            btnIngr.Click += btnIngr_Click;
            // 
            // gpControl
            // 
            gpControl.Controls.Add(btnSald);
            gpControl.Controls.Add(btnIngRefr);
            gpControl.Controls.Add(btnSalRefr);
            gpControl.Controls.Add(label11);
            gpControl.Controls.Add(btnIngr);
            gpControl.Controls.Add(label2);
            gpControl.Controls.Add(txtCodigo);
            gpControl.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            gpControl.Location = new Point(34, 31);
            gpControl.Name = "gpControl";
            gpControl.Size = new Size(340, 172);
            gpControl.TabIndex = 1;
            gpControl.TabStop = false;
            gpControl.Text = "Control de Marcas";
            // 
            // btnSald
            // 
            btnSald.BackColor = SystemColors.ActiveCaptionText;
            btnSald.FlatAppearance.BorderSize = 0;
            btnSald.FlatStyle = FlatStyle.Flat;
            btnSald.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSald.ForeColor = SystemColors.ControlLightLight;
            btnSald.Location = new Point(254, 102);
            btnSald.Name = "btnSald";
            btnSald.Size = new Size(77, 48);
            btnSald.TabIndex = 6;
            btnSald.Text = "SALIDA";
            btnSald.UseVisualStyleBackColor = false;
            btnSald.Click += btnSald_Click;
            // 
            // btnIngRefr
            // 
            btnIngRefr.BackColor = SystemColors.ActiveCaptionText;
            btnIngRefr.FlatAppearance.BorderSize = 0;
            btnIngRefr.FlatStyle = FlatStyle.Flat;
            btnIngRefr.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngRefr.ForeColor = SystemColors.ControlLightLight;
            btnIngRefr.Location = new Point(174, 102);
            btnIngRefr.Name = "btnIngRefr";
            btnIngRefr.Size = new Size(77, 48);
            btnIngRefr.TabIndex = 5;
            btnIngRefr.Text = "INGRESO REFRIGERIO";
            btnIngRefr.UseVisualStyleBackColor = false;
            btnIngRefr.Click += btnIngRefr_Click;
            // 
            // btnSalRefr
            // 
            btnSalRefr.BackColor = SystemColors.ActiveCaptionText;
            btnSalRefr.FlatAppearance.BorderSize = 0;
            btnSalRefr.FlatStyle = FlatStyle.Flat;
            btnSalRefr.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalRefr.ForeColor = SystemColors.ControlLightLight;
            btnSalRefr.Location = new Point(94, 102);
            btnSalRefr.Name = "btnSalRefr";
            btnSalRefr.Size = new Size(77, 48);
            btnSalRefr.TabIndex = 4;
            btnSalRefr.Text = "SALIDA REFRIGERIO";
            btnSalRefr.UseVisualStyleBackColor = false;
            btnSalRefr.Click += btnSalRefr_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(13, 85);
            label11.Name = "label11";
            label11.Size = new Size(84, 14);
            label11.TabIndex = 3;
            label11.Text = "Tipo de marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 69);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // gpInfor
            // 
            gpInfor.Controls.Add(lblMensaje);
            gpInfor.Controls.Add(label10);
            gpInfor.Controls.Add(lblSituac);
            gpInfor.Controls.Add(label9);
            gpInfor.Controls.Add(lblMarca);
            gpInfor.Controls.Add(label8);
            gpInfor.Controls.Add(label7);
            gpInfor.Controls.Add(imgEmpl);
            gpInfor.Controls.Add(txtNumDoc);
            gpInfor.Controls.Add(label6);
            gpInfor.Controls.Add(txtDocm);
            gpInfor.Controls.Add(label5);
            gpInfor.Controls.Add(txtCodOut);
            gpInfor.Controls.Add(label4);
            gpInfor.Controls.Add(txtNombre);
            gpInfor.Controls.Add(lblNombre);
            gpInfor.Controls.Add(label1);
            gpInfor.Controls.Add(label3);
            gpInfor.Location = new Point(34, 209);
            gpInfor.Name = "gpInfor";
            gpInfor.Size = new Size(709, 349);
            gpInfor.TabIndex = 2;
            gpInfor.TabStop = false;
            gpInfor.Text = "Informacion Empleado";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Leelawadee", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(16, 282);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 18);
            lblMensaje.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 260);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 18;
            label10.Text = "Mensaje:";
            // 
            // lblSituac
            // 
            lblSituac.AutoSize = true;
            lblSituac.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblSituac.Location = new Point(218, 178);
            lblSituac.Name = "lblSituac";
            lblSituac.Size = new Size(0, 33);
            lblSituac.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(218, 154);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 16;
            label9.Text = "Situacion de Marca:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.Location = new Point(13, 178);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(186, 42);
            lblMarca.TabIndex = 15;
            lblMarca.Text = "00:00:00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 154);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 14;
            label8.Text = "Hora de marca rgistrada:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 28);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 13;
            label7.Text = "Foto:";
            // 
            // imgEmpl
            // 
            imgEmpl.BorderStyle = BorderStyle.FixedSingle;
            imgEmpl.Image = Properties.Resources.noimage;
            imgEmpl.Location = new Point(415, 46);
            imgEmpl.Name = "imgEmpl";
            imgEmpl.Size = new Size(242, 251);
            imgEmpl.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEmpl.TabIndex = 12;
            imgEmpl.TabStop = false;
            // 
            // txtNumDoc
            // 
            txtNumDoc.BorderStyle = BorderStyle.FixedSingle;
            txtNumDoc.Location = new Point(121, 114);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.ReadOnly = true;
            txtNumDoc.Size = new Size(192, 23);
            txtNumDoc.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 116);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 6;
            label6.Text = "Nro. Documento:";
            // 
            // txtDocm
            // 
            txtDocm.BorderStyle = BorderStyle.FixedSingle;
            txtDocm.Location = new Point(256, 85);
            txtDocm.Name = "txtDocm";
            txtDocm.ReadOnly = true;
            txtDocm.Size = new Size(131, 23);
            txtDocm.TabIndex = 8;
            txtDocm.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 87);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 7;
            label5.Text = "Tipo de Documento:";
            // 
            // txtCodOut
            // 
            txtCodOut.BorderStyle = BorderStyle.FixedSingle;
            txtCodOut.Location = new Point(75, 85);
            txtCodOut.Name = "txtCodOut";
            txtCodOut.ReadOnly = true;
            txtCodOut.Size = new Size(56, 23);
            txtCodOut.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 87);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Codigo : ";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(14, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(373, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellidos y nombres:";
            // 
            // ControlAsist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(770, 570);
            Controls.Add(gpControl);
            Controls.Add(gpInfor);
            Controls.Add(lblHoraDes);
            Controls.Add(lblHora);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "ControlAsist";
            Text = "Control de Marcas";
            WindowState = FormWindowState.Maximized;
            gpControl.ResumeLayout(false);
            gpControl.PerformLayout();
            gpInfor.ResumeLayout(false);
            gpInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgEmpl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer dtTimer;
        private Label lblHora;
        private Label lblHoraDes;
        private Label label2;
        private TextBox txtCodigo;
        private Button btnIngr;
        private GroupBox gpControl;
        private Label label3;
        private GroupBox gpInfor;
        private Label lblNombre;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCodOut;
        private Label label4;
        private TextBox txtDocm;
        private Label label5;
        private TextBox txtNumDoc;
        private Label label6;
        private Label label7;
        private PictureBox imgEmpl;
        private Label lblSituac;
        private Label label9;
        private Label lblMarca;
        private Label label8;
        private Label lblMensaje;
        private Label label10;
        private Label label11;
        private Button btnSalRefr;
        private Button btnIngRefr;
        private Button btnSald;
    }
}
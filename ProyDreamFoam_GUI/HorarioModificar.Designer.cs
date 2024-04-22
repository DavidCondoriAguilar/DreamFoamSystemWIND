namespace ProyDreamFoam_GUI
{
    partial class HorarioModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorarioModificar));
            gpbHorario = new GroupBox();
            lblCodigo = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            txtDiaDesc = new TextBox();
            label18 = new Label();
            txtToler = new TextBox();
            label17 = new Label();
            txtRefrigr = new TextBox();
            label16 = new Label();
            groupBox6 = new GroupBox();
            label14 = new Label();
            label15 = new Label();
            dtpIngDOM = new DateTimePicker();
            dtpSalDOM = new DateTimePicker();
            groupBox5 = new GroupBox();
            label12 = new Label();
            label13 = new Label();
            dtpIngVIE = new DateTimePicker();
            dtpSalVIE = new DateTimePicker();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label11 = new Label();
            dtpIngSAB = new DateTimePicker();
            dtpSalSAB = new DateTimePicker();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            dtpIngJUE = new DateTimePicker();
            dtpSalJUE = new DateTimePicker();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            dtpIngMIE = new DateTimePicker();
            dtpSalMIE = new DateTimePicker();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            dtpIngMAR = new DateTimePicker();
            dtpSalMAR = new DateTimePicker();
            dbLun = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            dtpIngLUN = new DateTimePicker();
            dtpSalLUN = new DateTimePicker();
            txtNomHorar = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            gpbHorario.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            dbLun.SuspendLayout();
            SuspendLayout();
            // 
            // gpbHorario
            // 
            gpbHorario.Controls.Add(lblCodigo);
            gpbHorario.Controls.Add(label21);
            gpbHorario.Controls.Add(label20);
            gpbHorario.Controls.Add(label19);
            gpbHorario.Controls.Add(txtDiaDesc);
            gpbHorario.Controls.Add(label18);
            gpbHorario.Controls.Add(txtToler);
            gpbHorario.Controls.Add(label17);
            gpbHorario.Controls.Add(txtRefrigr);
            gpbHorario.Controls.Add(label16);
            gpbHorario.Controls.Add(groupBox6);
            gpbHorario.Controls.Add(groupBox5);
            gpbHorario.Controls.Add(groupBox4);
            gpbHorario.Controls.Add(groupBox3);
            gpbHorario.Controls.Add(groupBox2);
            gpbHorario.Controls.Add(groupBox1);
            gpbHorario.Controls.Add(dbLun);
            gpbHorario.Controls.Add(txtNomHorar);
            gpbHorario.Controls.Add(label1);
            gpbHorario.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            gpbHorario.Location = new Point(12, 12);
            gpbHorario.Name = "gpbHorario";
            gpbHorario.Size = new Size(522, 722);
            gpbHorario.TabIndex = 1;
            gpbHorario.TabStop = false;
            gpbHorario.Text = "Actualizar Horario ";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.Location = new Point(77, 45);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(0, 19);
            lblCodigo.TabIndex = 23;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(16, 47);
            label21.Name = "label21";
            label21.Size = new Size(53, 15);
            label21.TabIndex = 22;
            label21.Text = "Codigo:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(16, 692);
            label20.Name = "label20";
            label20.Size = new Size(213, 14);
            label20.TabIndex = 21;
            label20.Text = "( ** ) Tiempo establecido en minutos.    ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(16, 678);
            label19.Name = "label19";
            label19.Size = new Size(155, 14);
            label19.TabIndex = 20;
            label19.Text = "(  *  ) Campos obligatorios.   ";
            // 
            // txtDiaDesc
            // 
            txtDiaDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDiaDesc.Font = new Font("Leelawadee", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaDesc.Location = new Point(177, 233);
            txtDiaDesc.MaxLength = 1;
            txtDiaDesc.Name = "txtDiaDesc";
            txtDiaDesc.Size = new Size(60, 25);
            txtDiaDesc.TabIndex = 19;
            txtDiaDesc.KeyPress += txtDiaDesc_KeyPress;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(16, 237);
            label18.Name = "label18";
            label18.Size = new Size(126, 15);
            label18.TabIndex = 18;
            label18.Text = "Dias de descanso: * ";
            // 
            // txtToler
            // 
            txtToler.BorderStyle = BorderStyle.FixedSingle;
            txtToler.Font = new Font("Leelawadee", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtToler.Location = new Point(179, 198);
            txtToler.MaxLength = 3;
            txtToler.Name = "txtToler";
            txtToler.Size = new Size(60, 25);
            txtToler.TabIndex = 17;
            txtToler.KeyPress += txtToler_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(16, 202);
            label17.Name = "label17";
            label17.Size = new Size(157, 15);
            label17.TabIndex = 16;
            label17.Text = "Tiempo de tolerancia: * **";
            // 
            // txtRefrigr
            // 
            txtRefrigr.BorderStyle = BorderStyle.FixedSingle;
            txtRefrigr.Font = new Font("Leelawadee", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRefrigr.Location = new Point(177, 157);
            txtRefrigr.MaxLength = 3;
            txtRefrigr.Name = "txtRefrigr";
            txtRefrigr.Size = new Size(60, 25);
            txtRefrigr.TabIndex = 15;
            txtRefrigr.KeyPress += txtRefrigr_KeyPress;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(16, 161);
            label16.Name = "label16";
            label16.Size = new Size(155, 15);
            label16.TabIndex = 14;
            label16.Text = "Tiempo de refrigerio: * **";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(dtpIngDOM);
            groupBox6.Controls.Add(dtpSalDOM);
            groupBox6.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(256, 615);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(238, 91);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "Domingo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(124, 23);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 11;
            label14.Text = "Salida: *";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(17, 23);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 10;
            label15.Text = "Ingreso: *";
            // 
            // dtpIngDOM
            // 
            dtpIngDOM.CustomFormat = "HH:mm:ss tt";
            dtpIngDOM.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngDOM.Format = DateTimePickerFormat.Time;
            dtpIngDOM.Location = new Point(17, 41);
            dtpIngDOM.Name = "dtpIngDOM";
            dtpIngDOM.ShowUpDown = true;
            dtpIngDOM.Size = new Size(101, 33);
            dtpIngDOM.TabIndex = 8;
            dtpIngDOM.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // dtpSalDOM
            // 
            dtpSalDOM.CustomFormat = "HH:mm:ss tt";
            dtpSalDOM.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalDOM.Format = DateTimePickerFormat.Time;
            dtpSalDOM.Location = new Point(124, 41);
            dtpSalDOM.Name = "dtpSalDOM";
            dtpSalDOM.ShowUpDown = true;
            dtpSalDOM.Size = new Size(101, 33);
            dtpSalDOM.TabIndex = 9;
            dtpSalDOM.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(dtpIngVIE);
            groupBox5.Controls.Add(dtpSalVIE);
            groupBox5.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(256, 420);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(238, 91);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Viernes";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(124, 23);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 11;
            label12.Text = "Salida: *";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(17, 23);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 10;
            label13.Text = "Ingreso: *";
            // 
            // dtpIngVIE
            // 
            dtpIngVIE.CustomFormat = "HH:mm:ss tt";
            dtpIngVIE.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngVIE.Format = DateTimePickerFormat.Time;
            dtpIngVIE.Location = new Point(17, 41);
            dtpIngVIE.Name = "dtpIngVIE";
            dtpIngVIE.ShowUpDown = true;
            dtpIngVIE.Size = new Size(101, 33);
            dtpIngVIE.TabIndex = 8;
            dtpIngVIE.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // dtpSalVIE
            // 
            dtpSalVIE.CustomFormat = "HH:mm:ss tt";
            dtpSalVIE.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalVIE.Format = DateTimePickerFormat.Time;
            dtpSalVIE.Location = new Point(124, 41);
            dtpSalVIE.Name = "dtpSalVIE";
            dtpSalVIE.ShowUpDown = true;
            dtpSalVIE.Size = new Size(101, 33);
            dtpSalVIE.TabIndex = 9;
            dtpSalVIE.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(dtpIngSAB);
            groupBox4.Controls.Add(dtpSalSAB);
            groupBox4.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(256, 518);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(238, 91);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sábado";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(124, 23);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 11;
            label10.Text = "Salida: *";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(17, 23);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 10;
            label11.Text = "Ingreso: *";
            // 
            // dtpIngSAB
            // 
            dtpIngSAB.CustomFormat = "HH:mm:ss tt";
            dtpIngSAB.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngSAB.Format = DateTimePickerFormat.Time;
            dtpIngSAB.Location = new Point(17, 41);
            dtpIngSAB.Name = "dtpIngSAB";
            dtpIngSAB.ShowUpDown = true;
            dtpIngSAB.Size = new Size(101, 33);
            dtpIngSAB.TabIndex = 8;
            dtpIngSAB.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // dtpSalSAB
            // 
            dtpSalSAB.CustomFormat = "HH:mm:ss tt";
            dtpSalSAB.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalSAB.Format = DateTimePickerFormat.Time;
            dtpSalSAB.Location = new Point(124, 41);
            dtpSalSAB.Name = "dtpSalSAB";
            dtpSalSAB.ShowUpDown = true;
            dtpSalSAB.Size = new Size(101, 33);
            dtpSalSAB.TabIndex = 9;
            dtpSalSAB.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(dtpIngJUE);
            groupBox3.Controls.Add(dtpSalJUE);
            groupBox3.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(256, 323);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 91);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Jueves";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(124, 23);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 11;
            label8.Text = "Salida: *";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 23);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 10;
            label9.Text = "Ingreso: *";
            // 
            // dtpIngJUE
            // 
            dtpIngJUE.CustomFormat = "HH:mm:ss tt";
            dtpIngJUE.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngJUE.Format = DateTimePickerFormat.Time;
            dtpIngJUE.Location = new Point(17, 41);
            dtpIngJUE.Name = "dtpIngJUE";
            dtpIngJUE.ShowUpDown = true;
            dtpIngJUE.Size = new Size(101, 33);
            dtpIngJUE.TabIndex = 8;
            dtpIngJUE.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // dtpSalJUE
            // 
            dtpSalJUE.CustomFormat = "HH:mm:ss tt";
            dtpSalJUE.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalJUE.Format = DateTimePickerFormat.Time;
            dtpSalJUE.Location = new Point(124, 41);
            dtpSalJUE.Name = "dtpSalJUE";
            dtpSalJUE.ShowUpDown = true;
            dtpSalJUE.Size = new Size(101, 33);
            dtpSalJUE.TabIndex = 9;
            dtpSalJUE.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dtpIngMIE);
            groupBox2.Controls.Add(dtpSalMIE);
            groupBox2.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(256, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 91);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Miercoles";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(124, 23);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 11;
            label6.Text = "Salida: *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 23);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 10;
            label7.Text = "Ingreso: *";
            // 
            // dtpIngMIE
            // 
            dtpIngMIE.CustomFormat = "HH:mm:ss tt";
            dtpIngMIE.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngMIE.Format = DateTimePickerFormat.Time;
            dtpIngMIE.Location = new Point(17, 41);
            dtpIngMIE.Name = "dtpIngMIE";
            dtpIngMIE.ShowUpDown = true;
            dtpIngMIE.Size = new Size(101, 33);
            dtpIngMIE.TabIndex = 8;
            dtpIngMIE.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // dtpSalMIE
            // 
            dtpSalMIE.CustomFormat = "HH:mm:ss tt";
            dtpSalMIE.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalMIE.Format = DateTimePickerFormat.Time;
            dtpSalMIE.Location = new Point(124, 41);
            dtpSalMIE.Name = "dtpSalMIE";
            dtpSalMIE.ShowUpDown = true;
            dtpSalMIE.Size = new Size(101, 33);
            dtpSalMIE.TabIndex = 9;
            dtpSalMIE.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpIngMAR);
            groupBox1.Controls.Add(dtpSalMAR);
            groupBox1.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(256, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 91);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Martes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(124, 23);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Salida: *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 23);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 10;
            label3.Text = "Ingreso: *";
            // 
            // dtpIngMAR
            // 
            dtpIngMAR.CustomFormat = "HH:mm:ss tt";
            dtpIngMAR.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngMAR.Format = DateTimePickerFormat.Time;
            dtpIngMAR.Location = new Point(17, 41);
            dtpIngMAR.Name = "dtpIngMAR";
            dtpIngMAR.ShowUpDown = true;
            dtpIngMAR.Size = new Size(101, 33);
            dtpIngMAR.TabIndex = 8;
            dtpIngMAR.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // dtpSalMAR
            // 
            dtpSalMAR.CustomFormat = "HH:mm:ss tt";
            dtpSalMAR.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalMAR.Format = DateTimePickerFormat.Time;
            dtpSalMAR.Location = new Point(124, 41);
            dtpSalMAR.Name = "dtpSalMAR";
            dtpSalMAR.ShowUpDown = true;
            dtpSalMAR.Size = new Size(101, 33);
            dtpSalMAR.TabIndex = 9;
            dtpSalMAR.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // dbLun
            // 
            dbLun.Controls.Add(label4);
            dbLun.Controls.Add(label5);
            dbLun.Controls.Add(dtpIngLUN);
            dbLun.Controls.Add(dtpSalLUN);
            dbLun.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dbLun.Location = new Point(256, 32);
            dbLun.Name = "dbLun";
            dbLun.Size = new Size(238, 91);
            dbLun.TabIndex = 7;
            dbLun.TabStop = false;
            dbLun.Text = "Lunes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(124, 23);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 11;
            label4.Text = "Salida: *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 10;
            label5.Text = "Ingreso: *";
            // 
            // dtpIngLUN
            // 
            dtpIngLUN.CustomFormat = "HH:mm:ss tt";
            dtpIngLUN.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngLUN.Format = DateTimePickerFormat.Time;
            dtpIngLUN.Location = new Point(17, 41);
            dtpIngLUN.Name = "dtpIngLUN";
            dtpIngLUN.ShowUpDown = true;
            dtpIngLUN.Size = new Size(101, 33);
            dtpIngLUN.TabIndex = 8;
            dtpIngLUN.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // dtpSalLUN
            // 
            dtpSalLUN.CustomFormat = "HH:mm:ss tt";
            dtpSalLUN.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalLUN.Format = DateTimePickerFormat.Time;
            dtpSalLUN.Location = new Point(124, 41);
            dtpSalLUN.Name = "dtpSalLUN";
            dtpSalLUN.ShowUpDown = true;
            dtpSalLUN.Size = new Size(101, 33);
            dtpSalLUN.TabIndex = 9;
            dtpSalLUN.Value = new DateTime(2023, 12, 3, 21, 59, 0, 0);
            // 
            // txtNomHorar
            // 
            txtNomHorar.BorderStyle = BorderStyle.FixedSingle;
            txtNomHorar.CharacterCasing = CharacterCasing.Upper;
            txtNomHorar.Location = new Point(16, 105);
            txtNomHorar.Name = "txtNomHorar";
            txtNomHorar.Size = new Size(221, 33);
            txtNomHorar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 87);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Horario: *";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(431, 749);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 37);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlLightLight;
            btnAceptar.Location = new Point(322, 749);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 37);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // HorarioModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 798);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(gpbHorario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HorarioModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizando horario";
            Load += HorarioModificar_Load;
            gpbHorario.ResumeLayout(false);
            gpbHorario.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            dbLun.ResumeLayout(false);
            dbLun.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbHorario;
        private Label label20;
        private Label label19;
        private TextBox txtDiaDesc;
        private Label label18;
        private TextBox txtToler;
        private Label label17;
        private TextBox txtRefrigr;
        private Label label16;
        private GroupBox groupBox6;
        private Label label14;
        private Label label15;
        private DateTimePicker dtpIngDOM;
        private DateTimePicker dtpSalDOM;
        private GroupBox groupBox5;
        private Label label12;
        private Label label13;
        private DateTimePicker dtpIngVIE;
        private DateTimePicker dtpSalVIE;
        private GroupBox groupBox4;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpIngSAB;
        private DateTimePicker dtpSalSAB;
        private GroupBox groupBox3;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpIngJUE;
        private DateTimePicker dtpSalJUE;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpIngMIE;
        private DateTimePicker dtpSalMIE;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpIngMAR;
        private DateTimePicker dtpSalMAR;
        private GroupBox dbLun;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpIngLUN;
        private DateTimePicker dtpSalLUN;
        private TextBox txtNomHorar;
        private Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblCodigo;
        private Label label21;
    }
}
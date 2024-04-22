namespace ProyDreamFoam_GUI
{
    partial class Asistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencias));
            dtgDiario = new DataGridView();
            codDiarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hIngresoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hSalidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hora1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hora2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hora3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hora4DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingrTardDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exeRefrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exeJorndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            observDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diarioBEBindingSource = new BindingSource(components);
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtFiltCodEmple = new TextBox();
            label4 = new Label();
            lblMensaje = new Label();
            btnModificar = new Button();
            txtNumReg = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDiario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diarioBEBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgDiario
            // 
            dtgDiario.AllowUserToAddRows = false;
            dtgDiario.AllowUserToDeleteRows = false;
            dtgDiario.AutoGenerateColumns = false;
            dtgDiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDiario.Columns.AddRange(new DataGridViewColumn[] { codDiarDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, empleadoDataGridViewTextBoxColumn, hIngresoDataGridViewTextBoxColumn, hSalidaDataGridViewTextBoxColumn, hora1DataGridViewTextBoxColumn, hora2DataGridViewTextBoxColumn, hora3DataGridViewTextBoxColumn, hora4DataGridViewTextBoxColumn, ingrTardDataGridViewTextBoxColumn, exeRefrDataGridViewTextBoxColumn, exeJorndDataGridViewTextBoxColumn, observDataGridViewTextBoxColumn });
            dtgDiario.DataSource = diarioBEBindingSource;
            dtgDiario.Location = new Point(21, 127);
            dtgDiario.Name = "dtgDiario";
            dtgDiario.ReadOnly = true;
            dtgDiario.RowTemplate.Height = 25;
            dtgDiario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDiario.Size = new Size(721, 274);
            dtgDiario.TabIndex = 0;
            dtgDiario.CellClick += dtgDiario_CellClick;
            dtgDiario.RowPrePaint += dtgDiario_RowPrePaint;
            // 
            // codDiarDataGridViewTextBoxColumn
            // 
            codDiarDataGridViewTextBoxColumn.DataPropertyName = "codDiar";
            codDiarDataGridViewTextBoxColumn.HeaderText = "Cod.";
            codDiarDataGridViewTextBoxColumn.Name = "codDiarDataGridViewTextBoxColumn";
            codDiarDataGridViewTextBoxColumn.ReadOnly = true;
            codDiarDataGridViewTextBoxColumn.Width = 50;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            fechaDataGridViewTextBoxColumn.Width = 90;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            empleadoDataGridViewTextBoxColumn.DataPropertyName = "empleado";
            empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            empleadoDataGridViewTextBoxColumn.ReadOnly = true;
            empleadoDataGridViewTextBoxColumn.Width = 70;
            // 
            // hIngresoDataGridViewTextBoxColumn
            // 
            hIngresoDataGridViewTextBoxColumn.DataPropertyName = "hIngreso";
            hIngresoDataGridViewTextBoxColumn.HeaderText = "Hora de Ingreso (Horario)";
            hIngresoDataGridViewTextBoxColumn.Name = "hIngresoDataGridViewTextBoxColumn";
            hIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            hIngresoDataGridViewTextBoxColumn.Width = 70;
            // 
            // hSalidaDataGridViewTextBoxColumn
            // 
            hSalidaDataGridViewTextBoxColumn.DataPropertyName = "hSalida";
            hSalidaDataGridViewTextBoxColumn.HeaderText = "Hora de Salida (Horario)";
            hSalidaDataGridViewTextBoxColumn.Name = "hSalidaDataGridViewTextBoxColumn";
            hSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            hSalidaDataGridViewTextBoxColumn.Width = 70;
            // 
            // hora1DataGridViewTextBoxColumn
            // 
            hora1DataGridViewTextBoxColumn.DataPropertyName = "hora1";
            hora1DataGridViewTextBoxColumn.HeaderText = "Hora Ingreso";
            hora1DataGridViewTextBoxColumn.Name = "hora1DataGridViewTextBoxColumn";
            hora1DataGridViewTextBoxColumn.ReadOnly = true;
            hora1DataGridViewTextBoxColumn.Width = 70;
            // 
            // hora2DataGridViewTextBoxColumn
            // 
            hora2DataGridViewTextBoxColumn.DataPropertyName = "hora2";
            hora2DataGridViewTextBoxColumn.HeaderText = "Hora Salida Refrigerio";
            hora2DataGridViewTextBoxColumn.Name = "hora2DataGridViewTextBoxColumn";
            hora2DataGridViewTextBoxColumn.ReadOnly = true;
            hora2DataGridViewTextBoxColumn.Width = 70;
            // 
            // hora3DataGridViewTextBoxColumn
            // 
            hora3DataGridViewTextBoxColumn.DataPropertyName = "hora3";
            hora3DataGridViewTextBoxColumn.HeaderText = "Hora Ingreso Refrigerio";
            hora3DataGridViewTextBoxColumn.Name = "hora3DataGridViewTextBoxColumn";
            hora3DataGridViewTextBoxColumn.ReadOnly = true;
            hora3DataGridViewTextBoxColumn.Width = 70;
            // 
            // hora4DataGridViewTextBoxColumn
            // 
            hora4DataGridViewTextBoxColumn.DataPropertyName = "hora4";
            hora4DataGridViewTextBoxColumn.HeaderText = "Hora Salida";
            hora4DataGridViewTextBoxColumn.Name = "hora4DataGridViewTextBoxColumn";
            hora4DataGridViewTextBoxColumn.ReadOnly = true;
            hora4DataGridViewTextBoxColumn.Width = 70;
            // 
            // ingrTardDataGridViewTextBoxColumn
            // 
            ingrTardDataGridViewTextBoxColumn.DataPropertyName = "ingrTard";
            ingrTardDataGridViewTextBoxColumn.HeaderText = "Tiempo Tardanza";
            ingrTardDataGridViewTextBoxColumn.Name = "ingrTardDataGridViewTextBoxColumn";
            ingrTardDataGridViewTextBoxColumn.ReadOnly = true;
            ingrTardDataGridViewTextBoxColumn.Width = 70;
            // 
            // exeRefrDataGridViewTextBoxColumn
            // 
            exeRefrDataGridViewTextBoxColumn.DataPropertyName = "exeRefr";
            exeRefrDataGridViewTextBoxColumn.HeaderText = "Exceso Refrigerio";
            exeRefrDataGridViewTextBoxColumn.Name = "exeRefrDataGridViewTextBoxColumn";
            exeRefrDataGridViewTextBoxColumn.ReadOnly = true;
            exeRefrDataGridViewTextBoxColumn.Width = 70;
            // 
            // exeJorndDataGridViewTextBoxColumn
            // 
            exeJorndDataGridViewTextBoxColumn.DataPropertyName = "exeJornd";
            exeJorndDataGridViewTextBoxColumn.HeaderText = "Exceso de Jornada";
            exeJorndDataGridViewTextBoxColumn.Name = "exeJorndDataGridViewTextBoxColumn";
            exeJorndDataGridViewTextBoxColumn.ReadOnly = true;
            exeJorndDataGridViewTextBoxColumn.Width = 70;
            // 
            // observDataGridViewTextBoxColumn
            // 
            observDataGridViewTextBoxColumn.DataPropertyName = "observ";
            observDataGridViewTextBoxColumn.HeaderText = "Observacion";
            observDataGridViewTextBoxColumn.Name = "observDataGridViewTextBoxColumn";
            observDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diarioBEBindingSource
            // 
            diarioBEBindingSource.DataSource = typeof(ProyDreamFoam_BE.DiarioBE);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 2;
            label1.Text = "Registro de asistencias por dia";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtFiltCodEmple);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(21, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 63);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(559, 20);
            button1.Name = "button1";
            button1.Size = new Size(156, 31);
            button1.TabIndex = 22;
            button1.Text = "REFRESCAR DATOS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtFiltCodEmple
            // 
            txtFiltCodEmple.BorderStyle = BorderStyle.FixedSingle;
            txtFiltCodEmple.Location = new Point(145, 26);
            txtFiltCodEmple.Name = "txtFiltCodEmple";
            txtFiltCodEmple.Size = new Size(128, 23);
            txtFiltCodEmple.TabIndex = 3;
            txtFiltCodEmple.TextChanged += txtFiltCodEmple_TextChanged;
            txtFiltCodEmple.KeyPress += txtFiltCodEmple_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 29);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 2;
            label4.Text = "Codigo de Empleado:";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(21, 546);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 21;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(636, 432);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(106, 48);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNumReg
            // 
            txtNumReg.BorderStyle = BorderStyle.FixedSingle;
            txtNumReg.Location = new Point(115, 415);
            txtNumReg.Name = "txtNumReg";
            txtNumReg.ReadOnly = true;
            txtNumReg.Size = new Size(45, 23);
            txtNumReg.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 418);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 18;
            label3.Text = "Nro. Registros:";
            // 
            // Asistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(770, 570);
            Controls.Add(btnModificar);
            Controls.Add(lblMensaje);
            Controls.Add(txtNumReg);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dtgDiario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Asistencias";
            Text = "Asistencias";
            WindowState = FormWindowState.Maximized;
            Load += Asistencias_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDiario).EndInit();
            ((System.ComponentModel.ISupportInitialize)diarioBEBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDiario;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblMensaje;
        private Button btnModificar;
        private TextBox txtNumReg;
        private Label label3;
        private BindingSource diarioBEBindingSource;
        private DataGridViewTextBoxColumn codDiarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hIngresoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hSalidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hora1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hora2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hora3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hora4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingrTardDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exeRefrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exeJorndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observDataGridViewTextBoxColumn;
        private TextBox txtFiltCodEmple;
        private Label label4;
        private Button button1;
    }
}
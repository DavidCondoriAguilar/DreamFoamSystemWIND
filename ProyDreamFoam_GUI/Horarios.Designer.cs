namespace ProyDreamFoam_GUI
{
    partial class Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horarios));
            label1 = new Label();
            gbFiltros = new GroupBox();
            txtHorNom = new TextBox();
            label2 = new Label();
            dtgHorarios = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            desHorarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingLUNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salLUNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingMARDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salMARDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingMIEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salMIEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingJUEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salJUEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingVIEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salVIEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingSABDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salSABDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingDOMDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salDOMDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            refrigerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tolerncDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horarioBEBindingSource = new BindingSource(components);
            lblMensaje = new Label();
            gbMantHora = new GroupBox();
            btnNuevo = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtNumReg = new TextBox();
            label3 = new Label();
            gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHorarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horarioBEBindingSource).BeginInit();
            gbMantHora.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 2;
            label1.Text = "Horarios";
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(txtHorNom);
            gbFiltros.Controls.Add(label2);
            gbFiltros.Location = new Point(21, 47);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(731, 71);
            gbFiltros.TabIndex = 3;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Busqueda:";
            // 
            // txtHorNom
            // 
            txtHorNom.BorderStyle = BorderStyle.FixedSingle;
            txtHorNom.Location = new Point(148, 27);
            txtHorNom.Name = "txtHorNom";
            txtHorNom.Size = new Size(338, 23);
            txtHorNom.TabIndex = 1;
            txtHorNom.TextChanged += txtHorNom_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 30);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre de horario:";
            // 
            // dtgHorarios
            // 
            dtgHorarios.AllowUserToAddRows = false;
            dtgHorarios.AllowUserToDeleteRows = false;
            dtgHorarios.AutoGenerateColumns = false;
            dtgHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHorarios.Columns.AddRange(new DataGridViewColumn[] { Column1, desHorarioDataGridViewTextBoxColumn, ingLUNDataGridViewTextBoxColumn, salLUNDataGridViewTextBoxColumn, ingMARDataGridViewTextBoxColumn, salMARDataGridViewTextBoxColumn, ingMIEDataGridViewTextBoxColumn, salMIEDataGridViewTextBoxColumn, ingJUEDataGridViewTextBoxColumn, salJUEDataGridViewTextBoxColumn, ingVIEDataGridViewTextBoxColumn, salVIEDataGridViewTextBoxColumn, ingSABDataGridViewTextBoxColumn, salSABDataGridViewTextBoxColumn, ingDOMDataGridViewTextBoxColumn, salDOMDataGridViewTextBoxColumn, refrigerDataGridViewTextBoxColumn, tolerncDataGridViewTextBoxColumn, diaDescDataGridViewTextBoxColumn });
            dtgHorarios.DataSource = horarioBEBindingSource;
            dtgHorarios.Location = new Point(21, 124);
            dtgHorarios.Name = "dtgHorarios";
            dtgHorarios.ReadOnly = true;
            dtgHorarios.RowTemplate.Height = 25;
            dtgHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgHorarios.Size = new Size(731, 274);
            dtgHorarios.TabIndex = 4;
            dtgHorarios.CellClick += dtgHorarios_CellClick;
            dtgHorarios.CellFormatting += dtgHorarios_CellFormatting;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "codHorario";
            Column1.HeaderText = "Cod.";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 40;
            // 
            // desHorarioDataGridViewTextBoxColumn
            // 
            desHorarioDataGridViewTextBoxColumn.DataPropertyName = "desHorario";
            desHorarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            desHorarioDataGridViewTextBoxColumn.Name = "desHorarioDataGridViewTextBoxColumn";
            desHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingLUNDataGridViewTextBoxColumn
            // 
            ingLUNDataGridViewTextBoxColumn.DataPropertyName = "ingLUN";
            ingLUNDataGridViewTextBoxColumn.HeaderText = "Ingreso Lunes";
            ingLUNDataGridViewTextBoxColumn.Name = "ingLUNDataGridViewTextBoxColumn";
            ingLUNDataGridViewTextBoxColumn.ReadOnly = true;
            ingLUNDataGridViewTextBoxColumn.Width = 60;
            // 
            // salLUNDataGridViewTextBoxColumn
            // 
            salLUNDataGridViewTextBoxColumn.DataPropertyName = "salLUN";
            salLUNDataGridViewTextBoxColumn.HeaderText = "Salida Lunes";
            salLUNDataGridViewTextBoxColumn.Name = "salLUNDataGridViewTextBoxColumn";
            salLUNDataGridViewTextBoxColumn.ReadOnly = true;
            salLUNDataGridViewTextBoxColumn.Width = 60;
            // 
            // ingMARDataGridViewTextBoxColumn
            // 
            ingMARDataGridViewTextBoxColumn.DataPropertyName = "ingMAR";
            ingMARDataGridViewTextBoxColumn.HeaderText = "Ingreso Martes";
            ingMARDataGridViewTextBoxColumn.Name = "ingMARDataGridViewTextBoxColumn";
            ingMARDataGridViewTextBoxColumn.ReadOnly = true;
            ingMARDataGridViewTextBoxColumn.Width = 60;
            // 
            // salMARDataGridViewTextBoxColumn
            // 
            salMARDataGridViewTextBoxColumn.DataPropertyName = "salMAR";
            salMARDataGridViewTextBoxColumn.HeaderText = "Salida Martes";
            salMARDataGridViewTextBoxColumn.Name = "salMARDataGridViewTextBoxColumn";
            salMARDataGridViewTextBoxColumn.ReadOnly = true;
            salMARDataGridViewTextBoxColumn.Width = 60;
            // 
            // ingMIEDataGridViewTextBoxColumn
            // 
            ingMIEDataGridViewTextBoxColumn.DataPropertyName = "ingMIE";
            ingMIEDataGridViewTextBoxColumn.HeaderText = "Ingreso Miercoles";
            ingMIEDataGridViewTextBoxColumn.Name = "ingMIEDataGridViewTextBoxColumn";
            ingMIEDataGridViewTextBoxColumn.ReadOnly = true;
            ingMIEDataGridViewTextBoxColumn.Width = 60;
            // 
            // salMIEDataGridViewTextBoxColumn
            // 
            salMIEDataGridViewTextBoxColumn.DataPropertyName = "salMIE";
            salMIEDataGridViewTextBoxColumn.HeaderText = "Salida Miercoles";
            salMIEDataGridViewTextBoxColumn.Name = "salMIEDataGridViewTextBoxColumn";
            salMIEDataGridViewTextBoxColumn.ReadOnly = true;
            salMIEDataGridViewTextBoxColumn.Width = 60;
            // 
            // ingJUEDataGridViewTextBoxColumn
            // 
            ingJUEDataGridViewTextBoxColumn.DataPropertyName = "ingJUE";
            ingJUEDataGridViewTextBoxColumn.HeaderText = "Ingreso Jueves";
            ingJUEDataGridViewTextBoxColumn.Name = "ingJUEDataGridViewTextBoxColumn";
            ingJUEDataGridViewTextBoxColumn.ReadOnly = true;
            ingJUEDataGridViewTextBoxColumn.Width = 60;
            // 
            // salJUEDataGridViewTextBoxColumn
            // 
            salJUEDataGridViewTextBoxColumn.DataPropertyName = "salJUE";
            salJUEDataGridViewTextBoxColumn.HeaderText = "Salida de Jueves";
            salJUEDataGridViewTextBoxColumn.Name = "salJUEDataGridViewTextBoxColumn";
            salJUEDataGridViewTextBoxColumn.ReadOnly = true;
            salJUEDataGridViewTextBoxColumn.Width = 60;
            // 
            // ingVIEDataGridViewTextBoxColumn
            // 
            ingVIEDataGridViewTextBoxColumn.DataPropertyName = "ingVIE";
            ingVIEDataGridViewTextBoxColumn.HeaderText = "Ingreso Viernes";
            ingVIEDataGridViewTextBoxColumn.Name = "ingVIEDataGridViewTextBoxColumn";
            ingVIEDataGridViewTextBoxColumn.ReadOnly = true;
            ingVIEDataGridViewTextBoxColumn.Width = 60;
            // 
            // salVIEDataGridViewTextBoxColumn
            // 
            salVIEDataGridViewTextBoxColumn.DataPropertyName = "salVIE";
            salVIEDataGridViewTextBoxColumn.HeaderText = "Salida Viernes";
            salVIEDataGridViewTextBoxColumn.Name = "salVIEDataGridViewTextBoxColumn";
            salVIEDataGridViewTextBoxColumn.ReadOnly = true;
            salVIEDataGridViewTextBoxColumn.Width = 60;
            // 
            // ingSABDataGridViewTextBoxColumn
            // 
            ingSABDataGridViewTextBoxColumn.DataPropertyName = "ingSAB";
            ingSABDataGridViewTextBoxColumn.HeaderText = "Ingreso Sabado";
            ingSABDataGridViewTextBoxColumn.Name = "ingSABDataGridViewTextBoxColumn";
            ingSABDataGridViewTextBoxColumn.ReadOnly = true;
            ingSABDataGridViewTextBoxColumn.Width = 60;
            // 
            // salSABDataGridViewTextBoxColumn
            // 
            salSABDataGridViewTextBoxColumn.DataPropertyName = "salSAB";
            salSABDataGridViewTextBoxColumn.HeaderText = "Salida Sabado";
            salSABDataGridViewTextBoxColumn.Name = "salSABDataGridViewTextBoxColumn";
            salSABDataGridViewTextBoxColumn.ReadOnly = true;
            salSABDataGridViewTextBoxColumn.Width = 60;
            // 
            // ingDOMDataGridViewTextBoxColumn
            // 
            ingDOMDataGridViewTextBoxColumn.DataPropertyName = "ingDOM";
            ingDOMDataGridViewTextBoxColumn.HeaderText = "Ingreso Domingo";
            ingDOMDataGridViewTextBoxColumn.Name = "ingDOMDataGridViewTextBoxColumn";
            ingDOMDataGridViewTextBoxColumn.ReadOnly = true;
            ingDOMDataGridViewTextBoxColumn.Width = 60;
            // 
            // salDOMDataGridViewTextBoxColumn
            // 
            salDOMDataGridViewTextBoxColumn.DataPropertyName = "salDOM";
            salDOMDataGridViewTextBoxColumn.HeaderText = "Salida Domingo";
            salDOMDataGridViewTextBoxColumn.Name = "salDOMDataGridViewTextBoxColumn";
            salDOMDataGridViewTextBoxColumn.ReadOnly = true;
            salDOMDataGridViewTextBoxColumn.Width = 60;
            // 
            // refrigerDataGridViewTextBoxColumn
            // 
            refrigerDataGridViewTextBoxColumn.DataPropertyName = "refriger";
            refrigerDataGridViewTextBoxColumn.HeaderText = "Tiempo Refrigerio (mins)";
            refrigerDataGridViewTextBoxColumn.Name = "refrigerDataGridViewTextBoxColumn";
            refrigerDataGridViewTextBoxColumn.ReadOnly = true;
            refrigerDataGridViewTextBoxColumn.Width = 60;
            // 
            // tolerncDataGridViewTextBoxColumn
            // 
            tolerncDataGridViewTextBoxColumn.DataPropertyName = "tolernc";
            tolerncDataGridViewTextBoxColumn.HeaderText = "Tiempo Tolerancia (mins)";
            tolerncDataGridViewTextBoxColumn.Name = "tolerncDataGridViewTextBoxColumn";
            tolerncDataGridViewTextBoxColumn.ReadOnly = true;
            tolerncDataGridViewTextBoxColumn.Width = 60;
            // 
            // diaDescDataGridViewTextBoxColumn
            // 
            diaDescDataGridViewTextBoxColumn.DataPropertyName = "diaDesc";
            diaDescDataGridViewTextBoxColumn.HeaderText = "Dias de Descanso Semanal";
            diaDescDataGridViewTextBoxColumn.Name = "diaDescDataGridViewTextBoxColumn";
            diaDescDataGridViewTextBoxColumn.ReadOnly = true;
            diaDescDataGridViewTextBoxColumn.Width = 60;
            // 
            // horarioBEBindingSource
            // 
            horarioBEBindingSource.DataSource = typeof(ProyDreamFoam_BE.HorarioBE);
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(45, 541);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 21;
            // 
            // gbMantHora
            // 
            gbMantHora.Controls.Add(btnNuevo);
            gbMantHora.Controls.Add(btnModificar);
            gbMantHora.Controls.Add(btnEliminar);
            gbMantHora.Location = new Point(426, 413);
            gbMantHora.Name = "gbMantHora";
            gbMantHora.Size = new Size(326, 100);
            gbMantHora.TabIndex = 20;
            gbMantHora.TabStop = false;
            gbMantHora.Text = "Mantenimiento de Horarios";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Black;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = SystemColors.ControlLightLight;
            btnNuevo.Location = new Point(114, 31);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(92, 48);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(17, 31);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(91, 48);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(212, 31);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 48);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNumReg
            // 
            txtNumReg.BorderStyle = BorderStyle.FixedSingle;
            txtNumReg.Location = new Point(125, 410);
            txtNumReg.Name = "txtNumReg";
            txtNumReg.ReadOnly = true;
            txtNumReg.Size = new Size(45, 23);
            txtNumReg.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 413);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 18;
            label3.Text = "Nro. Registros:";
            // 
            // Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(774, 571);
            Controls.Add(lblMensaje);
            Controls.Add(gbMantHora);
            Controls.Add(txtNumReg);
            Controls.Add(label3);
            Controls.Add(dtgHorarios);
            Controls.Add(gbFiltros);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Horarios";
            Text = "Horarios";
            WindowState = FormWindowState.Maximized;
            Load += Horarios_Load;
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHorarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)horarioBEBindingSource).EndInit();
            gbMantHora.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbFiltros;
        private Label label2;
        private TextBox txtHorNom;
        private DataGridView dtgHorarios;
        private Label lblMensaje;
        private GroupBox gbMantHora;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtNumReg;
        private Label label3;
        private BindingSource horarioBEBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn desHorarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingLUNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salLUNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingMARDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salMARDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingMIEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salMIEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingJUEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salJUEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingVIEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salVIEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingSABDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salSABDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingDOMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salDOMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn refrigerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tolerncDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDescDataGridViewTextBoxColumn;
    }
}
namespace examen_practico_ra2_WilmerOPp
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.rbnFemenino = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAreaTecnica = new System.Windows.Forms.Label();
            this.cboAreaTecnica = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.C_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_AreaTecnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_MaestroTitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMaestroTitular = new System.Windows.Forms.Label();
            this.txtMaestroTitular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(32, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 33);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(31, 24);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(127, 33);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(25, 204);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(125, 33);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(25, 298);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(110, 33);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Brown;
            this.lblGenero.Location = new System.Drawing.Point(1074, 87);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(101, 32);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero";
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMasculino.Location = new System.Drawing.Point(1198, 87);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(158, 37);
            this.rbnMasculino.TabIndex = 5;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbnFemenino
            // 
            this.rbnFemenino.AutoSize = true;
            this.rbnFemenino.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFemenino.Location = new System.Drawing.Point(1389, 85);
            this.rbnFemenino.Name = "rbnFemenino";
            this.rbnFemenino.Size = new System.Drawing.Size(150, 37);
            this.rbnFemenino.TabIndex = 6;
            this.rbnFemenino.TabStop = true;
            this.rbnFemenino.Text = "Femenino";
            this.rbnFemenino.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(462, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 33);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(169, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(456, 40);
            this.txtNombre.TabIndex = 8;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.Brown;
            this.txtMatricula.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMatricula.Location = new System.Drawing.Point(169, 17);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(240, 40);
            this.txtMatricula.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(169, 201);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(456, 40);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(169, 295);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(240, 40);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.GreenYellow;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(553, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(386, 40);
            this.txtEmail.TabIndex = 12;
            // 
            // lblAreaTecnica
            // 
            this.lblAreaTecnica.AutoSize = true;
            this.lblAreaTecnica.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaTecnica.Location = new System.Drawing.Point(445, 299);
            this.lblAreaTecnica.Name = "lblAreaTecnica";
            this.lblAreaTecnica.Size = new System.Drawing.Size(160, 33);
            this.lblAreaTecnica.TabIndex = 13;
            this.lblAreaTecnica.Text = "Area Tecnica";
            // 
            // cboAreaTecnica
            // 
            this.cboAreaTecnica.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAreaTecnica.FormattingEnabled = true;
            this.cboAreaTecnica.Items.AddRange(new object[] {
            "Informatica",
            "Enfermeria",
            "Contabilidad",
            "Electricidad",
            "Gastronomia"});
            this.cboAreaTecnica.Location = new System.Drawing.Point(623, 294);
            this.cboAreaTecnica.Name = "cboAreaTecnica";
            this.cboAreaTecnica.Size = new System.Drawing.Size(265, 41);
            this.cboAreaTecnica.TabIndex = 14;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(660, 115);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(84, 33);
            this.lblCurso.TabIndex = 15;
            this.lblCurso.Text = "Curso";
            // 
            // cboCurso
            // 
            this.cboCurso.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Items.AddRange(new object[] {
            "4to",
            "5to",
            "6to"});
            this.cboCurso.Location = new System.Drawing.Point(780, 112);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 41);
            this.cboCurso.TabIndex = 16;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(657, 210);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(101, 33);
            this.lblSeccion.TabIndex = 17;
            this.lblSeccion.Text = "Seccion";
            // 
            // cboSeccion
            // 
            this.cboSeccion.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Items.AddRange(new object[] {
            "D1",
            "D2",
            "B",
            "C",
            "A1",
            "A2",
            "A3",
            "E"});
            this.cboSeccion.Location = new System.Drawing.Point(780, 196);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(121, 41);
            this.cboSeccion.TabIndex = 18;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNuevo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(809, 695);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 44);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1134, 689);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 50);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Snow;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(1287, 689);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 49);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(1442, 689);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 49);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Matricula,
            this.C_Nombre,
            this.C_Direccion,
            this.C_Telefono,
            this.C_Genero,
            this.C_Email,
            this.C_Curso,
            this.C_Seccion,
            this.C_AreaTecnica,
            this.C_MaestroTitular});
            this.dgvDatos.Location = new System.Drawing.Point(11, 440);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(1565, 150);
            this.dgvDatos.TabIndex = 24;
            // 
            // C_Matricula
            // 
            this.C_Matricula.HeaderText = "Matricula";
            this.C_Matricula.MinimumWidth = 8;
            this.C_Matricula.Name = "C_Matricula";
            this.C_Matricula.Width = 150;
            // 
            // C_Nombre
            // 
            this.C_Nombre.HeaderText = "Nombre";
            this.C_Nombre.MinimumWidth = 8;
            this.C_Nombre.Name = "C_Nombre";
            this.C_Nombre.Width = 150;
            // 
            // C_Direccion
            // 
            this.C_Direccion.HeaderText = "Direccion";
            this.C_Direccion.MinimumWidth = 8;
            this.C_Direccion.Name = "C_Direccion";
            this.C_Direccion.Width = 150;
            // 
            // C_Telefono
            // 
            this.C_Telefono.HeaderText = "Telefono";
            this.C_Telefono.MinimumWidth = 8;
            this.C_Telefono.Name = "C_Telefono";
            this.C_Telefono.Width = 150;
            // 
            // C_Genero
            // 
            this.C_Genero.HeaderText = "Genero";
            this.C_Genero.MinimumWidth = 8;
            this.C_Genero.Name = "C_Genero";
            this.C_Genero.Width = 150;
            // 
            // C_Email
            // 
            this.C_Email.HeaderText = "Email";
            this.C_Email.MinimumWidth = 8;
            this.C_Email.Name = "C_Email";
            this.C_Email.Width = 150;
            // 
            // C_Curso
            // 
            this.C_Curso.HeaderText = "Curso";
            this.C_Curso.MinimumWidth = 8;
            this.C_Curso.Name = "C_Curso";
            this.C_Curso.Width = 150;
            // 
            // C_Seccion
            // 
            this.C_Seccion.HeaderText = "Seccion";
            this.C_Seccion.MinimumWidth = 8;
            this.C_Seccion.Name = "C_Seccion";
            this.C_Seccion.Width = 150;
            // 
            // C_AreaTecnica
            // 
            this.C_AreaTecnica.HeaderText = "Area Tecnica";
            this.C_AreaTecnica.MinimumWidth = 8;
            this.C_AreaTecnica.Name = "C_AreaTecnica";
            this.C_AreaTecnica.Width = 150;
            // 
            // C_MaestroTitular
            // 
            this.C_MaestroTitular.HeaderText = "Maestro Titular";
            this.C_MaestroTitular.MinimumWidth = 8;
            this.C_MaestroTitular.Name = "C_MaestroTitular";
            this.C_MaestroTitular.Width = 150;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(962, 689);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 50);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMaestroTitular
            // 
            this.lblMaestroTitular.AutoSize = true;
            this.lblMaestroTitular.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestroTitular.Location = new System.Drawing.Point(1074, 20);
            this.lblMaestroTitular.Name = "lblMaestroTitular";
            this.lblMaestroTitular.Size = new System.Drawing.Size(191, 33);
            this.lblMaestroTitular.TabIndex = 26;
            this.lblMaestroTitular.Text = "Maestro Titular";
            // 
            // txtMaestroTitular
            // 
            this.txtMaestroTitular.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaestroTitular.Location = new System.Drawing.Point(1294, 20);
            this.txtMaestroTitular.Name = "txtMaestroTitular";
            this.txtMaestroTitular.Size = new System.Drawing.Size(258, 40);
            this.txtMaestroTitular.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 767);
            this.Controls.Add(this.txtMaestroTitular);
            this.Controls.Add(this.lblMaestroTitular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cboSeccion);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cboAreaTecnica);
            this.Controls.Add(this.lblAreaTecnica);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.rbnFemenino);
            this.Controls.Add(this.rbnMasculino);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.RadioButton rbnFemenino;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAreaTecnica;
        private System.Windows.Forms.ComboBox cboAreaTecnica;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AreaTecnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_MaestroTitular;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMaestroTitular;
        private System.Windows.Forms.TextBox txtMaestroTitular;
    }
}


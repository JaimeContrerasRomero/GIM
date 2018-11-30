namespace SistemaGIM
{
    partial class Usuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsetar = new System.Windows.Forms.Button();
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.BS1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new SistemaGIM.ds();
            this.tbApellido2 = new System.Windows.Forms.TextBox();
            this.tbApellido1 = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gvDatos = new System.Windows.Forms.DataGridView();
            this.BN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UsuarioTA = new SistemaGIM.dsTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new SistemaGIM.dsTableAdapters.TableAdapterManager();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idUsuarioLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN1)).BeginInit();
            this.BN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(12, 21);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 21;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(139, 18);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 22;
            correoLabel.Text = "Correo:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(272, 18);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 23;
            passwordLabel.Text = "Password:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 77);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 24;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(139, 77);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 25;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(266, 77);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 26;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(496, 18);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 27;
            fotoLabel.Text = "Foto:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnReporte);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnInsetar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(893, 52);
            this.pnlBotones.TabIndex = 4;
            // 
            // btnReporte
            // 
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(156, 6);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(42, 43);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(108, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(42, 43);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(60, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(42, 43);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsetar
            // 
            this.btnInsetar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsetar.Image")));
            this.btnInsetar.Location = new System.Drawing.Point(12, 6);
            this.btnInsetar.Name = "btnInsetar";
            this.btnInsetar.Size = new System.Drawing.Size(42, 43);
            this.btnInsetar.TabIndex = 0;
            this.btnInsetar.UseVisualStyleBackColor = true;
            this.btnInsetar.Click += new System.EventHandler(this.btnInsetar_Click);
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.Controls.Add(fotoLabel);
            this.pnlRegistros.Controls.Add(this.pbFoto);
            this.pnlRegistros.Controls.Add(segundoApellidoLabel);
            this.pnlRegistros.Controls.Add(this.tbApellido2);
            this.pnlRegistros.Controls.Add(primerApellidoLabel);
            this.pnlRegistros.Controls.Add(this.tbApellido1);
            this.pnlRegistros.Controls.Add(nombreLabel);
            this.pnlRegistros.Controls.Add(this.tbNombre);
            this.pnlRegistros.Controls.Add(passwordLabel);
            this.pnlRegistros.Controls.Add(this.tbContraseña);
            this.pnlRegistros.Controls.Add(correoLabel);
            this.pnlRegistros.Controls.Add(this.tbEmail);
            this.pnlRegistros.Controls.Add(idUsuarioLabel);
            this.pnlRegistros.Controls.Add(this.tbUsuario);
            this.pnlRegistros.Controls.Add(this.label7);
            this.pnlRegistros.Controls.Add(this.btnFoto);
            this.pnlRegistros.Controls.Add(this.btnCancelar);
            this.pnlRegistros.Controls.Add(this.btnGuardar);
            this.pnlRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRegistros.Location = new System.Drawing.Point(0, 596);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(893, 153);
            this.pnlRegistros.TabIndex = 5;
            // 
            // pbFoto
            // 
            this.pbFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.BS1, "Foto", true));
            this.pbFoto.Location = new System.Drawing.Point(499, 34);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(100, 79);
            this.pbFoto.TabIndex = 28;
            this.pbFoto.TabStop = false;
            // 
            // BS1
            // 
            this.BS1.DataMember = "Usuario";
            this.BS1.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbApellido2
            // 
            this.tbApellido2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS1, "SegundoApellido", true));
            this.tbApellido2.Location = new System.Drawing.Point(269, 93);
            this.tbApellido2.Name = "tbApellido2";
            this.tbApellido2.Size = new System.Drawing.Size(121, 20);
            this.tbApellido2.TabIndex = 27;
            // 
            // tbApellido1
            // 
            this.tbApellido1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS1, "PrimerApellido", true));
            this.tbApellido1.Location = new System.Drawing.Point(142, 93);
            this.tbApellido1.Name = "tbApellido1";
            this.tbApellido1.Size = new System.Drawing.Size(121, 20);
            this.tbApellido1.TabIndex = 26;
            // 
            // tbNombre
            // 
            this.tbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS1, "Nombre", true));
            this.tbNombre.Location = new System.Drawing.Point(15, 93);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 25;
            // 
            // tbContraseña
            // 
            this.tbContraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS1, "Password", true));
            this.tbContraseña.Location = new System.Drawing.Point(269, 37);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(121, 20);
            this.tbContraseña.TabIndex = 24;
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS1, "Correo", true));
            this.tbEmail.Location = new System.Drawing.Point(142, 37);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(121, 20);
            this.tbEmail.TabIndex = 23;
            // 
            // tbUsuario
            // 
            this.tbUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS1, "IdUsuario", true));
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Location = new System.Drawing.Point(15, 37);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(121, 20);
            this.tbUsuario.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Añadir foto";
            // 
            // btnFoto
            // 
            this.btnFoto.Image = global::SistemaGIM.Properties.Resources.add_photo;
            this.btnFoto.Location = new System.Drawing.Point(411, 34);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(82, 79);
            this.btnFoto.TabIndex = 20;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(732, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 54);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(645, 59);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(58, 54);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.gvDatos);
            this.pnlDatos.Controls.Add(this.BN1);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 52);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(893, 544);
            this.pnlDatos.TabIndex = 6;
            // 
            // gvDatos
            // 
            this.gvDatos.AllowUserToAddRows = false;
            this.gvDatos.AllowUserToDeleteRows = false;
            this.gvDatos.AllowUserToResizeRows = false;
            this.gvDatos.AutoGenerateColumns = false;
            this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.fotoDataGridViewImageColumn,
            this.correoDataGridViewTextBoxColumn});
            this.gvDatos.DataSource = this.BS1;
            this.gvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDatos.Location = new System.Drawing.Point(0, 27);
            this.gvDatos.MultiSelect = false;
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.ReadOnly = true;
            this.gvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatos.Size = new System.Drawing.Size(893, 517);
            this.gvDatos.TabIndex = 1;
            // 
            // BN1
            // 
            this.BN1.AddNewItem = null;
            this.BN1.BindingSource = this.BS1;
            this.BN1.CountItem = this.bindingNavigatorCountItem;
            this.BN1.DeleteItem = null;
            this.BN1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.BN1.Location = new System.Drawing.Point(0, 0);
            this.BN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BN1.Name = "BN1";
            this.BN1.PositionItem = this.bindingNavigatorPositionItem;
            this.BN1.Size = new System.Drawing.Size(893, 27);
            this.BN1.TabIndex = 0;
            this.BN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // UsuarioTA
            // 
            this.UsuarioTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BitacoraTableAdapter = null;
            this.tableAdapterManager.CompraDetalleTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.EquipoTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.MembresiaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.SocioAsistenciaTableAdapter = null;
            this.tableAdapterManager.SocioMembresiaTableAdapter = null;
            this.tableAdapterManager.SocioPesoTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaGIM.dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.UsuarioTA;
            // 
            // OFD
            // 
            this.OFD.FileName = "Imagen de Perfil";
            this.OFD.Filter = "Imagen JPG|*.jpg|Imagen PNG|*.png";
            this.OFD.Title = "Cargar Imagen de Perfil";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID de Usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PrimerApellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido Paterno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SegundoApellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido Materno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            this.fotoDataGridViewImageColumn.Width = 120;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(893, 749);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlRegistros);
            this.Controls.Add(this.pnlBotones);
            this.Name = "Usuarios";
            this.ShowIcon = false;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN1)).EndInit();
            this.BN1.ResumeLayout(false);
            this.BN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsetar;
        private System.Windows.Forms.Panel pnlRegistros;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.DataGridView gvDatos;
        private System.Windows.Forms.BindingNavigator BN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource BS1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label7;
        private ds ds;
        private dsTableAdapters.UsuarioTableAdapter UsuarioTA;
        private System.Windows.Forms.TextBox tbApellido2;
        private System.Windows.Forms.TextBox tbApellido1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUsuario;
        private dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
    }
}
namespace SistemaGIM
{
    partial class GridUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUsuarios));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsetar = new System.Windows.Forms.Button();
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApellido2 = new System.Windows.Forms.TextBox();
            this.tbApellido1 = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
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
            this.BS1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new SistemaGIM.ds();
            this.UsuarioTA = new SistemaGIM.dsTableAdapters.UsuarioTableAdapter();
            this.TAM1 = new SistemaGIM.dsTableAdapters.TableAdapterManager();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones.SuspendLayout();
            this.pnlRegistros.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN1)).BeginInit();
            this.BN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
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
            this.pnlBotones.Size = new System.Drawing.Size(800, 52);
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
            this.pnlRegistros.Controls.Add(this.label7);
            this.pnlRegistros.Controls.Add(this.btnFoto);
            this.pnlRegistros.Controls.Add(this.label4);
            this.pnlRegistros.Controls.Add(this.label5);
            this.pnlRegistros.Controls.Add(this.label6);
            this.pnlRegistros.Controls.Add(this.label3);
            this.pnlRegistros.Controls.Add(this.label2);
            this.pnlRegistros.Controls.Add(this.label1);
            this.pnlRegistros.Controls.Add(this.tbApellido2);
            this.pnlRegistros.Controls.Add(this.tbApellido1);
            this.pnlRegistros.Controls.Add(this.tbNombre);
            this.pnlRegistros.Controls.Add(this.tbEmail);
            this.pnlRegistros.Controls.Add(this.tbContraseña);
            this.pnlRegistros.Controls.Add(this.tbUsuario);
            this.pnlRegistros.Controls.Add(this.btnCancelar);
            this.pnlRegistros.Controls.Add(this.btnGuardar);
            this.pnlRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRegistros.Location = new System.Drawing.Point(0, 309);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(800, 141);
            this.pnlRegistros.TabIndex = 5;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Primer Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Correo electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID del Usuario";
            // 
            // tbApellido2
            // 
            this.tbApellido2.Location = new System.Drawing.Point(270, 93);
            this.tbApellido2.Name = "tbApellido2";
            this.tbApellido2.Size = new System.Drawing.Size(123, 20);
            this.tbApellido2.TabIndex = 13;
            // 
            // tbApellido1
            // 
            this.tbApellido1.Location = new System.Drawing.Point(141, 93);
            this.tbApellido1.Name = "tbApellido1";
            this.tbApellido1.Size = new System.Drawing.Size(123, 20);
            this.tbApellido1.TabIndex = 12;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 93);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(123, 20);
            this.tbNombre.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 34);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(123, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(273, 34);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(123, 20);
            this.tbContraseña.TabIndex = 9;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(12, 34);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.ReadOnly = true;
            this.tbUsuario.Size = new System.Drawing.Size(123, 20);
            this.tbUsuario.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(730, 75);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 54);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(666, 75);
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
            this.pnlDatos.Size = new System.Drawing.Size(800, 257);
            this.pnlDatos.TabIndex = 6;
            // 
            // gvDatos
            // 
            this.gvDatos.AllowUserToAddRows = false;
            this.gvDatos.AllowUserToDeleteRows = false;
            this.gvDatos.AutoGenerateColumns = false;
            this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn,
            this.segundoApellidoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.gvDatos.DataSource = this.BS1;
            this.gvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDatos.Location = new System.Drawing.Point(0, 27);
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.ReadOnly = true;
            this.gvDatos.Size = new System.Drawing.Size(800, 230);
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
            this.BN1.Size = new System.Drawing.Size(800, 27);
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
            // UsuarioTA
            // 
            this.UsuarioTA.ClearBeforeFill = true;
            // 
            // TAM1
            // 
            this.TAM1.BackupDataSetBeforeUpdate = false;
            this.TAM1.BitacoraTableAdapter = null;
            this.TAM1.CompraDetalleTableAdapter = null;
            this.TAM1.CompraTableAdapter = null;
            this.TAM1.EquipoTableAdapter = null;
            this.TAM1.InventarioTableAdapter = null;
            this.TAM1.MembresiaTableAdapter = null;
            this.TAM1.ProductoTableAdapter = null;
            this.TAM1.ProveedorTableAdapter = null;
            this.TAM1.SocioAsistenciaTableAdapter = null;
            this.TAM1.SocioMembresiaTableAdapter = null;
            this.TAM1.SocioPesoTableAdapter = null;
            this.TAM1.SocioTableAdapter = null;
            this.TAM1.UpdateOrder = SistemaGIM.dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.TAM1.UsuarioTableAdapter = this.UsuarioTA;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID del Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "Primer Apellido";
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "PrimerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            this.primerApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            this.segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "Segundo Apellido";
            this.segundoApellidoDataGridViewTextBoxColumn.HeaderText = "SegundoApellido";
            this.segundoApellidoDataGridViewTextBoxColumn.Name = "segundoApellidoDataGridViewTextBoxColumn";
            this.segundoApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GridUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlRegistros);
            this.Controls.Add(this.pnlBotones);
            this.Name = "GridUsuarios";
            this.ShowIcon = false;
            this.Text = "Usuarios";
            this.pnlBotones.ResumeLayout(false);
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN1)).EndInit();
            this.BN1.ResumeLayout(false);
            this.BN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
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
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbApellido2;
        private System.Windows.Forms.TextBox tbApellido1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label7;
        private ds ds;
        private dsTableAdapters.UsuarioTableAdapter UsuarioTA;
        private dsTableAdapters.TableAdapterManager TAM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbUsuario;
    }
}
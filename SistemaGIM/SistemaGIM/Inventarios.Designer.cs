namespace SistemaGIM
{
    partial class Inventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventarios));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsetar = new System.Windows.Forms.Button();
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.data_producto = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binding_producto = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new SistemaGIM.ds();
            this.navi_producto = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_inventario = new System.Windows.Forms.DataGridView();
            this.idInventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binding_inventario = new System.Windows.Forms.BindingSource(this.components);
            this.navi_inventario = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inventarioTableAdapter = new SistemaGIM.dsTableAdapters.InventarioTableAdapter();
            this.productoTableAdapter = new SistemaGIM.dsTableAdapters.ProductoTableAdapter();
            this.pnlBotones.SuspendLayout();
            this.pnlRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navi_producto)).BeginInit();
            this.navi_producto.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navi_inventario)).BeginInit();
            this.navi_inventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.txt_buscar);
            this.pnlBotones.Controls.Add(this.btn_buscar);
            this.pnlBotones.Controls.Add(this.btnReporte);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnInsetar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1071, 64);
            this.pnlBotones.TabIndex = 1;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(416, 13);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(253, 22);
            this.txt_buscar.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(334, 13);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(208, 7);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(56, 53);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(144, 7);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 53);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(80, 7);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 53);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsetar
            // 
            this.btnInsetar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsetar.Image")));
            this.btnInsetar.Location = new System.Drawing.Point(16, 7);
            this.btnInsetar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsetar.Name = "btnInsetar";
            this.btnInsetar.Size = new System.Drawing.Size(56, 53);
            this.btnInsetar.TabIndex = 0;
            this.btnInsetar.UseVisualStyleBackColor = true;
            this.btnInsetar.Click += new System.EventHandler(this.btnInsetar_Click);
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.Controls.Add(this.num_cantidad);
            this.pnlRegistros.Controls.Add(this.label4);
            this.pnlRegistros.Controls.Add(this.btnCancelar);
            this.pnlRegistros.Controls.Add(this.btnGuardar);
            this.pnlRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRegistros.Location = new System.Drawing.Point(0, 384);
            this.pnlRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(1071, 174);
            this.pnlRegistros.TabIndex = 2;
            // 
            // num_cantidad
            // 
            this.num_cantidad.Location = new System.Drawing.Point(80, 83);
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.Size = new System.Drawing.Size(120, 22);
            this.num_cantidad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "cantidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(973, 92);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 66);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(888, 92);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 66);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.panel1);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 64);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1071, 320);
            this.pnlDatos.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 320);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.data_producto);
            this.panel3.Controls.Add(this.navi_producto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 158);
            this.panel3.TabIndex = 1;
            // 
            // data_producto
            // 
            this.data_producto.AllowUserToAddRows = false;
            this.data_producto.AllowUserToDeleteRows = false;
            this.data_producto.AllowUserToOrderColumns = true;
            this.data_producto.AutoGenerateColumns = false;
            this.data_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn1,
            this.activoDataGridViewTextBoxColumn1});
            this.data_producto.DataSource = this.binding_producto;
            this.data_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_producto.Location = new System.Drawing.Point(0, 27);
            this.data_producto.Name = "data_producto";
            this.data_producto.ReadOnly = true;
            this.data_producto.RowTemplate.Height = 24;
            this.data_producto.Size = new System.Drawing.Size(1071, 131);
            this.data_producto.TabIndex = 1;
            // 
            // idProductoDataGridViewTextBoxColumn1
            // 
            this.idProductoDataGridViewTextBoxColumn1.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn1.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn1.Name = "idProductoDataGridViewTextBoxColumn1";
            this.idProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // activoDataGridViewTextBoxColumn1
            // 
            this.activoDataGridViewTextBoxColumn1.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn1.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn1.Name = "activoDataGridViewTextBoxColumn1";
            this.activoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // binding_producto
            // 
            this.binding_producto.DataMember = "Producto";
            this.binding_producto.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // navi_producto
            // 
            this.navi_producto.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.navi_producto.BindingSource = this.binding_producto;
            this.navi_producto.CountItem = this.bindingNavigatorCountItem1;
            this.navi_producto.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.navi_producto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navi_producto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.navi_producto.Location = new System.Drawing.Point(0, 0);
            this.navi_producto.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.navi_producto.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.navi_producto.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.navi_producto.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.navi_producto.Name = "navi_producto";
            this.navi_producto.PositionItem = this.bindingNavigatorPositionItem1;
            this.navi_producto.Size = new System.Drawing.Size(1071, 27);
            this.navi_producto.TabIndex = 0;
            this.navi_producto.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem1.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem1.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.data_inventario);
            this.panel2.Controls.Add(this.navi_inventario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 156);
            this.panel2.TabIndex = 0;
            // 
            // data_inventario
            // 
            this.data_inventario.AllowUserToAddRows = false;
            this.data_inventario.AllowUserToDeleteRows = false;
            this.data_inventario.AllowUserToOrderColumns = true;
            this.data_inventario.AutoGenerateColumns = false;
            this.data_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInventarioDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn});
            this.data_inventario.DataSource = this.binding_inventario;
            this.data_inventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_inventario.Location = new System.Drawing.Point(0, 27);
            this.data_inventario.Name = "data_inventario";
            this.data_inventario.ReadOnly = true;
            this.data_inventario.RowTemplate.Height = 24;
            this.data_inventario.Size = new System.Drawing.Size(1071, 129);
            this.data_inventario.TabIndex = 1;
            // 
            // idInventarioDataGridViewTextBoxColumn
            // 
            this.idInventarioDataGridViewTextBoxColumn.DataPropertyName = "IdInventario";
            this.idInventarioDataGridViewTextBoxColumn.HeaderText = "IdInventario";
            this.idInventarioDataGridViewTextBoxColumn.Name = "idInventarioDataGridViewTextBoxColumn";
            this.idInventarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // binding_inventario
            // 
            this.binding_inventario.DataMember = "Inventario";
            this.binding_inventario.DataSource = this.ds;
            // 
            // navi_inventario
            // 
            this.navi_inventario.AddNewItem = this.bindingNavigatorAddNewItem;
            this.navi_inventario.BindingSource = this.binding_inventario;
            this.navi_inventario.CountItem = this.bindingNavigatorCountItem;
            this.navi_inventario.DeleteItem = this.bindingNavigatorDeleteItem;
            this.navi_inventario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navi_inventario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.navi_inventario.Location = new System.Drawing.Point(0, 0);
            this.navi_inventario.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navi_inventario.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navi_inventario.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navi_inventario.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navi_inventario.Name = "navi_inventario";
            this.navi_inventario.PositionItem = this.bindingNavigatorPositionItem;
            this.navi_inventario.Size = new System.Drawing.Size(1071, 27);
            this.navi_inventario.TabIndex = 0;
            this.navi_inventario.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 558);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlRegistros);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventarios";
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.Inventarios_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navi_producto)).EndInit();
            this.navi_producto.ResumeLayout(false);
            this.navi_producto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navi_inventario)).EndInit();
            this.navi_inventario.ResumeLayout(false);
            this.navi_inventario.PerformLayout();
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
        private ds ds;
        private dsTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.NumericUpDown num_cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView data_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource binding_producto;
        private System.Windows.Forms.BindingNavigator navi_producto;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView data_inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource binding_inventario;
        private System.Windows.Forms.BindingNavigator navi_inventario;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private dsTableAdapters.ProductoTableAdapter productoTableAdapter;
    }
}
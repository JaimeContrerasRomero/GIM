﻿namespace SistemaGIM
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnBoceto = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btn_socios = new System.Windows.Forms.Button();
            this.btnSociosMembresias = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 51);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(551, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsuario.Size = new System.Drawing.Size(259, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "JAIME CONTRERAS ROMERO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 414);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBitacora);
            this.tabPage1.Controls.Add(this.btnBoceto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(863, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Catalogos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEquipos);
            this.tabPage2.Controls.Add(this.btn_socios);
            this.tabPage2.Controls.Add(this.btnSociosMembresias);
            this.tabPage2.Controls.Add(this.btn_inventario);
            this.tabPage2.Controls.Add(this.btnProveedores);
            this.tabPage2.Controls.Add(this.btn_productos);
            this.tabPage2.Controls.Add(this.btnProductos);
            this.tabPage2.Controls.Add(this.btnCompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(863, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modulos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBitacora
            // 
            this.btnBitacora.Image = ((System.Drawing.Image)(resources.GetObject("btnBitacora.Image")));
            this.btnBitacora.Location = new System.Drawing.Point(137, 31);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(75, 68);
            this.btnBitacora.TabIndex = 1;
            this.btnBitacora.Text = "&Bitacora";
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBitacora.UseVisualStyleBackColor = true;
            // 
            // btnBoceto
            // 
            this.btnBoceto.Image = ((System.Drawing.Image)(resources.GetObject("btnBoceto.Image")));
            this.btnBoceto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBoceto.Location = new System.Drawing.Point(31, 31);
            this.btnBoceto.Name = "btnBoceto";
            this.btnBoceto.Size = new System.Drawing.Size(75, 68);
            this.btnBoceto.TabIndex = 0;
            this.btnBoceto.Text = "&Boceto Catalogo";
            this.btnBoceto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBoceto.UseVisualStyleBackColor = true;
            this.btnBoceto.Click += new System.EventHandler(this.btnBoceto_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.Image = global::SistemaGIM.Properties.Resources.pesa;
            this.btnEquipos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEquipos.Location = new System.Drawing.Point(708, 30);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(76, 68);
            this.btnEquipos.TabIndex = 8;
            this.btnEquipos.Text = " Equipos";
            this.btnEquipos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEquipos.UseVisualStyleBackColor = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btn_socios
            // 
            this.btn_socios.Image = global::SistemaGIM.Properties.Resources.socio;
            this.btn_socios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_socios.Location = new System.Drawing.Point(613, 30);
            this.btn_socios.Name = "btn_socios";
            this.btn_socios.Size = new System.Drawing.Size(75, 68);
            this.btn_socios.TabIndex = 7;
            this.btn_socios.Text = "socios";
            this.btn_socios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_socios.UseVisualStyleBackColor = true;
            // 
            // btnSociosMembresias
            // 
            this.btnSociosMembresias.Image = global::SistemaGIM.Properties.Resources.document_icon;
            this.btnSociosMembresias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSociosMembresias.Location = new System.Drawing.Point(517, 30);
            this.btnSociosMembresias.Name = "btnSociosMembresias";
            this.btnSociosMembresias.Size = new System.Drawing.Size(75, 68);
            this.btnSociosMembresias.TabIndex = 6;
            this.btnSociosMembresias.Text = "&SocioMembresia";
            this.btnSociosMembresias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSociosMembresias.UseVisualStyleBackColor = true;
            // 
            // btn_inventario
            // 
            this.btn_inventario.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventario.Image")));
            this.btn_inventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_inventario.Location = new System.Drawing.Point(417, 30);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(75, 68);
            this.btn_inventario.TabIndex = 5;
            this.btn_inventario.Text = "&inventario";
            this.btn_inventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_inventario.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Image = global::SistemaGIM.Properties.Resources.proveedores;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProveedores.Location = new System.Drawing.Point(326, 30);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(75, 68);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "&Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btn_productos
            // 
            this.btn_productos.Image = ((System.Drawing.Image)(resources.GetObject("btn_productos.Image")));
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_productos.Location = new System.Drawing.Point(223, 30);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(75, 68);
            this.btn_productos.TabIndex = 3;
            this.btn_productos.Text = "&SocioPeso";
            this.btn_productos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.Location = new System.Drawing.Point(122, 30);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 68);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "&Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnCompra.Image")));
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompra.Location = new System.Drawing.Point(30, 30);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 68);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "&Compra";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = global::SistemaGIM.Properties.Resources.eliminar;
            this.btnCerrarSesion.Location = new System.Drawing.Point(825, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(43, 43);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 465);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBoceto;
        private System.Windows.Forms.Button btnCompra;

        private System.Windows.Forms.Button btnProductos;

        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btnSociosMembresias;
        private System.Windows.Forms.Button btn_socios;
        private System.Windows.Forms.Button btnEquipos;
    }
}
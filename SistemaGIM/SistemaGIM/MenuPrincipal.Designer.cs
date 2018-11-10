namespace SistemaGIM
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
            this.btnBoceto = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btnCerrarSesion = new System.Windows.Forms.Button();
=======
            this.btnBitacora = new System.Windows.Forms.Button();
>>>>>>> 615e280cfd1bcc58a4f2870e9093adc35ee1b7a5
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 63);
            this.panel1.TabIndex = 0;
            // 
<<<<<<< HEAD
=======
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = global::SistemaGIM.Properties.Resources.eliminar;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1100, 4);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(57, 53);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
>>>>>>> 615e280cfd1bcc58a4f2870e9093adc35ee1b7a5
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(735, 16);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsuario.Size = new System.Drawing.Size(317, 25);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "JAIME CONTRERAS ROMERO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 509);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBitacora);
            this.tabPage1.Controls.Add(this.btnBoceto);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1153, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Catalogos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnProductos);
            this.tabPage2.Controls.Add(this.btnCompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1153, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modulos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBoceto
            // 
            this.btnBoceto.Image = ((System.Drawing.Image)(resources.GetObject("btnBoceto.Image")));
            this.btnBoceto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBoceto.Location = new System.Drawing.Point(41, 38);
<<<<<<< HEAD
            this.btnBoceto.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnBoceto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 615e280cfd1bcc58a4f2870e9093adc35ee1b7a5
            this.btnBoceto.Name = "btnBoceto";
            this.btnBoceto.Size = new System.Drawing.Size(100, 84);
            this.btnBoceto.TabIndex = 0;
            this.btnBoceto.Text = "&Boceto Catalogo";
            this.btnBoceto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBoceto.UseVisualStyleBackColor = true;
            this.btnBoceto.Click += new System.EventHandler(this.btnBoceto_Click);
            // 
            // btnProductos
            // 
<<<<<<< HEAD
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.Location = new System.Drawing.Point(163, 37);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(100, 84);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "&Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = true;
=======
            this.tabPage2.Controls.Add(this.btnCompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1153, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modulos";
            this.tabPage2.UseVisualStyleBackColor = true;
>>>>>>> 615e280cfd1bcc58a4f2870e9093adc35ee1b7a5
            // 
            // btnCompra
            // 
            this.btnCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnCompra.Image")));
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompra.Location = new System.Drawing.Point(40, 37);
<<<<<<< HEAD
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 615e280cfd1bcc58a4f2870e9093adc35ee1b7a5
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(100, 84);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "&Compra";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = global::SistemaGIM.Properties.Resources.eliminar;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1100, 4);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(57, 53);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
=======
            // btnBitacora
            // 
            this.btnBitacora.Image = ((System.Drawing.Image)(resources.GetObject("btnBitacora.Image")));
            this.btnBitacora.Location = new System.Drawing.Point(183, 38);
            this.btnBitacora.Margin = new System.Windows.Forms.Padding(4);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(100, 84);
            this.btnBitacora.TabIndex = 1;
            this.btnBitacora.Text = "&Bitacora";
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBitacora.UseVisualStyleBackColor = true;
>>>>>>> 615e280cfd1bcc58a4f2870e9093adc35ee1b7a5
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
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
<<<<<<< HEAD
        private System.Windows.Forms.Button btnProductos;
=======
        private System.Windows.Forms.Button btnBitacora;
>>>>>>> 615e280cfd1bcc58a4f2870e9093adc35ee1b7a5
    }
}
namespace SistemaGIM
{
    partial class repBitacora
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repBitacora));
            this.BitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new SistemaGIM.ds();
            this.rv_bitacora = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BitacoraTableAdapter = new SistemaGIM.dsTableAdapters.BitacoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // BitacoraBindingSource
            // 
            this.BitacoraBindingSource.DataMember = "Bitacora";
            this.BitacoraBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv_bitacora
            // 
            this.rv_bitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rptDs";
            reportDataSource1.Value = this.BitacoraBindingSource;
            this.rv_bitacora.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_bitacora.LocalReport.ReportEmbeddedResource = "SistemaGIM.rptBitacora.rdlc";
            this.rv_bitacora.Location = new System.Drawing.Point(0, 0);
            this.rv_bitacora.Name = "rv_bitacora";
            this.rv_bitacora.ServerReport.BearerToken = null;
            this.rv_bitacora.Size = new System.Drawing.Size(812, 554);
            this.rv_bitacora.TabIndex = 0;
            // 
            // BitacoraTableAdapter
            // 
            this.BitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // repBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 554);
            this.Controls.Add(this.rv_bitacora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "repBitacora";
            this.Load += new System.EventHandler(this.repBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_bitacora;
        private System.Windows.Forms.BindingSource BitacoraBindingSource;
        private ds ds;
        private dsTableAdapters.BitacoraTableAdapter BitacoraTableAdapter;
    }
}
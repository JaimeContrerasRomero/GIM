﻿namespace SistemaGIM
{
    partial class repSociosAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repSociosAsistencias));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds = new SistemaGIM.ds();
            this.SocioAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SocioAsistenciaTableAdapter = new SistemaGIM.dsTableAdapters.SocioAsistenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocioAsistenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rptDs";
            reportDataSource1.Value = this.SocioAsistenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaGIM.rptSociosAsistencias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SocioAsistenciaBindingSource
            // 
            this.SocioAsistenciaBindingSource.DataMember = "SocioAsistencia";
            this.SocioAsistenciaBindingSource.DataSource = this.ds;
            // 
            // SocioAsistenciaTableAdapter
            // 
            this.SocioAsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // repSociosAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repSociosAsistencias";
            this.Text = "Reporte de SociosAsistencias";
            this.Load += new System.EventHandler(this.repSociosAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocioAsistenciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SocioAsistenciaBindingSource;
        private ds ds;
        private dsTableAdapters.SocioAsistenciaTableAdapter SocioAsistenciaTableAdapter;
    }
}
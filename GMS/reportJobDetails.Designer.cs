namespace GMS
{
    partial class reportJobDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportJobDetails));
            this.job_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GarageManagementSystemDataSet = new GMS.GarageManagementSystemDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.job_detailsTableAdapter = new GMS.GarageManagementSystemDataSetTableAdapters.job_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.job_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GarageManagementSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // job_detailsBindingSource
            // 
            this.job_detailsBindingSource.DataMember = "job_details";
            this.job_detailsBindingSource.DataSource = this.GarageManagementSystemDataSet;
            // 
            // GarageManagementSystemDataSet
            // 
            this.GarageManagementSystemDataSet.DataSetName = "GarageManagementSystemDataSet";
            this.GarageManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 3;
            reportDataSource1.Name = "JobDetailsDataSet";
            reportDataSource1.Value = this.job_detailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GMS.Jobdetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(727, 651);
            this.reportViewer1.TabIndex = 0;
            // 
            // job_detailsTableAdapter
            // 
            this.job_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // reportJobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 651);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportJobDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Job Details";
            this.Load += new System.EventHandler(this.reportJobDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.job_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GarageManagementSystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource job_detailsBindingSource;
        private GarageManagementSystemDataSet GarageManagementSystemDataSet;
        private GarageManagementSystemDataSetTableAdapters.job_detailsTableAdapter job_detailsTableAdapter;

    }
}
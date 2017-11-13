namespace VideoRental
{
    partial class frminforCustomer
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VideoRentalDataSet4 = new VideoRental.VideoRentalDataSet4();
            this.tbl_CustomerTableAdapter = new VideoRental.VideoRentalDataSet4TableAdapters.tbl_CustomerTableAdapter();
            this.DataSet1 = new VideoRental.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoRentalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VideoRental.CustomerInfor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(898, 317);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tbl_CustomerBindingSource
            // 
            this.tbl_CustomerBindingSource.DataMember = "tbl_Customer";
            this.tbl_CustomerBindingSource.DataSource = this.VideoRentalDataSet4;
            // 
            // VideoRentalDataSet4
            // 
            this.VideoRentalDataSet4.DataSetName = "VideoRentalDataSet4";
            this.VideoRentalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_CustomerTableAdapter
            // 
            this.tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frminforCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 317);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frminforCustomer";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoRentalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_CustomerBindingSource;
        private VideoRentalDataSet4 VideoRentalDataSet4;
        private VideoRentalDataSet4TableAdapters.tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private DataSet1 DataSet1;
    }
}
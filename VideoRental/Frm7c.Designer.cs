namespace VideoRental
{
    partial class Frm7c
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
            this.View_7cBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VideoRental.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbcustomername7c = new System.Windows.Forms.ComboBox();
            this.view7cBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view7cBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btntk = new System.Windows.Forms.Button();
            this.view_7cTableAdapter = new VideoRental.DataSet1TableAdapters.View_7cTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_7cBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view7cBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view7cBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // View_7cBindingSource
            // 
            this.View_7cBindingSource.DataMember = "View_7c";
            this.View_7cBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 356);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_7cBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VideoRental.7cReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(802, 356);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cbcustomername7c
            // 
            this.cbcustomername7c.DataSource = this.view7cBindingSource1;
            this.cbcustomername7c.DisplayMember = "CustomerName";
            this.cbcustomername7c.FormattingEnabled = true;
            this.cbcustomername7c.Location = new System.Drawing.Point(146, 20);
            this.cbcustomername7c.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcustomername7c.Name = "cbcustomername7c";
            this.cbcustomername7c.Size = new System.Drawing.Size(200, 21);
            this.cbcustomername7c.TabIndex = 1;
            this.cbcustomername7c.ValueMember = "CustomerID";
            // 
            // view7cBindingSource1
            // 
            this.view7cBindingSource1.DataMember = "View_7c";
            this.view7cBindingSource1.DataSource = this.dataSet1;
            // 
            // view7cBindingSource
            // 
            this.view7cBindingSource.DataMember = "View_7c";
            this.view7cBindingSource.DataSource = this.dataSet1;
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(405, 20);
            this.btntk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(68, 19);
            this.btntk.TabIndex = 2;
            this.btntk.Text = "Thống kê";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // view_7cTableAdapter
            // 
            this.view_7cTableAdapter.ClearBeforeFill = true;
            // 
            // Frm7c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 425);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.cbcustomername7c);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm7c";
            this.Text = "Frm7c";
            this.Load += new System.EventHandler(this.Frm7c_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_7cBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view7cBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view7cBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbcustomername7c;
        private System.Windows.Forms.Button btntk;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource view7cBindingSource;
        private DataSet1TableAdapters.View_7cTableAdapter view_7cTableAdapter;
        private System.Windows.Forms.BindingSource view7cBindingSource1;
        private System.Windows.Forms.BindingSource View_7cBindingSource;
    }
}
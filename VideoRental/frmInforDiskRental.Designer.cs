namespace VideoRental
{
    partial class frmInforDiskRental
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.View_7bBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VideoRental.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbidcus = new System.Windows.Forms.ComboBox();
            this.view7bBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnthongke = new System.Windows.Forms.Button();
            this.view_7bTableAdapter = new VideoRental.DataSet1TableAdapters.View_7bTableAdapter();
            this.view7bfinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_7bfinalTableAdapter = new VideoRental.DataSet1TableAdapters.View_7bfinalTableAdapter();
            this.View_7bfinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.View_7bBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view7bBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view7bfinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_7bfinalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // View_7bBindingSource
            // 
            this.View_7bBindingSource.DataMember = "View_7b";
            this.View_7bBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.View_7bfinalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VideoRental.7breport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1100, 423);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 423);
            this.panel1.TabIndex = 1;
            // 
            // cbidcus
            // 
            this.cbidcus.DataSource = this.view7bfinalBindingSource;
            this.cbidcus.DisplayMember = "CustomerName";
            this.cbidcus.FormattingEnabled = true;
            this.cbidcus.Location = new System.Drawing.Point(178, 25);
            this.cbidcus.Name = "cbidcus";
            this.cbidcus.Size = new System.Drawing.Size(306, 24);
            this.cbidcus.TabIndex = 2;
            this.cbidcus.ValueMember = "CustomerID";
            this.cbidcus.SelectedIndexChanged += new System.EventHandler(this.cbidcus_SelectedIndexChanged);
            // 
            // view7bBindingSource
            // 
            this.view7bBindingSource.DataMember = "View_7b";
            this.view7bBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(625, 25);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(213, 23);
            this.btnthongke.TabIndex = 3;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // view_7bTableAdapter
            // 
            this.view_7bTableAdapter.ClearBeforeFill = true;
            // 
            // view7bfinalBindingSource
            // 
            this.view7bfinalBindingSource.DataMember = "View_7bfinal";
            this.view7bfinalBindingSource.DataSource = this.dataSet1;
            // 
            // view_7bfinalTableAdapter
            // 
            this.view_7bfinalTableAdapter.ClearBeforeFill = true;
            // 
            // View_7bfinalBindingSource
            // 
            this.View_7bfinalBindingSource.DataMember = "View_7bfinal";
            this.View_7bfinalBindingSource.DataSource = this.dataSet1;
            // 
            // frmInforDiskRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 501);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.cbidcus);
            this.Controls.Add(this.panel1);
            this.Name = "frmInforDiskRental";
            this.Text = "frmInforDiskRental";
            this.Load += new System.EventHandler(this.frmInforDiskRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_7bBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view7bBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view7bfinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_7bfinalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbidcus;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource view7bBindingSource;
        private DataSet1TableAdapters.View_7bTableAdapter view_7bTableAdapter;
        private System.Windows.Forms.BindingSource View_7bBindingSource;
        private System.Windows.Forms.BindingSource view7bfinalBindingSource;
        private DataSet1TableAdapters.View_7bfinalTableAdapter view_7bfinalTableAdapter;
        private System.Windows.Forms.BindingSource View_7bfinalBindingSource;
    }
}
namespace VideoRental
{
    partial class frmDiskRental
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
            this.txtDiskID = new System.Windows.Forms.TextBox();
            this.dgvDiskRental = new System.Windows.Forms.DataGridView();
            this.tblDiskRentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalDataSet1 = new VideoRental.VideoRentalDataSet1();
            this.btnAdd = new System.Windows.Forms.Button();
            this.videoRentalDataSet = new VideoRental.VideoRentalDataSet();
            this.videoRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DiskRentalTableAdapter = new VideoRental.VideoRentalDataSet1TableAdapters.tbl_DiskRentalTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSumRentCharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDiskID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiskRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiskRentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiskID
            // 
            this.txtDiskID.Location = new System.Drawing.Point(193, 55);
            this.txtDiskID.Name = "txtDiskID";
            this.txtDiskID.Size = new System.Drawing.Size(156, 20);
            this.txtDiskID.TabIndex = 0;
            // 
            // dgvDiskRental
            // 
            this.dgvDiskRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiskRental.Location = new System.Drawing.Point(12, 159);
            this.dgvDiskRental.Name = "dgvDiskRental";
            this.dgvDiskRental.Size = new System.Drawing.Size(497, 150);
            this.dgvDiskRental.TabIndex = 1;
            this.dgvDiskRental.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDiskRental_RowStateChanged);
            // 
            // tblDiskRentalBindingSource
            // 
            this.tblDiskRentalBindingSource.DataMember = "tbl_DiskRental";
            this.tblDiskRentalBindingSource.DataSource = this.videoRentalDataSet1;
            // 
            // videoRentalDataSet1
            // 
            this.videoRentalDataSet1.DataSetName = "VideoRentalDataSet1";
            this.videoRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(467, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // videoRentalDataSet
            // 
            this.videoRentalDataSet.DataSetName = "VideoRentalDataSet";
            this.videoRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // videoRentalDataSetBindingSource
            // 
            this.videoRentalDataSetBindingSource.DataSource = this.videoRentalDataSet;
            this.videoRentalDataSetBindingSource.Position = 0;
            // 
            // tbl_DiskRentalTableAdapter
            // 
            this.tbl_DiskRentalTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSumRentCharge
            // 
            this.txtSumRentCharge.Location = new System.Drawing.Point(518, 201);
            this.txtSumRentCharge.Name = "txtSumRentCharge";
            this.txtSumRentCharge.Size = new System.Drawing.Size(100, 20);
            this.txtSumRentCharge.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "sum rental charge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Đĩa";
            // 
            // cmbDiskID
            // 
            this.cmbDiskID.FormattingEnabled = true;
            this.cmbDiskID.Location = new System.Drawing.Point(202, 98);
            this.cmbDiskID.Name = "cmbDiskID";
            this.cmbDiskID.Size = new System.Drawing.Size(121, 21);
            this.cmbDiskID.TabIndex = 8;
            // 
            // frmDiskRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cmbDiskID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumRentCharge);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDiskRental);
            this.Controls.Add(this.txtDiskID);
            this.Name = "frmDiskRental";
            this.Text = "frmDiskRental";
            this.Load += new System.EventHandler(this.frmDiskRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiskRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiskRentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiskID;
        private System.Windows.Forms.DataGridView dgvDiskRental;
        private System.Windows.Forms.Button btnAdd;
        private VideoRentalDataSet videoRentalDataSet;
        private System.Windows.Forms.BindingSource videoRentalDataSetBindingSource;
        private VideoRentalDataSet1 videoRentalDataSet1;
        private System.Windows.Forms.BindingSource tblDiskRentalBindingSource;
        private VideoRentalDataSet1TableAdapters.tbl_DiskRentalTableAdapter tbl_DiskRentalTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSumRentCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDiskID;
    }
}
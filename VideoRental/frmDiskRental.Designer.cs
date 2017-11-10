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
            this.rentalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDiskRentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalDataSet1 = new VideoRental.VideoRentalDataSet1();
            this.btnAdd = new System.Windows.Forms.Button();
            this.videoRentalDataSet = new VideoRental.VideoRentalDataSet();
            this.videoRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DiskRentalTableAdapter = new VideoRental.VideoRentalDataSet1TableAdapters.tbl_DiskRentalTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvDiskRental.AutoGenerateColumns = false;
            this.dgvDiskRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiskRental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalIDDataGridViewTextBoxColumn,
            this.diskIDDataGridViewTextBoxColumn});
            this.dgvDiskRental.DataSource = this.tblDiskRentalBindingSource;
            this.dgvDiskRental.Location = new System.Drawing.Point(76, 163);
            this.dgvDiskRental.Name = "dgvDiskRental";
            this.dgvDiskRental.Size = new System.Drawing.Size(492, 150);
            this.dgvDiskRental.TabIndex = 1;
            // 
            // rentalIDDataGridViewTextBoxColumn
            // 
            this.rentalIDDataGridViewTextBoxColumn.DataPropertyName = "RentalID";
            this.rentalIDDataGridViewTextBoxColumn.HeaderText = "RentalID";
            this.rentalIDDataGridViewTextBoxColumn.Name = "rentalIDDataGridViewTextBoxColumn";
            // 
            // diskIDDataGridViewTextBoxColumn
            // 
            this.diskIDDataGridViewTextBoxColumn.DataPropertyName = "DiskID";
            this.diskIDDataGridViewTextBoxColumn.HeaderText = "DiskID";
            this.diskIDDataGridViewTextBoxColumn.Name = "diskIDDataGridViewTextBoxColumn";
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
            // frmDiskRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 352);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
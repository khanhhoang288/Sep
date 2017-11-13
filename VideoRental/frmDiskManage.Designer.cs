namespace VideoRental
{
    partial class frmDiskManage
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
            this.dgvDisk = new System.Windows.Forms.DataGridView();
            this.diskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalDataSet = new VideoRental.VideoRentalDataSet();
            this.tbl_DiskTableAdapter = new VideoRental.VideoRentalDataSetTableAdapters.tbl_DiskTableAdapter();
            this.lblDiskID = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtDiskStatus = new System.Windows.Forms.TextBox();
            this.txtDiskCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisk
            // 
            this.dgvDisk.AutoGenerateColumns = false;
            this.dgvDisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diskIDDataGridViewTextBoxColumn,
            this.titleIDDataGridViewTextBoxColumn,
            this.diskStatusDataGridViewTextBoxColumn,
            this.diskCodeDataGridViewTextBoxColumn});
            this.dgvDisk.DataSource = this.tblDiskBindingSource;
            this.dgvDisk.Location = new System.Drawing.Point(46, 105);
            this.dgvDisk.Name = "dgvDisk";
            this.dgvDisk.Size = new System.Drawing.Size(450, 185);
            this.dgvDisk.TabIndex = 0;
            this.dgvDisk.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // diskIDDataGridViewTextBoxColumn
            // 
            this.diskIDDataGridViewTextBoxColumn.DataPropertyName = "DiskID";
            this.diskIDDataGridViewTextBoxColumn.HeaderText = "DiskID";
            this.diskIDDataGridViewTextBoxColumn.Name = "diskIDDataGridViewTextBoxColumn";
            this.diskIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleIDDataGridViewTextBoxColumn
            // 
            this.titleIDDataGridViewTextBoxColumn.DataPropertyName = "TitleID";
            this.titleIDDataGridViewTextBoxColumn.HeaderText = "TitleID";
            this.titleIDDataGridViewTextBoxColumn.Name = "titleIDDataGridViewTextBoxColumn";
            // 
            // diskStatusDataGridViewTextBoxColumn
            // 
            this.diskStatusDataGridViewTextBoxColumn.DataPropertyName = "DiskStatus";
            this.diskStatusDataGridViewTextBoxColumn.HeaderText = "DiskStatus";
            this.diskStatusDataGridViewTextBoxColumn.Name = "diskStatusDataGridViewTextBoxColumn";
            // 
            // diskCodeDataGridViewTextBoxColumn
            // 
            this.diskCodeDataGridViewTextBoxColumn.DataPropertyName = "DiskCode";
            this.diskCodeDataGridViewTextBoxColumn.HeaderText = "DiskCode";
            this.diskCodeDataGridViewTextBoxColumn.Name = "diskCodeDataGridViewTextBoxColumn";
            // 
            // tblDiskBindingSource
            // 
            this.tblDiskBindingSource.DataMember = "tbl_Disk";
            this.tblDiskBindingSource.DataSource = this.videoRentalDataSet;
            // 
            // videoRentalDataSet
            // 
            this.videoRentalDataSet.DataSetName = "VideoRentalDataSet";
            this.videoRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DiskTableAdapter
            // 
            this.tbl_DiskTableAdapter.ClearBeforeFill = true;
            // 
            // lblDiskID
            // 
            this.lblDiskID.AutoSize = true;
            this.lblDiskID.Location = new System.Drawing.Point(43, 9);
            this.lblDiskID.Name = "lblDiskID";
            this.lblDiskID.Size = new System.Drawing.Size(35, 13);
            this.lblDiskID.TabIndex = 1;
            this.lblDiskID.Text = "label1";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(102, 70);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(100, 20);
            this.txtTitleID.TabIndex = 2;
            // 
            // txtDiskStatus
            // 
            this.txtDiskStatus.Location = new System.Drawing.Point(253, 70);
            this.txtDiskStatus.Name = "txtDiskStatus";
            this.txtDiskStatus.Size = new System.Drawing.Size(100, 20);
            this.txtDiskStatus.TabIndex = 2;
            // 
            // txtDiskCode
            // 
            this.txtDiskCode.Location = new System.Drawing.Point(413, 70);
            this.txtDiskCode.Name = "txtDiskCode";
            this.txtDiskCode.Size = new System.Drawing.Size(100, 20);
            this.txtDiskCode.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(594, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(594, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(594, 183);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "title id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "disk status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "disk code";
            // 
            // frmDiskManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDiskCode);
            this.Controls.Add(this.txtDiskStatus);
            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.lblDiskID);
            this.Controls.Add(this.dgvDisk);
            this.Name = "frmDiskManage";
            this.Text = "frmDiskManage";
            this.Load += new System.EventHandler(this.frmDiskManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisk;
        private VideoRentalDataSet videoRentalDataSet;
        private System.Windows.Forms.BindingSource tblDiskBindingSource;
        private VideoRentalDataSetTableAdapters.tbl_DiskTableAdapter tbl_DiskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDiskID;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtDiskStatus;
        private System.Windows.Forms.TextBox txtDiskCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
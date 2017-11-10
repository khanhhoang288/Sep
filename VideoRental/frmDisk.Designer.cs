namespace VideoRental
{
    partial class frmDisk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtDiskStatus = new System.Windows.Forms.TextBox();
            this.txtDiskCode = new System.Windows.Forms.TextBox();
            this.dgvDisk = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Title ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DiskStatus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DiskCode";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(140, 52);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(100, 20);
            this.txtTitleID.TabIndex = 2;
            // 
            // txtDiskStatus
            // 
            this.txtDiskStatus.Location = new System.Drawing.Point(140, 106);
            this.txtDiskStatus.Name = "txtDiskStatus";
            this.txtDiskStatus.Size = new System.Drawing.Size(100, 20);
            this.txtDiskStatus.TabIndex = 2;
            // 
            // txtDiskCode
            // 
            this.txtDiskCode.Location = new System.Drawing.Point(497, 49);
            this.txtDiskCode.Name = "txtDiskCode";
            this.txtDiskCode.Size = new System.Drawing.Size(100, 20);
            this.txtDiskCode.TabIndex = 2;
            // 
            // dgvDisk
            // 
            this.dgvDisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisk.Location = new System.Drawing.Point(51, 171);
            this.dgvDisk.Name = "dgvDisk";
            this.dgvDisk.Size = new System.Drawing.Size(650, 150);
            this.dgvDisk.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 441);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDisk);
            this.Controls.Add(this.txtDiskCode);
            this.Controls.Add(this.txtDiskStatus);
            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDisk";
            this.Text = "frmDisk";
            this.Load += new System.EventHandler(this.frmDisk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtDiskStatus;
        private System.Windows.Forms.TextBox txtDiskCode;
        private System.Windows.Forms.DataGridView dgvDisk;
        private System.Windows.Forms.Button btnAdd;
    }
}
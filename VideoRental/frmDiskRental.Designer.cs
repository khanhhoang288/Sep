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
            this.txtDiskID = new System.Windows.Forms.TextBox();
            this.dgvDiskRental = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiskRental)).BeginInit();
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
            this.dgvDiskRental.Location = new System.Drawing.Point(76, 163);
            this.dgvDiskRental.Name = "dgvDiskRental";
            this.dgvDiskRental.Size = new System.Drawing.Size(492, 150);
            this.dgvDiskRental.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(467, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmDiskRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 352);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDiskRental);
            this.Controls.Add(this.txtDiskID);
            this.Name = "frmDiskRental";
            this.Text = "frmDiskRental";
            this.Load += new System.EventHandler(this.frmDiskRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiskRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiskID;
        private System.Windows.Forms.DataGridView dgvDiskRental;
        private System.Windows.Forms.Button btnAdd;
    }
}
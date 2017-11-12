namespace VideoRental
{
    partial class frmRental
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
            this.dtpRental = new System.Windows.Forms.DateTimePicker();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.videoRentalDataSet = new VideoRental.VideoRentalDataSet();
            this.videoRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpRental
            // 
            this.dtpRental.Location = new System.Drawing.Point(346, 59);
            this.dtpRental.Name = "dtpRental";
            this.dtpRental.Size = new System.Drawing.Size(200, 20);
            this.dtpRental.TabIndex = 1;
            // 
            // dgvRental
            // 
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Location = new System.Drawing.Point(33, 155);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.Size = new System.Drawing.Size(437, 154);
            this.dgvRental.TabIndex = 2;
            this.dgvRental.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvRental_RowStateChanged);
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Location = new System.Drawing.Point(30, 12);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(59, 13);
            this.lblRentalID.TabIndex = 3;
            this.lblRentalID.Text = "lblRentalID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(575, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "rental date";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(132, 65);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomerID.TabIndex = 8;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
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
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(67, 127);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerName.TabIndex = 9;
            this.lblCustomerName.Text = "label3";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(218, 127);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(35, 13);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "label3";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(362, 127);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(35, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "label3";
            // 
            // frmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 354);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.dgvRental);
            this.Controls.Add(this.dtpRental);
            this.Name = "frmRental";
            this.Text = "frmRental";
            this.Load += new System.EventHandler(this.frmRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpRental;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private VideoRentalDataSet videoRentalDataSet;
        private System.Windows.Forms.BindingSource videoRentalDataSetBindingSource;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
    }
}
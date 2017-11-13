namespace VideoRental
{
    partial class frmReturnDisk
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.dtreturn = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDiskID = new System.Windows.Forms.ComboBox();
            this.lblCusTomerID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.lblLateCharge1 = new System.Windows.Forms.Label();
            this.lblLateCharge = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DiskID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CustomerID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ReturnDisk";
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(152, 117);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 4;
            this.btnreturn.Text = "Trả đĩa";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(233, 117);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Trở về";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(91, 282);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(236, 20);
            this.txtcustomerid.TabIndex = 7;
            // 
            // dtreturn
            // 
            this.dtreturn.Location = new System.Drawing.Point(72, 66);
            this.dtreturn.Name = "dtreturn";
            this.dtreturn.Size = new System.Drawing.Size(235, 20);
            this.dtreturn.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(71, 117);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(162, 66);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerName.TabIndex = 11;
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cmbDiskID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtreturn);
            this.groupBox1.Controls.Add(this.btnreturn);
            this.groupBox1.Controls.Add(this.txtcustomerid);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 424);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Đĩa";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lblLateCharge);
            this.groupBox2.Controls.Add(this.lblTitleID);
            this.groupBox2.Controls.Add(this.lblRentalDate);
            this.groupBox2.Controls.Add(this.lblPhoneNumber);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblCusTomerID);
            this.groupBox2.Controls.Add(this.lblLateCharge1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCustomerName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 424);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày Mượn";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbDiskID
            // 
            this.cmbDiskID.FormattingEnabled = true;
            this.cmbDiskID.Location = new System.Drawing.Point(72, 23);
            this.cmbDiskID.Name = "cmbDiskID";
            this.cmbDiskID.Size = new System.Drawing.Size(236, 21);
            this.cmbDiskID.TabIndex = 11;
            // 
            // lblCusTomerID
            // 
            this.lblCusTomerID.AutoSize = true;
            this.lblCusTomerID.Location = new System.Drawing.Point(162, 34);
            this.lblCusTomerID.Name = "lblCusTomerID";
            this.lblCusTomerID.Size = new System.Drawing.Size(0, 13);
            this.lblCusTomerID.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(162, 99);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 13);
            this.lblAddress.TabIndex = 12;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(162, 127);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneNumber.TabIndex = 12;
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Location = new System.Drawing.Point(162, 154);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(0, 13);
            this.lblRentalDate.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tựa Đĩa";
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Location = new System.Drawing.Point(162, 186);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(0, 13);
            this.lblTitleID.TabIndex = 12;
            // 
            // lblLateCharge1
            // 
            this.lblLateCharge1.AutoSize = true;
            this.lblLateCharge1.Location = new System.Drawing.Point(16, 214);
            this.lblLateCharge1.Name = "lblLateCharge1";
            this.lblLateCharge1.Size = new System.Drawing.Size(43, 13);
            this.lblLateCharge1.TabIndex = 1;
            this.lblLateCharge1.Text = "Phí Trễ";
            this.lblLateCharge1.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblLateCharge
            // 
            this.lblLateCharge.AutoSize = true;
            this.lblLateCharge.Location = new System.Drawing.Point(162, 214);
            this.lblLateCharge.Name = "lblLateCharge";
            this.lblLateCharge.Size = new System.Drawing.Size(0, 13);
            this.lblLateCharge.TabIndex = 12;
            // 
            // frmReturnDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReturnDisk";
            this.Text = "frmReturnDisk";
            this.Load += new System.EventHandler(this.frmReturnDisk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.DateTimePicker dtreturn;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDiskID;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCusTomerID;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLateCharge;
        private System.Windows.Forms.Label lblLateCharge1;
    }
}
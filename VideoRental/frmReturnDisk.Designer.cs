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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtdiskid = new System.Windows.Forms.TextBox();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.dtreturn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trả Đĩa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DiskID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CustomerID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ReturnDisk";
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(137, 215);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 4;
            this.btnreturn.Text = "Trả đĩa";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(279, 215);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Trở về";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtdiskid
            // 
            this.txtdiskid.Location = new System.Drawing.Point(151, 82);
            this.txtdiskid.Name = "txtdiskid";
            this.txtdiskid.Size = new System.Drawing.Size(236, 20);
            this.txtdiskid.TabIndex = 6;
            this.txtdiskid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(151, 117);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(236, 20);
            this.txtcustomerid.TabIndex = 7;
            // 
            // dtreturn
            // 
            this.dtreturn.Location = new System.Drawing.Point(152, 151);
            this.dtreturn.Name = "dtreturn";
            this.dtreturn.Size = new System.Drawing.Size(235, 20);
            this.dtreturn.TabIndex = 9;
            // 
            // frmReturnDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 337);
            this.Controls.Add(this.dtreturn);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.txtdiskid);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReturnDisk";
            this.Text = "frmReturnDisk";
            this.Load += new System.EventHandler(this.frmReturnDisk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtdiskid;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.DateTimePicker dtreturn;
    }
}
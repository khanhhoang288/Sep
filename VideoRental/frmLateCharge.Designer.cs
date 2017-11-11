namespace VideoRental
{
    partial class frmLateCharge
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
            this.dgvLateCharge = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalLateCharge = new System.Windows.Forms.TextBox();
            this.rdbAllLateCharge = new System.Windows.Forms.RadioButton();
            this.rdbPartLateCharge = new System.Windows.Forms.RadioButton();
            this.btnPaid = new System.Windows.Forms.Button();
            this.txtPartLateCharge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLateCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLateCharge
            // 
            this.dgvLateCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLateCharge.Location = new System.Drawing.Point(30, 28);
            this.dgvLateCharge.Name = "dgvLateCharge";
            this.dgvLateCharge.Size = new System.Drawing.Size(520, 182);
            this.dgvLateCharge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Late Charge";
            // 
            // txtTotalLateCharge
            // 
            this.txtTotalLateCharge.Location = new System.Drawing.Point(219, 221);
            this.txtTotalLateCharge.Name = "txtTotalLateCharge";
            this.txtTotalLateCharge.Size = new System.Drawing.Size(100, 20);
            this.txtTotalLateCharge.TabIndex = 2;
            // 
            // rdbAllLateCharge
            // 
            this.rdbAllLateCharge.AutoSize = true;
            this.rdbAllLateCharge.Location = new System.Drawing.Point(60, 267);
            this.rdbAllLateCharge.Name = "rdbAllLateCharge";
            this.rdbAllLateCharge.Size = new System.Drawing.Size(36, 17);
            this.rdbAllLateCharge.TabIndex = 3;
            this.rdbAllLateCharge.TabStop = true;
            this.rdbAllLateCharge.Text = "All";
            this.rdbAllLateCharge.UseVisualStyleBackColor = true;
            // 
            // rdbPartLateCharge
            // 
            this.rdbPartLateCharge.AutoSize = true;
            this.rdbPartLateCharge.Location = new System.Drawing.Point(60, 290);
            this.rdbPartLateCharge.Name = "rdbPartLateCharge";
            this.rdbPartLateCharge.Size = new System.Drawing.Size(44, 17);
            this.rdbPartLateCharge.TabIndex = 3;
            this.rdbPartLateCharge.TabStop = true;
            this.rdbPartLateCharge.Text = "Part";
            this.rdbPartLateCharge.UseVisualStyleBackColor = true;
            // 
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(366, 290);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(75, 23);
            this.btnPaid.TabIndex = 4;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            // 
            // txtPartLateCharge
            // 
            this.txtPartLateCharge.Location = new System.Drawing.Point(178, 287);
            this.txtPartLateCharge.Name = "txtPartLateCharge";
            this.txtPartLateCharge.Size = new System.Drawing.Size(100, 20);
            this.txtPartLateCharge.TabIndex = 2;
            // 
            // frmLateCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 371);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.rdbPartLateCharge);
            this.Controls.Add(this.rdbAllLateCharge);
            this.Controls.Add(this.txtPartLateCharge);
            this.Controls.Add(this.txtTotalLateCharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLateCharge);
            this.Name = "frmLateCharge";
            this.Text = "frmLateCharge";
            this.Load += new System.EventHandler(this.frmLateCharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLateCharge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLateCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalLateCharge;
        private System.Windows.Forms.RadioButton rdbAllLateCharge;
        private System.Windows.Forms.RadioButton rdbPartLateCharge;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.TextBox txtPartLateCharge;
    }
}
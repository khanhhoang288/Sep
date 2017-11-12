using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;

namespace VideoRental
{
    public partial class frmReturnDisk : Form
    {
        
        ReturnDiskBLL rtbll;
        public frmReturnDisk()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReturnDisk_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            rtbll = new ReturnDiskBLL();
            eReturn ert = new eReturn();
            ert.CustomerID = Convert.ToInt32(txtcustomerid.Text);
            ert.DiskID = Convert.ToInt32(txtdiskid.Text);
            ert.ReturnDate = Convert.ToDateTime(dtreturn.Text);

            int temp = rtbll.ReturnDisk(ert);
            if (temp >= 0 )
                MessageBox.Show("Trễ", "Noti", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            {
                MessageBox.Show("Trả đĩa thành công!", "Noti!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                
            }


        }
    }
}

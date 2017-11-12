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
        DiskRentalBLL drbll;
        RentalBLL rbll;
        CustomerBLL cbll;
        public frmReturnDisk()
        {
            InitializeComponent();
            rtbll = new ReturnDiskBLL();
            drbll = new DiskRentalBLL();
            rbll = new RentalBLL();
            cbll= new CustomerBLL();
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
            //rtbll = new ReturnDiskBLL();
            //eReturn ert = new eReturn();
            //ert.CustomerID = Convert.ToInt32(txtcustomerid.Text);
            //ert.DiskID = Convert.ToInt32(txtdiskid.Text);
            //ert.ReturnDate = Convert.ToDateTime(dtreturn.Text);

            //int temp = rtbll.ReturnDisk(ert);
            //if (temp >= 0 )
            //    MessageBox.Show("Trễ", "Noti", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //else
            //{
            //    MessageBox.Show("Trả đĩa thành công!", "Noti!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


            //}


            //0 la chua tra, 1 la tra roi
            eDiskRental dr = new eDiskRental();

            //MessageBox.Show(txtdiskid.Text);
            dr = drbll.getDiskNoRentalByDiskID(Convert.ToInt32(txtdiskid.Text));
            //MessageBox.Show(dr.RentalID.ToString());
            drbll.updateStatusDiskRental(dr, 1);

            

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            eDiskRental dr = new eDiskRental();

            //MessageBox.Show(txtdiskid.Text);
            dr = drbll.getDiskNoRentalByDiskID(Convert.ToInt32(txtdiskid.Text));

            eRental r = new eRental();
            r = rbll.getOneRental(dr.RentalID);

            eCustomer c = new eCustomer();
            c = cbll.getOneCustomer(r.CustomerID);

            lblCustomerName.Text = c.CustomerName;
            //MessageBox.Show(r.CustomerID.ToString());
        }
    }
}

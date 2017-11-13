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
        DiskBLL dbll;
        LateChargeBLL lcbll;
        TitleBLL tbll;
        public frmReturnDisk()
        {
            InitializeComponent();
            rtbll = new ReturnDiskBLL();
            drbll = new DiskRentalBLL();
            rbll = new RentalBLL();
            cbll= new CustomerBLL();
            dbll = new DiskBLL();
            lcbll = new LateChargeBLL();
            tbll = new TitleBLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReturnDisk_Load(object sender, EventArgs e)
        {
            LoadComboBoxDiskID();
            this.cmbDiskID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            label3.Visible = false;
            txtcustomerid.Visible = false;
        }


        public void LoadComboBoxDiskID()
        {
            List<eDisk> ls = dbll.getAllDisk();
            foreach (eDisk item in ls)
            {
                cmbDiskID.Items.Add(item.DiskID);
            }
        }

        public bool checkDataInput()
        {
            //kiem tra xem du lieu da duoc nhap chua
            if (cmbDiskID.Text.Trim() == "")
            {
                MessageBox.Show("ban chua nhap cmbDiskID");
                cmbDiskID.Focus();
                return false;
            }
            return true;
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
            //ert.DiskID = Convert.ToInt32(cmbDiskID.Text);
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

            //MessageBox.Show(cmbDiskID.Text);
            dr = drbll.getDiskNoRentalByDiskID(Convert.ToInt32(cmbDiskID.Text));
            //MessageBox.Show(dr.RentalID.ToString());
            drbll.updateStatusDiskRental(dr, 1);

            eRental er = new eRental();

            er = rbll.getOneRental(dr.RentalID);
            TimeSpan ts= new TimeSpan();
            ts = dr.ReturnDate - er.RentalDate;

            eDisk di = new eDisk();
            di = dbll.getOneDisk(dr.DiskID);

            eLateCharge lc = new eLateCharge();
            MessageBox.Show(er.CustomerID.ToString());
            MessageBox.Show(di.DiskID.ToString());
            lc = lcbll.getOneLateCharge(er.CustomerID, di.DiskID);
            MessageBox.Show(lc.LateChargeID.ToString());
            //lcbll.addLateCharge(lc);
            

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (checkDataInput()==true)
            {
                eDiskRental dr = new eDiskRental();

                //MessageBox.Show(cmbDiskID.Text);
                dr = drbll.getDiskNoRentalByDiskID(Convert.ToInt32(cmbDiskID.Text));

                eRental r = new eRental();
                r = rbll.getOneRental(dr.RentalID);

                eCustomer c = new eCustomer();
                c = cbll.getOneCustomer(r.CustomerID);

                eDisk ed = new eDisk();
                ed = dbll.getOneDisk(dr.DiskID);

                eTitle et = new eTitle();
                et = tbll.getOneTitle(ed.TitleID);

                eLateCharge elc = new eLateCharge();
                elc = lcbll.getOneLateCharge(c.CustomerID,ed.DiskID);

                lblCustomerName.Text = c.CustomerName;
                lblCusTomerID.Text = c.CustomerID.ToString();
                lblAddress.Text =  c.Address;
                lblPhoneNumber.Text = c.PhoneNumber;
                lblRentalDate.Text = r.RentalDate.ToString();
                lblTitleID.Text = et.TitleName;
                lblLateCharge.Text = elc.LateCharge.ToString();
                //MessageBox.Show(r.CustomerID.ToString());
            }

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

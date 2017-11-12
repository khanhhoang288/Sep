using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;

namespace VideoRental
{
    public partial class frmRental : Form
    {
        LateChargeBLL latechargebll;

        List<eRental> listrental;
        RentalBLL rentalbll;
        CustomerBLL cbll;
        List<eCustomer> lsc;

        public frmRental()
        {
            InitializeComponent();
            listrental = new List<eRental>();
            rentalbll = new RentalBLL();
            cbll = new CustomerBLL();
            lsc = new List<eCustomer>();

            latechargebll = new LateChargeBLL();

            listrental = rentalbll.getAllRental();
            LoadDataGridView(dgvRental, listrental);
        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            this.cmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            lblRentalID.Visible = false;
            this.cmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LoadComboBoxCustomer();
            //LoadComboBoxCustomer1(cbll.GetAllCustomer(), "1");
            dgvRental.ReadOnly=true;
            dgvRental.AllowUserToResizeRows = false;

        }

        public void LoadComboBoxCustomer()
        {
            List<eCustomer> ls = cbll.GetAllCustomer();
            foreach (eCustomer item in ls)
            {
                cmbCustomerID.Items.Add(item.CustomerID);
            }
        }

        public void LoadComboBoxCustomer1(List<eCustomer> l,string cid)
        {
            l = cbll.searchCustomer(cid);
            foreach (eCustomer item in l)
            {
                cmbCustomerID.Items.Add(item.CustomerID);
            }
        }
        public void LoadDataGridView(DataGridView dgv, List<eRental> l)
        {
            dgv.DataSource = l;
            dgvRental.AutoResizeRows();
            dgvRental.Columns[0].HeaderText = "Mã Thuê";
            //dgvRental.Columns[0].Width = 150;

            dgvRental.Columns[1].HeaderText = "Mã Khách Hàng";
            //dgvRental.Columns[1].Width = 150;
            dgvRental.Columns[2].HeaderText = "Ngày Thuê";
            //dgvRental.Columns[2].Width = 300;
        }

        public bool checkInput()
        {
            if (cmbCustomerID.Text.Trim() == "")
            {
                MessageBox.Show("ban chua nhap title name");
                cmbCustomerID.Focus();
                return false;
            }

            if (lblRentalID.Text== "lblRentalID")
            {
                MessageBox.Show("ban chua chon ban thua nao");
                cmbCustomerID.Focus();
                return false;
            }


            try
            {
                Int32 n = Convert.ToInt32(cmbCustomerID.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("so txtRentalPeriod qua lon");
                cmbCustomerID.Text="";
                cmbCustomerID.Focus();
                return false;
            }
            return true;
        }

        private void dgvRental_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (dgvRental.SelectedRows.Count > 0)
                {
                    lblRentalID.Text = e.Row.Cells[0].Value.ToString();
                    cmbCustomerID.Text = e.Row.Cells[1].Value.ToString();
                    dtpRental.Text = e.Row.Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
            
        }

        public void addrental()
        {
            
            eRental rental = new eRental();

            rental.CustomerID = Convert.ToInt32(cmbCustomerID.Text);
            rental.RentalDate = Convert.ToDateTime(dtpRental.Text);

            rentalbll.insertRental(rental);



            //LoadDataGridView(dgvRental, rentalbll.getAllRental());

            LoadDataGridView(dgvRental, rentalbll.getRentalByCustomerID(Convert.ToInt32(cmbCustomerID.Text)));
            frmDiskRental child = new frmDiskRental();
            child.Rentalid = Convert.ToInt32( rentalbll.maxRentalID().ToString());
            child.Status = true;
            child.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInput() == true)
                {
                    decimal lc = latechargebll.sumLateChargeByCustomerID(Convert.ToInt32(cmbCustomerID.Text));
                    if (lc <= 0)
                    {
                        addrental();


                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("ban muon thanh toan phi tra tre ko ?", "Late Charge", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                        {
                            frmLateCharge child = new frmLateCharge();
                            child.Cid = Convert.ToInt32(cmbCustomerID.Text);
                            child.Show();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            addrental();
                        }
                        else if (dialogResult == DialogResult.Cancel)
                        {
                            //ko lam gi
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ko co khach hang nay trong he thong, vui long kiem tra lai");
                cmbCustomerID.Text = "";
                cmbCustomerID.Focus();
            }






        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    eRental rental = new eRental();

        //    rental.CustomerID = Convert.ToInt32(cmbCustomerID.Text);
        //    rental.RentalDate = Convert.ToDateTime(dtpRental.Text);

        //    frmDiskRental child = new frmDiskRental();
        //    child.Rentalid = Convert.ToInt32( lblRentalID.Text);
        //    child.Show();
        //}

        private void cmbCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //List<eCustomer> ls = new List<eCustomer>();
            //string cuid = cmbCustomerID.Text;
            //MessageBox.Show(cuid.ToString());
            //ls = cbll.searchCustomer(cuid);
            //MessageBox.Show(cmbCustomerID.Text);
            //LoadComboBoxCustomer1(ls,cmbCustomerID.Text);
            //MessageBox.Show("1");
        }

        private void cmbCustomerID_KeyDown(object sender, KeyEventArgs e)
        {
            //List<eCustomer> ls = new List<eCustomer>();
            //string cuid = cmbCustomerID.Text;
            //MessageBox.Show(cuid.ToString());
            //ls = cbll.searchCustomer(cuid);
            //MessageBox.Show(cmbCustomerID.Text);
            //LoadComboBoxCustomer1(ls, cmbCustomerID.Text);
            //MessageBox.Show("1");
        }

        private void cmbCustomerID_KeyUp(object sender, KeyEventArgs e)
        {
            //List<eCustomer> ls = new List<eCustomer>();
            //ls = cbll.searchCustomer(cmbCustomerID.Text);
            //LoadComboBoxCustomer1(ls, cmbCustomerID.Text);
            //MessageBox.Show("3");
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            eCustomer ec = new eCustomer();
            ec = cbll.getOneCustomer(Convert.ToInt32(cmbCustomerID.Text));
            lblCustomerName.Text = ec.CustomerName;
            lblAddress.Text = ec.Address;
            lblPhone.Text = ec.PhoneNumber;

            LoadDataGridView(dgvRental, rentalbll.getRentalByCustomerID(Convert.ToInt32(cmbCustomerID.Text)));
        }

        private void cmbCustomerID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (checkInput()==true)
            {
                eRental rental = new eRental();

                rental.CustomerID = Convert.ToInt32(cmbCustomerID.Text);
                rental.RentalDate = Convert.ToDateTime(dtpRental.Text);

                frmDiskRental child = new frmDiskRental();
                child.Rentalid = Convert.ToInt32(lblRentalID.Text);
                child.Status = false;
                child.Show();
            }
            
        }
    }
}

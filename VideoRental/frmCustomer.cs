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
    public partial class frmCustomer : Form
    {
        List<eCustomer> listkh;
        CustomerBLL khbll;
       

        public frmCustomer()
        {
            InitializeComponent();
            listkh = new List<eCustomer>();
            khbll = new CustomerBLL();
            listkh = khbll.GetAllCustomer();
            
            
          // LoadDataGridView(dtGvCustomer, listkh);
        }
        public void LoadDataGridView(DataGridView dgv, List<eCustomer> l)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void dtGvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = dtGvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtCustomerName.Text = dtGvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dtGvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtPhoneNumber.Text = dtGvCustomer.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();

        }

        private void dtGvCustomer_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            eCustomer cus = new eCustomer();
            cus.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            cus.CustomerName = txtCustomerName.Text;
            cus.Address = txtAddress.Text;
            cus.PhoneNumber = txtPhoneNumber.Text;


            khbll.AddCustomer(cus);
            LoadDataGridView(dtGvCustomer, khbll.GetAllCustomer());
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            eCustomer cus = new eCustomer();
            cus.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            cus.CustomerName = txtCustomerName.Text;
            cus.Address = txtAddress.Text;
            cus.PhoneNumber = txtPhoneNumber.Text;

            khbll.Update(cus);

            LoadDataGridView(dtGvCustomer, khbll.GetAllCustomer());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int customerid = Convert.ToInt32(txtCustomerID.Text);
            if (khbll.Delete(customerid))
            {
                MessageBox.Show("Thành Công");
                listkh = khbll.GetAllCustomer();
                LoadDataGridView(dtGvCustomer, listkh);

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}

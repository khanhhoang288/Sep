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
using Microsoft.Reporting.WinForms;

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


             LoadDataGridView(dtGvCustomer, listkh);

        }
        public void LoadDataGridView(DataGridView dgv, List<eCustomer> l)
        {
            dgv.DataSource = l;
            dtGvCustomer.AutoResizeRows();
            dtGvCustomer.Columns[0].HeaderText = "Địa Chỉ";
            dtGvCustomer.Columns[1].HeaderText = "Mã Khách Hàng";
            dtGvCustomer.Columns[2].HeaderText = "Tên Khách Hàng";
            dtGvCustomer.Columns[3].HeaderText = "Phone Number";

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cmbLoaiBaoCao.Items.Add("Báo Cáo Thông Tin Khách Hàng");
            cmbLoaiBaoCao.Items.Add("Báo Cáo  Số Đĩa Hiện Tại Của Khách Mượnt");
            cmbLoaiBaoCao.Items.Add("Báo Cáo Thông Tin Đĩa Quá Hạn");
            cmbLoaiBaoCao.SelectedIndex = 0;
            this.cmbLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void dtGvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = dtGvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtCustomerName.Text = dtGvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dtGvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtPhoneNumber.Text = dtGvCustomer.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
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

        private void btnLoaiBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXemBC_Click(object sender, EventArgs e)
        {
            if (cmbLoaiBaoCao.Text == "Báo Cáo Thông Tin Khách Hàng")
            {
                frminforCustomer f = new frminforCustomer();
                f.Show();
            }
            else if (cmbLoaiBaoCao.Text == "Báo Cáo  Số Đĩa Hiện Tại Của Khách Mượn")
            {
                frmInforDiskRental f1 = new frmInforDiskRental();
                f1.Show();
            }

            else if (cmbLoaiBaoCao.Text == "Báo Cáo Thông Tin Đĩa Quá Hạn")
            {
                Frm7c f2 = new Frm7c();
                f2.Show();
            }
            //Frm7c f1 = new Frm7c();
            //f1.Show();
        }
    }
}

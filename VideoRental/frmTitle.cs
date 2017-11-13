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
    public partial class frmTitle : Form
    {
        List<eTitle> listtitle;
        TitleBLL titlebll;
        public frmTitle()
        {
            InitializeComponent();
            listtitle = new List<eTitle>();
            titlebll = new TitleBLL();

            listtitle = titlebll.getAllTitle();
            LoadDataGridView(dgvTitle, listtitle);
        }

        private void frmTitle_Load(object sender, EventArgs e)
        {
            lblID.Visible = true;
            txtTitleStatus.Text = "0";
        }

        public void LoadDataGridView(DataGridView dgv, List<eTitle> l)
        {
            dgv.DataSource = l;
           // dgv.Columns[0].HeaderText = "Title Name";
           // //dgv.Columns[1].Width = 170;

           // dgv.Columns[1].HeaderText = "RentalPeriod";
           // //dgv.Columns[1].Width = 170;

           // dgv.Columns[2].HeaderText = "RentalCharge";
           // //dgv.Columns[2].Width = 170;

           // dgv.Columns[3].HeaderText = "TitleStatus";
           //// dgv.Columns[2].Width = 170;

           // dgv.Columns[4].HeaderText = "Quantity";
           //// dgv.Columns[2].Width = 170;
        }


        public bool checkDataInput()
        {
            //kiem tra xem du lieu da duoc nhap chua
            if(txtTitleName.Text.Trim()=="")
            {
                MessageBox.Show("ban chua nhap title name");
                txtTitleName.Focus();
                return false;
            }
            if (txtRentalPeriod.Text.Trim() == "")
            {
                MessageBox.Show("ban chua nhap txtRentalPeriod");
                txtRentalPeriod.Focus();
                return false;
            }
            if (txtRentalCharge.Text.Trim() == "")
            {
                MessageBox.Show("ban chua nhap txtRentalCharge");
                txtRentalCharge.Focus();
                return false;
            }
            if (txtTitleStatus.Text.Trim() == "")
            {
                MessageBox.Show("ban chua nhap txtTitleStatus");
                txtTitleStatus.Focus();
                return false;
            }
            if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("ban chua nhap txtQuantity");
                txtQuantity.Focus();
                return false;
            }

            
            //bat loi neu du lieu nhap vao lon hon kieu du lieu
            try
            {
                Int32 n = Convert.ToInt32(txtRentalPeriod.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("so txtRentalPeriod qua lon");
                txtRentalPeriod.Clear();
                txtRentalPeriod.Focus();
                return false;
            }

            try
            {
                Int32 n = Convert.ToInt32(txtRentalCharge.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("so txtRentalCharge qua lon");
                txtRentalCharge.Clear();
                txtRentalCharge.Focus();
                return false;
            }

            try
            {
                Int32 n = Convert.ToInt32(txtQuantity.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("so txtQuantity qua lon");
                txtQuantity.Clear();
                txtQuantity.Focus();
                return false;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkDataInput() == true)
            {
                eTitle title = new eTitle();
                title.TitleName = txtTitleName.Text;
                title.RentalPeriod = Convert.ToInt32(txtRentalPeriod.Text);
                title.RentalCharge = Convert.ToDecimal(txtRentalCharge.Text);
                title.TitleStatus = txtTitleStatus.Text;
                title.Quantity = Convert.ToInt32(txtQuantity.Text);

                titlebll.insertTitle(title);
                LoadDataGridView(dgvTitle, titlebll.getAllTitle());
            }
           
                
            
            
        }

        private void dgvTitle_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvTitle.SelectedRows.Count>0)
            {
                lblID.Text= e.Row.Cells["TitleID"].Value.ToString();
                txtTitleName.Text = e.Row.Cells["TitleName"].Value.ToString();
                txtRentalPeriod.Text = e.Row.Cells["RentalPeriod"].Value.ToString();
                txtRentalCharge.Text = e.Row.Cells["RentalCharge"].Value.ToString();
                txtTitleStatus.Text = e.Row.Cells["TitleStatus"].Value.ToString();
                txtQuantity.Text = e.Row.Cells["Quantity"].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int titleid = Convert.ToInt32( lblID.Text);
            if (titlebll.deleteTitle(titleid))
            {
                
                listtitle = titlebll.getAllTitle();
                LoadDataGridView(dgvTitle, listtitle);
                MessageBox.Show("Success");

            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkDataInput()==true)
            {
                eTitle temp = new eTitle();
                temp.TitleID = Convert.ToInt32(lblID.Text);
                temp.TitleName = txtTitleName.Text;
                temp.RentalPeriod = Convert.ToInt32(txtRentalPeriod.Text);
                temp.RentalCharge = Convert.ToInt32(txtRentalCharge.Text);
                temp.TitleStatus = txtTitleStatus.Text;
                temp.Quantity = Convert.ToInt32(txtQuantity.Text);

                titlebll.updateTitle(temp);

                LoadDataGridView(dgvTitle, titlebll.getAllTitle());
            }
            
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtRentalPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtRentalCharge_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

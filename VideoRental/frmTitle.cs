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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eTitle title = new eTitle();
            title.TitleName = txtTitleName.Text;
            title.RentalPeriod = Convert.ToInt32(txtRentalPeriod.Text);
            title.RentalCharge = Convert.ToDecimal(txtRentalCharge.Text);
            title.TitleStatus = txtTitleStatus.Text;
            title.Quantity = Convert.ToInt32( txtQuantity.Text);

            titlebll.insertTitle(title);
            LoadDataGridView(dgvTitle, titlebll.getAllTitle());
        }

        private void dgvTitle_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvTitle.SelectedRows.Count>0)
            {
                txtTitleName.Text = e.Row.Cells["TitleName"].Value.ToString();
                txtRentalPeriod.Text = e.Row.Cells["RentalPeriod"].Value.ToString();
                txtRentalCharge.Text = e.Row.Cells["RentalCharge"].Value.ToString();
                txtTitleStatus.Text = e.Row.Cells["TitleStatus"].Value.ToString();
                txtQuantity.Text = e.Row.Cells["Quantity"].Value.ToString();
            }
        }

        private void dgvTitle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

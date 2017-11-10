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
        List<eRental> listrental;
        RentalBLL rentalbll;
        public frmRental()
        {
            InitializeComponent();
            listrental = new List<eRental>();
            rentalbll = new RentalBLL();

            listrental = rentalbll.getAllRental();
            LoadDataGridView(dgvRental, listrental);
        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            //lblRentalID.Visible = false;
        }

        public void LoadDataGridView(DataGridView dgv, List<eRental> l)
        {
            dgv.DataSource = l;
        }

        private void dgvRental_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                lblRentalID.Text= e.Row.Cells[0].Value.ToString();
                txtCustomerID.Text = e.Row.Cells[1].Value.ToString();
                dtpRental.Text = e.Row.Cells[2].Value.ToString();



            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eRental rental = new eRental();

            rental.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            rental.RentalDate = Convert.ToDateTime(dtpRental.Text);

            rentalbll.insertRental(rental);

            LoadDataGridView(dgvRental, rentalbll.getAllRental());

            ///
            frmDiskRental child = new frmDiskRental();
            child.Rentalid = rental.RentalID;
            child.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            eRental rental = new eRental();

            rental.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            rental.RentalDate = Convert.ToDateTime(dtpRental.Text);

            frmDiskRental child = new frmDiskRental();
            child.Rentalid = Convert.ToInt32( lblRentalID.Text);
            child.Show();
        }
    }
}

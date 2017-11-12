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
    public partial class frmReservation : Form
    {
        List<eReservation> lsre;
        ReservationBLL rebll;
        public frmReservation()
        {
            InitializeComponent();

            lsre = new List<eReservation>();
            rebll = new ReservationBLL();

            lsre = rebll.getAllReservation();

            LoadDataGridView(dgvReservation, lsre);
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {

        }

        public void LoadDataGridView(DataGridView dgv, List<eReservation> l)
        {
            dgv.DataSource =l;
        }

        private void dgvReservation_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvReservation.SelectedRows.Count > 0)
            {
                lblReservationID.Text = e.Row.Cells[1].Value.ToString();
                txtCustomerID.Text= e.Row.Cells[0].Value.ToString();
                dtpReservation.Text= e.Row.Cells[2].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            eReservation er = new eReservation();

            er.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            er.ReservationDate = Convert.ToDateTime(dtpReservation.Text);

            rebll.insertReservation(er);



            LoadDataGridView(dgvReservation, rebll.getAllReservation());


            frmReservationTitle child = new frmReservationTitle();
            child.Reservationid = Convert.ToInt32(rebll.maxReservationlID().ToString());
            child.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtView_Click(object sender, EventArgs e)
        {
            


            frmReservationTitle child = new frmReservationTitle();
            child.Reservationid = Convert.ToInt32(rebll.maxReservationlID().ToString());
            child.Show();
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

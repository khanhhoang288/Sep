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
    public partial class frmReservationTitle : Form
    {
        List<eReservationTitle> lsrt;
        ReservationTitleBLL rtbll;
        public frmReservationTitle()
        {
            InitializeComponent();

            lsrt = new List<eReservationTitle>();
            rtbll = new ReservationTitleBLL();

        }

        private int reservationid;

        public int Reservationid
        {
            get
            {
                return reservationid;
            }

            set
            {
                reservationid = value;
            }
        }

        private void frmReservationTitle_Load(object sender, EventArgs e)
        {
            txtReservationID.Text = Reservationid.ToString();
            lsrt = rtbll.getAllRTbyReservationID(Convert.ToInt32(txtReservationID.Text));
            LoadDataGridView(dgvReservationTitle, lsrt);
        }

        public void LoadDataGridView(DataGridView dgv, List<eReservationTitle> l)
        {
            dgv.DataSource = l;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            eReservationTitle d = new eReservationTitle();
            txtReservationID.Text = Reservationid.ToString();
            d.ReservationID = Convert.ToInt32(txtReservationID.Text);
            d.TitleID = Convert.ToInt32(txtTitleID.Text);

            rtbll.insertReservationTitle(d);
            //diskrentalbll.ins(rental);

            LoadDataGridView(dgvReservationTitle, rtbll.getAllRTbyReservationID(Convert.ToInt32(txtReservationID.Text)));
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            eReservationTitle temp = new eReservationTitle();

            temp.ReservationID = Convert.ToInt32(txtReservationID.Text);
            temp.TitleID = Convert.ToInt32( txtTitleID.Text);


            rtbll.updateReservationTitle(temp);

            LoadDataGridView(dgvReservationTitle, rtbll.getAllRTbyReservationID(Convert.ToInt32(txtReservationID.Text)));
        }

        private void dgvReservationTitle_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvReservationTitle.SelectedRows.Count > 0)
            {
                txtReservationID.Text = e.Row.Cells[0].Value.ToString();
                txtTitleID.Text = e.Row.Cells[1].Value.ToString();
            }
        }
    }
}

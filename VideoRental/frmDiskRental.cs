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
    public partial class frmDiskRental : Form
    {
        private int rentalid;

        public int Rentalid
        {
            get
            {
                return rentalid;
            }

            set
            {
                rentalid = value;
            }
        }

        //LateChargeBLL latechargebll;

        List<eDiskRental> listdiskrental;

        DiskRentalBLL diskrentalbll;
        DiskBLL dbll;
        TitleBLL tbll;
        public frmDiskRental()
        {
            InitializeComponent();
            listdiskrental = new List<eDiskRental>();
            diskrentalbll = new DiskRentalBLL();
            dbll = new DiskBLL();
            tbll = new TitleBLL();

            //label1.Text = rentalid.ToString();
            //listdiskrental = diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(rentalid));
            //LoadDataGridView1(dgvDiskRental, listdiskrental);
            
        }

        private void frmDiskRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRentalDataSet1.tbl_DiskRental' table. You can move, or remove it, as needed.
            //LoadDataGridView();
            label1.Text =  Rentalid.ToString();
            
            listdiskrental = diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(rentalid));
            LoadDataGridView1(dgvDiskRental, listdiskrental);
            txtSumRentCharge.Text = "0";

        }

        public void LoadDataGridView()
        {
            this.tbl_DiskRentalTableAdapter.Fill(this.videoRentalDataSet1.tbl_DiskRental);
        }

        public void LoadDataGridView1(DataGridView d, List<eDiskRental> list)
        {
            d.DataSource = list;
        }

        public bool checkInput()
        {
            foreach(eDiskRental item in diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(rentalid)))
            {
                if (item.DiskID== Convert.ToInt32(txtDiskID.Text))
                {
                    MessageBox.Show("Dia nay da duoc thue, ban hay chon dia khac");
                    txtDiskID.Clear();
                    txtDiskID.Focus();
                    return false;
                }
            }
            return true;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInput()==true)
            {
                eDiskRental d = new eDiskRental();
                label1.Text = rentalid.ToString();
                d.RentalID = Convert.ToInt32(label1.Text);
                d.DiskID = Convert.ToInt32(txtDiskID.Text);
                d.Status = 0;
                d.ReturnDate = Convert.ToDateTime(DateTime.Now.ToString());
                diskrentalbll.insertDiskRental(d);
                //diskrentalbll.ins(rental);

                MessageBox.Show(DateTime.Now.ToString());

                LoadDataGridView1(dgvDiskRental, diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(label1.Text)));

                //int tid = diskrentalbll.getTitleIDByDiskID(Convert.ToInt32(txtDiskID.Text));
                //decimal chargedisk = diskrentalbll.getRentalCharge(tid);
                //decimal sumrental = Convert.ToDecimal(txtSumRentCharge.Text) + chargedisk;
                //int tid = dbll.getTitleIDByDiskID(Convert.ToInt32(txtDiskID.Text));

                eDisk ed = new eDisk();
                ed = dbll.getOneDisk(Convert.ToInt32(txtDiskID.Text));

                eTitle titletemp = tbll.getOneTitle(Convert.ToInt32(ed.TitleID));
                //MessageBox.Show(titletemp.RentalCharge.ToString());
                decimal chargedisk = tbll.getRentalCharge(Convert.ToInt32(titletemp.RentalCharge));
                decimal sumrental = Convert.ToDecimal(txtSumRentCharge.Text) + titletemp.RentalCharge;
                txtSumRentCharge.Text = sumrental.ToString();
            }

           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int titleid = Convert.ToInt32(lblID.Text);
            int rid = Convert.ToInt32(label1.Text);
            int did = Convert.ToInt32(txtDiskID.Text);

            if (diskrentalbll.deleteDiskRental(rid, did))
            {

                listdiskrental = diskrentalbll.getAllDiskRentalByRentalID(rid);
                LoadDataGridView1(dgvDiskRental, listdiskrental);
                MessageBox.Show("Success");

            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        private void dgvDiskRental_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvDiskRental.SelectedRows.Count > 0)
            {
                label1.Text = e.Row.Cells[0].Value.ToString();
                txtDiskID.Text = e.Row.Cells[1].Value.ToString();
               

            }
        }
    }
}

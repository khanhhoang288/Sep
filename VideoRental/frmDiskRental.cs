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



        List<eDiskRental> listdiskrental;
        DiskRentalBLL diskrentalbll;
        public frmDiskRental()
        {
            InitializeComponent();
            listdiskrental = new List<eDiskRental>();
            diskrentalbll = new DiskRentalBLL();
            //label1.Text = rentalid.ToString();
            //listdiskrental = diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(rentalid));
            //LoadDataGridView1(dgvDiskRental, listdiskrental);
            
        }

        

        private void frmDiskRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRentalDataSet1.tbl_DiskRental' table. You can move, or remove it, as needed.
            //LoadDataGridView();
            //label1.Text =  rentalid.ToString();
            
            listdiskrental = diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(rentalid));
            LoadDataGridView1(dgvDiskRental, listdiskrental);

        }

        public void LoadDataGridView()
        {
            this.tbl_DiskRentalTableAdapter.Fill(this.videoRentalDataSet1.tbl_DiskRental);
        }


        public void LoadDataGridView1(DataGridView d, List<eDiskRental> list)
        {
            d.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eDiskRental d = new eDiskRental();
            label1.Text = rentalid.ToString();
            d.RentalID = Convert.ToInt32( label1.Text);
            d.DiskID = Convert.ToInt32(txtDiskID.Text);

            diskrentalbll.insertDiskRental(d);
            //diskrentalbll.ins(rental);

            LoadDataGridView1(dgvDiskRental, diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(label1.Text)));
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

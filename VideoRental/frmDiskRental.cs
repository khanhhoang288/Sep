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

        List<eDiskRental> listdiskrental;
        DiskRentalBLL diskrentalbll;
        public frmDiskRental()
        {
            InitializeComponent();
            listdiskrental = new List<eDiskRental>();
            diskrentalbll = new DiskRentalBLL();

            listdiskrental = diskrentalbll.getAllDiskRentalByRentalID(2);
            LoadDataGridView1(dgvDiskRental, listdiskrental);
            
        }

        private void frmDiskRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRentalDataSet1.tbl_DiskRental' table. You can move, or remove it, as needed.
            //LoadDataGridView();

        }

        public void LoadDataGridView()
        {
            this.tbl_DiskRentalTableAdapter.Fill(this.videoRentalDataSet1.tbl_DiskRental);
        }


        public void LoadDataGridView1(DataGridView d, List<eDiskRental> list)
        {
            d.DataSource = list;
        }
    }
}

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
    public partial class frmDiskManage : Form
    {
        List<eDisk> listdisk;
        DiskBLL diskbll;
        public frmDiskManage()
        {
            listdisk = new List<eDisk>();
            diskbll = new DiskBLL();
            InitializeComponent();
        }

        private void frmDiskManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRentalDataSet.tbl_Disk' table. You can move, or remove it, as needed.
            LoadDataGridView();
            lblDiskID.Visible = false;

        }

        public void LoadDataGridView()
        {
            this.tbl_DiskTableAdapter.Fill(this.videoRentalDataSet.tbl_Disk);
        }
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvDisk.SelectedRows.Count > 0)
            {
                lblDiskID.Text = e.Row.Cells[0].Value.ToString();
                txtTitleID.Text = e.Row.Cells[1].Value.ToString();
                txtDiskStatus.Text = e.Row.Cells[2].Value.ToString();
                txtDiskCode.Text = e.Row.Cells[3].Value.ToString();

               // txtDiskCode.Text = e.Row.Cells[3].Value.ToString();

                //lblDiskID.Text = "1";
                //txtTitleID.Text ="1";
                //txtDiskStatus.Text = "1";
                //txtDiskCode.Text = "1";


                //lblID.Text = e.Row.Cells["TitleID"].Value.ToString();
                //txtTitleName.Text = e.Row.Cells["TitleName"].Value.ToString();
                //txtRentalPeriod.Text = e.Row.Cells["RentalPeriod"].Value.ToString();
                //txtRentalCharge.Text = e.Row.Cells["RentalCharge"].Value.ToString();
                //txtTitleStatus.Text = e.Row.Cells["TitleStatus"].Value.ToString();
                //txtQuantity.Text = e.Row.Cells["Quantity"].Value.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            eDisk disk = new eDisk();
            disk.TitleID = Convert.ToInt32( txtTitleID.Text);
            disk.DiskStatus = txtDiskStatus.Text;
            disk.DiskCode = txtDiskCode.Text;


            diskbll.insertDisk(disk);


            LoadDataGridView();
        }
    }
}

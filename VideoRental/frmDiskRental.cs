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
        private bool status;

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

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
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
            btnAdd.Visible = status;
            btnDelete.Visible = false;
            label2.Visible = status;
            txtSumRentCharge.Visible = status;
            listdiskrental = diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(rentalid));
            LoadDataGridView1(dgvDiskRental, listdiskrental);
            txtSumRentCharge.Text = "0";
            LoadComboBox();

        }


        public void LoadComboBox()
        {
            List<eDisk> ls = dbll.getAllDisk();
            foreach (eDisk item in ls)
            {
                cmbDiskID.Items.Add(item.DiskID);
            }
        }

        public bool checkDataInput()
        {
            if (cmbDiskID.Text.Trim() == "")
            {
                MessageBox.Show("ban chua nhap ma dia");
                cmbDiskID.Text = "";
                cmbDiskID.Focus();
                return false;
            }

            try
            {
                Int32 n = Convert.ToInt32(cmbDiskID.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("so cmbDiskID qua lon");
                cmbDiskID.Text = "";
                cmbDiskID.Focus();
                return false;
            }

            return true;
        }
        public void LoadDataGridView()
        {
            this.tbl_DiskRentalTableAdapter.Fill(this.videoRentalDataSet1.tbl_DiskRental);
        }

        public void LoadDataGridView1(DataGridView d, List<eDiskRental> list)
        {
            d.DataSource = list;
            dgvDiskRental.AutoResizeRows();
            dgvDiskRental.Columns[0].HeaderText = "Mã Đĩa";
            dgvDiskRental.Columns[1].HeaderText = "Mã Thuê";
            dgvDiskRental.Columns[2].HeaderText = "Tình Trạng";
            dgvDiskRental.Columns[3].HeaderText = "Ngày Trả";

        }

        //public bool checkInput()
        //{
        //    foreach(eDiskRental item in diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(rentalid)))
        //    {
        //        if (item.DiskID== Convert.ToInt32(cmbDiskID.Text))
        //        {
        //            MessageBox.Show("Dia nay da duoc thue, ban hay chon dia khac");
        //            cmbDiskID.Clear();
        //            cmbDiskID.Focus();
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkDataInput() == true)
                {
                    eDiskRental d = new eDiskRental();
                    label1.Text = rentalid.ToString();
                    d.RentalID = Convert.ToInt32(label1.Text);
                    d.DiskID = Convert.ToInt32(cmbDiskID.Text);
                    d.Status = 0;
                    d.ReturnDate = Convert.ToDateTime(DateTime.Now.ToString());
                    diskrentalbll.insertDiskRental(d);
                    //diskrentalbll.ins(rental);

                   // MessageBox.Show(DateTime.Now.ToString());

                    LoadDataGridView1(dgvDiskRental, diskrentalbll.getAllDiskRentalByRentalID(Convert.ToInt32(label1.Text)));

                    //int tid = diskrentalbll.getTitleIDByDiskID(Convert.ToInt32(cmbDiskID.Text));
                    //decimal chargedisk = diskrentalbll.getRentalCharge(tid);
                    //decimal sumrental = Convert.ToDecimal(txtSumRentCharge.Text) + chargedisk;
                    //int tid = dbll.getTitleIDByDiskID(Convert.ToInt32(cmbDiskID.Text));

                    eDisk ed = new eDisk();
                    ed = dbll.getOneDisk(Convert.ToInt32(cmbDiskID.Text));

                    eTitle titletemp = tbll.getOneTitle(Convert.ToInt32(ed.TitleID));
                    //MessageBox.Show(titletemp.RentalCharge.ToString());
                    decimal chargedisk = tbll.getRentalCharge(Convert.ToInt32(titletemp.RentalCharge));
                    decimal sumrental = Convert.ToDecimal(txtSumRentCharge.Text) + titletemp.RentalCharge;
                    txtSumRentCharge.Text = sumrental.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ma dia nay khong ton tai tronghe thong, vui long chon lai");
                cmbDiskID.Text = "";
                cmbDiskID.Focus();
            }
            

           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int titleid = Convert.ToInt32(lblID.Text);
            int rid = Convert.ToInt32(label1.Text);
            int did = Convert.ToInt32(cmbDiskID.Text);
            MessageBox.Show(rid.ToString());
            MessageBox.Show(did.ToString());
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
                cmbDiskID.Text = e.Row.Cells[1].Value.ToString();
               

            }
        }

        private void cmbDiskID_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

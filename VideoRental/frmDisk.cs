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
    public partial class frmDisk : Form
    {
        List<eDisk> lsdisk;
        DiskBLL diskbll; 
        public frmDisk()
        {
            lsdisk = new List<eDisk>();
            diskbll = new DiskBLL();

            lsdisk = diskbll.getAllDisk();
            LoadDataGridView(dgvDisk, lsdisk);

            InitializeComponent();
        }

        private void frmDisk_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataGridView(DataGridView dgv, List<eDisk> l)
        {
            //dgv.DataSource = l;
        }

    }
}

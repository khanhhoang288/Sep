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
    public partial class frmLateCharge : Form
    {
        List<eLateCharge> listlc;
        LateChargeBLL lcbll;

        public frmLateCharge()
        {
            InitializeComponent();

            listlc = new List<eLateCharge>();
            lcbll = new LateChargeBLL();

            //listlc = lcbll.getAllLateCharge();
            listlc = lcbll.getLateChargeByCustomerID(2);
            LoadDataGridView(dgvLateCharge, listlc);
        }

        private void frmLateCharge_Load(object sender, EventArgs e)
        {
            txtTotalLateCharge.Text = lcbll.sumLateChargeByCustomerID(2).ToString();
        }

        public void LoadDataGridView(DataGridView dgv, List<eLateCharge> l)
        {
            dgv.DataSource = l;
        }
    }
}

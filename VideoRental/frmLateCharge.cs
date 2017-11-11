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


        private int cid;

        public int Cid
        {
            get
            {
                return cid;
            }

            set
            {
                cid = value;
            }
        }

        public frmLateCharge()
        {
            InitializeComponent();

            listlc = new List<eLateCharge>();
            lcbll = new LateChargeBLL();

            //listlc = lcbll.getAllLateCharge();
            
            
        }

        private void frmLateCharge_Load(object sender, EventArgs e)
        {
            label2.Text = Cid.ToString();
            listlc = lcbll.getLateChargeByCustomerID(Cid);
            LoadDataGridView(dgvLateCharge, listlc);
            txtTotalLateCharge.Text = lcbll.sumLateChargeByCustomerID(cid).ToString();
        }

        public void LoadDataGridView(DataGridView dgv, List<eLateCharge> l)
        {
            dgv.DataSource = l;
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (rdbAllLateCharge.Checked==true)
            {
                foreach (eLateCharge item in lcbll.getLateChargeByCustomerID(Cid))
                {
                    lcbll.updateLatecharFee(item.LateChargeID);
                }
            }
            else if (rdbPartLateCharge.Checked==true)
            {

            }
        }
    }
}

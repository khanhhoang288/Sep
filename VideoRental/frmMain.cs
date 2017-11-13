using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadTabRental();
            LoadTabReturn();
            LoadTabDiskManager();
            LoadTabCustomer();
        }

        private void LoadTabRental()
        {
            frmRental frm = new frmRental();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl.TabPages[0].Controls.Add(frm);
        }

        private void LoadTabReturn()
        {
            frmReturnDisk frm = new frmReturnDisk();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl.TabPages[1].Controls.Add(frm);
        }

        private void LoadTabDiskManager()
        {
            frmTitle frm = new frmTitle();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl.TabPages[2].Controls.Add(frm);
        }

        private void LoadTabCustomer()
        {
            frmCustomer frm = new frmCustomer();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl.TabPages[3].Controls.Add(frm);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAcount f = new frmAcount();
            f.Show();
        }
    }
}

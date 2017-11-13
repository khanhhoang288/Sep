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
    public partial class frmAcount : Form
    {
        public frmAcount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Noti", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AcountBLL taikhoanbll = new AcountBLL();
            int kq = taikhoanbll.KiemTraDangNhap(txtUserName.Text, txtPassword.Text);
            if (kq == 0)
                MessageBox.Show("Sai ID hoặc Password !", "Thông báo");
            else
            {

                
                // show form Main
                frmMain frmnew = new frmMain();
                frmnew.StatusLogin = 1;

                frmnew.ShowDialog();

                frmTitle frmtitle = new frmTitle();
               // frmtitle.StatusLogin = ;

            }
        }

        private void frmAcount_Load(object sender, EventArgs e)
        {

        }
    }
}

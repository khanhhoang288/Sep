﻿using System;
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

        private int statusLogin;

        public int StatusLogin
        {
            get
            {
                return statusLogin;
            }

            set
            {
                statusLogin = value;
            }
        }

        

        public frmMain()
        {
            InitializeComponent();
     
           
        }

        private void LoadTabRental()
        {

            frmRental frm = new frmRental();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl.TabPages[0].Controls.Add(frm);
            //MessageBox.Show(StatusLogin.ToString());
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
        private void LoadTabTitle()
        {
            frmTitle frm = new frmTitle();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            //tabControl.TabPages[4].Controls.Add(frm);



        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Visible = false;

            //MessageBox.Show(StatusLogin.ToString());
            label1.Text = StatusLogin.ToString();

            //MessageBox.Show(label1.Text);
            if (statusLogin==1)
            {
                LoadTabRental();
                LoadTabReturn();
                LoadTabDiskManager();
                LoadTabCustomer();
                LoadTabTitle();
            }
            else
            {
                LoadTabRental();
                LoadTabReturn();
                LoadTabDiskManager();
                LoadTabCustomer();
                // LoadTabTitle();
                //tabControl.TabPages[4].Hide();

            }
            
        }
    }
}

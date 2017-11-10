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
    public partial class frmTitle : Form
    {
        List<eTitle> listtitle;
        TitleBLL titlebll;
        public frmTitle()
        {
            InitializeComponent();
            listtitle = new List<eTitle>();
            titlebll = new TitleBLL();

            listtitle = titlebll.getAllTitle();
            LoadDataGridView(dgvTitle, listtitle);
        }

        private void frmTitle_Load(object sender, EventArgs e)
        {

        }

        public void LoadDataGridView(DataGridView dgv, List<eTitle> l)
        {
            dgv.DataSource = l;
            dgv.Columns[0].HeaderText = "Title Name";
            dgv.Columns[1].Width = 170;

            dgv.Columns[1].HeaderText = "RentalPeriod";
            dgv.Columns[1].Width = 170;

            dgv.Columns[2].HeaderText = "RentalCharge";
            dgv.Columns[2].Width = 170;

            dgv.Columns[2].HeaderText = "TitleStatus";
            dgv.Columns[2].Width = 170;

            dgv.Columns[2].HeaderText = "Quantity";
            dgv.Columns[2].Width = 170;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace VideoRental
{
    public partial class frmInforDiskRental : Form
    {
        public frmInforDiskRental()
        {
            InitializeComponent();
        }

        private void frmInforDiskRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.View_7bfinal' table. You can move, or remove it, as needed.
            this.view_7bfinalTableAdapter.Fill(this.dataSet1.View_7bfinal);
            // TODO: This line of code loads data into the 'dataSet1.View_7b' table. You can move, or remove it, as needed.
            this.view_7bTableAdapter.Fill(this.dataSet1.View_7b);

            this.reportViewer1.RefreshReport();
           SetParameters(cbidcus.SelectedValue.ToString());
           reportViewer1.RefreshReport();
        }
        private void SetParameters(string customerid)
        {
            ReportParameter rp = new ReportParameter("CustomerID");
            rp.Values.Add(customerid);
            reportViewer1.LocalReport.SetParameters(rp);

        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            SetParameters(cbidcus.SelectedValue.ToString());
            reportViewer1.RefreshReport();
        }

        private void cbidcus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

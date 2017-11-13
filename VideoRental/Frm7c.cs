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
    public partial class Frm7c : Form
    {
        public Frm7c()
        {
            InitializeComponent();
        }

        private void Frm7c_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.View_7c' table. You can move, or remove it, as needed.
            this.view_7cTableAdapter.Fill(this.dataSet1.View_7c);

            this.reportViewer1.RefreshReport();
            SetParameters(cbcustomername7c.SelectedValue.ToString());
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void SetParameters(string customerid)
        {
            ReportParameter rp = new ReportParameter("CustomerID");
            rp.Values.Add(customerid);
            reportViewer1.LocalReport.SetParameters(rp);

        }


        private void btntk_Click(object sender, EventArgs e)
        {
            SetParameters(cbcustomername7c.SelectedValue.ToString());
            reportViewer1.RefreshReport();
        }
    }
}

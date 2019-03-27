using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            List<YueYePlat.Model.clientinfo> reportList = new YueYePlat.BLL.clientinfo().GetModelList("");
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ClientInfo", reportList));
            this.reportViewer1.RefreshReport();          
        }
    }
}

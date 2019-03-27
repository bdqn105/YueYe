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
    public partial class FrmVehicleKeepReport : Form
    {
        public FrmVehicleKeepReport()
        {
            InitializeComponent();
        }

        private void FrmVehicleKeepReport_Load(object sender, EventArgs e)
        {
            List<YueYePlat.Model.vehicleupkeep> vehiclekeepList = new YueYePlat.BLL.vehicleupkeep().GetModelList("");           
            this.rpView.LocalReport.DataSources.Add(new ReportDataSource("VehicleKeepList", vehiclekeepList));
            this.rpView.RefreshReport();
        }
    }
}

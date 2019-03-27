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
    public partial class FrmChargeback : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.logiscompanyinfo> logisCompanyList;
        public FrmChargeback()
        {
            InitializeComponent();
        }

        private void FrmChargeback_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logisCompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logisCompanyList[0].CompanyDBName);
        }
    }
}

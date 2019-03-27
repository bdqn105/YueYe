using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmTransferFeeType : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public string strCollected="";
        public FrmTransferFeeType()
        {
            InitializeComponent();
        }

        private void FrmTransferFeeType_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo.CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string feetype = config.AppSettings.Settings["feeType"].Value;
            List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList("");
            for (int i = 0; i < feetypeList.Count; i++)
            {
                if(!feetype.Contains(feetypeList[i].FeeTypeName))
                    chkLBFeeType.Items.Add(feetypeList[i].FeeTypeName);
            }        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            strCollected = string.Empty;
            for (int i = 0; i < chkLBFeeType.Items.Count; i++)
            {
                if (chkLBFeeType.GetItemChecked(i))
                {
                    if (strCollected == string.Empty)
                    {
                        strCollected = chkLBFeeType.GetItemText(chkLBFeeType.Items[i]);
                    }
                    else
                    {
                        strCollected = strCollected + ";" + chkLBFeeType.GetItemText(chkLBFeeType.Items[i]);
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddFeeType_Click(object sender, EventArgs e)
        {
            FrmFeeType feeType = new FrmFeeType();
            feeType.usersInfo = usersInfo;
            if(feeType.ShowDialog()==DialogResult.OK)
            {
                chkLBFeeType.Items.Clear();
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string feetype = config.AppSettings.Settings["feeType"].Value;
                List<YueYePlat.Model.feetype> feetypeList = new YueYePlat.BLL.feetype().GetModelList("");
                for (int i = 0; i < feetypeList.Count; i++)
                {
                    if (!feetype.Contains(feetypeList[i].FeeTypeName))
                        chkLBFeeType.Items.Add(feetypeList[i].FeeTypeName);
                }
            }
        }
    }
}

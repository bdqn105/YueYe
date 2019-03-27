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
    
    public partial class FrmJamphotomanger : Form
    {
        YueYePlat.BLL.jamphotomanger bll;
        List<YueYePlat.Model.jamphotomanger> jamphotoList;
        public YueYePlat.Model.usersinfo usersInfo;
        public string strDeliveryId = "";


        static FrmJamphotomanger  instance;
        public string tabPageTitle = "";
        public FrmJamphotomanger()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.jamphotomanger();
        }
        public static FrmJamphotomanger getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmJamphotomanger();
            }
            return instance;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            Parent.Dispose();
            this.Close();
            this.Dispose();
        }

        private void FrmJamphotomanger_Load(object sender, EventArgs e)
        {
            dgvJamphoto.AutoGenerateColumns = false;
            jamphotoList = bll.GetModelList("");
            dgvJamphoto.DataSource = null;
            dgvJamphoto.DataSource = jamphotoList;
            if (dgvJamphoto.Rows.Count > 0)
            {
                dgvJamphoto.Rows[0].Selected = false;
            }
            //if (strDeliveryId != "")
            //{
            //    jamphotoList = bll.GetModelList(String.Format("DeliveryId='{0}'", strDeliveryId));
            //    dgvJamphoto.DataSource = null;
            //    dgvJamphoto.DataSource = jamphotoList;
            //    if (dgvJamphoto.Rows.Count > 0)
            //    {
            //        dgvJamphoto.Rows[0].Selected = false;
            //    }
            //}
            //else
            //{
            //    jamphotoList = bll.GetModelList("");
            //    dgvJamphoto.DataSource = null;
            //    dgvJamphoto.DataSource = jamphotoList;
            //    if (dgvJamphoto.Rows.Count > 0)
            //    {
            //        dgvJamphoto.Rows[0].Selected = false;
            //    }
            //}


        }

        private void btnLoadJamPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadJamPhoto_Click(object sender, EventArgs e)
        {

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ActiveControl is TextBox || ActiveControl is ComboBox) &&
                keyData == Keys.Enter)
            {
                keyData = Keys.Tab;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}

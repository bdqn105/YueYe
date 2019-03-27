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
    public partial class FrmTransferPathMap : Form
    {
        public static string location = "";
        public static string lng = "";
        public static string lat = "";
        public FrmTransferPathMap()
        {
            InitializeComponent();
        }

        private void FrmTransferPathMap_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\DeliveryPath.html";
            Uri url = new Uri(str_url);
            webBrowser1.Url = url;
            webBrowser1.ObjectForScripting = this;
        }
        public void getLocationName(string name)
        {
            location = name;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public void getLocation(string location)
        {
            lng = getcheck(location)[0].Trim();
            lat = getcheck(location)[1].Trim();
        }
        public string[] getcheck(String str)
        {
            string[] sArray = str.Split(';');
            return sArray;
        }
    }
}

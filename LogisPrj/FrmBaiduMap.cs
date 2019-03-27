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
    public partial class FrmBaiduMap : Form
    {
        public static string lng = "";
        public static string lat ="";
        public static string destionation = "";
        public static string btnStatus = "0";
        public FrmBaiduMap()
        {
            InitializeComponent();
        }
        private void FrmBaiduMap_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\BaiduMap.html";
            Uri url = new Uri(str_url);
            webBrowser1.Url = url;
            webBrowser1.ObjectForScripting = this;
        }
        public void getLocation(string location)
        {
            lng = getcheck(location)[0].Trim ();
            lat = getcheck(location)[1].Trim ();                   
        }
        public void getLocationName(string name)
        {
            destionation = name;
            //this.DialogResult= DialogResult.OK;
            //this.Close();
        }
        public string[] getcheck(String str)
        {
            string[] sArray = str.Split(';');
            return sArray;
        }
        public void getbtnStatus(string status)
        {
            btnStatus = status;
            if (btnStatus == "1")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

      
    }
}

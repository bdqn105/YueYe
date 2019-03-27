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
    public partial class FrmFee : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        static FrmFee instance;
        public string tabPageTitle = "";
        public FrmFee()
        {
            InitializeComponent();
        }
        public static FrmFee getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmFee();
            }
            return instance;
        }   

        private void btnRoadtoll_Click(object sender, EventArgs e)
        {
            FrmRoadtoll roadtoll = new FrmRoadtoll();
            roadtoll.usersInfo = usersInfo;
            //roadtoll.Parent=FrmMain.          
            if (roadtoll.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRefueling refueling = new FrmRefueling();
            refueling.usersInfo = usersInfo;
            if (refueling.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

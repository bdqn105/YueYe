using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace YueYePlat.Web.vehihiclemileage
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtVehicleID.Text.Trim().Length==0)
			{
				strErr+="VehicleID不能为空！\\n";	
			}
			if(this.txtDailyMileage.Text.Trim().Length==0)
			{
				strErr+="DailyMileage不能为空！\\n";	
			}
			if(this.txtToalMileage.Text.Trim().Length==0)
			{
				strErr+="ToalMileage不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcurDate.Text))
			{
				strErr+="curDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string VehicleID=this.txtVehicleID.Text;
			string DailyMileage=this.txtDailyMileage.Text;
			string ToalMileage=this.txtToalMileage.Text;
			DateTime curDate=DateTime.Parse(this.txtcurDate.Text);

			YueYePlat.Model.vehihiclemileage model=new YueYePlat.Model.vehihiclemileage();
			model.VehicleID=VehicleID;
			model.DailyMileage=DailyMileage;
			model.ToalMileage=ToalMileage;
			model.curDate=curDate;

			YueYePlat.BLL.vehihiclemileage bll=new YueYePlat.BLL.vehihiclemileage();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

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
namespace YueYePlat.Web.tempvehicleinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtVehicleId.Text.Trim().Length==0)
			{
				strErr+="VehicleId不能为空！\\n";	
			}
			if(this.txtDriverId.Text.Trim().Length==0)
			{
				strErr+="DriverId不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTime.Text))
			{
				strErr+="Time格式错误！\\n";	
			}
			if(this.txtComents.Text.Trim().Length==0)
			{
				strErr+="Coments不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string VehicleId=this.txtVehicleId.Text;
			string DriverId=this.txtDriverId.Text;
			DateTime Time=DateTime.Parse(this.txtTime.Text);
			string Coments=this.txtComents.Text;

			YueYePlat.Model.tempvehicleinfo model=new YueYePlat.Model.tempvehicleinfo();
			model.VehicleId=VehicleId;
			model.DriverId=DriverId;
			model.Time=Time;
			model.Coments=Coments;

			YueYePlat.BLL.tempvehicleinfo bll=new YueYePlat.BLL.tempvehicleinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

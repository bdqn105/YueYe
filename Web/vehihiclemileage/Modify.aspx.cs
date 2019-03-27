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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int MileageID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(MileageID);
				}
			}
		}
			
	private void ShowInfo(int MileageID)
	{
		YueYePlat.BLL.vehihiclemileage bll=new YueYePlat.BLL.vehihiclemileage();
		YueYePlat.Model.vehihiclemileage model=bll.GetModel(MileageID);
		this.lblMileageID.Text=model.MileageID.ToString();
		this.txtVehicleID.Text=model.VehicleID;
		this.txtDailyMileage.Text=model.DailyMileage;
		this.txtToalMileage.Text=model.ToalMileage;
		this.txtcurDate.Text=model.curDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int MileageID=int.Parse(this.lblMileageID.Text);
			string VehicleID=this.txtVehicleID.Text;
			string DailyMileage=this.txtDailyMileage.Text;
			string ToalMileage=this.txtToalMileage.Text;
			DateTime curDate=DateTime.Parse(this.txtcurDate.Text);


			YueYePlat.Model.vehihiclemileage model=new YueYePlat.Model.vehihiclemileage();
			model.MileageID=MileageID;
			model.VehicleID=VehicleID;
			model.DailyMileage=DailyMileage;
			model.ToalMileage=ToalMileage;
			model.curDate=curDate;

			YueYePlat.BLL.vehihiclemileage bll=new YueYePlat.BLL.vehihiclemileage();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

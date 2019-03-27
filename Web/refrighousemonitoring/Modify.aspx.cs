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
namespace YueYePlat.Web.refrighousemonitoring
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int Id)
	{
		YueYePlat.BLL.refrighousemonitoring bll=new YueYePlat.BLL.refrighousemonitoring();
		YueYePlat.Model.refrighousemonitoring model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtHouseId.Text=model.HouseId;
		this.txtTemperature1.Text=model.Temperature1;
		this.txtHumidity1.Text=model.Humidity1;
		this.txtTemperature2.Text=model.Temperature2;
		this.txtHumidity2.Text=model.Humidity2;
		this.txtTemperature3.Text=model.Temperature3;
		this.txtHumidity3.Text=model.Humidity3;
		this.txtMonitorTime.Text=model.MonitorTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtHouseId.Text.Trim().Length==0)
			{
				strErr+="HouseId不能为空！\\n";	
			}
			if(this.txtTemperature1.Text.Trim().Length==0)
			{
				strErr+="Temperature1不能为空！\\n";	
			}
			if(this.txtHumidity1.Text.Trim().Length==0)
			{
				strErr+="Humidity1不能为空！\\n";	
			}
			if(this.txtTemperature2.Text.Trim().Length==0)
			{
				strErr+="Temperature2不能为空！\\n";	
			}
			if(this.txtHumidity2.Text.Trim().Length==0)
			{
				strErr+="Humidity2不能为空！\\n";	
			}
			if(this.txtTemperature3.Text.Trim().Length==0)
			{
				strErr+="Temperature3不能为空！\\n";	
			}
			if(this.txtHumidity3.Text.Trim().Length==0)
			{
				strErr+="Humidity3不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtMonitorTime.Text))
			{
				strErr+="MonitorTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string HouseId=this.txtHouseId.Text;
			string Temperature1=this.txtTemperature1.Text;
			string Humidity1=this.txtHumidity1.Text;
			string Temperature2=this.txtTemperature2.Text;
			string Humidity2=this.txtHumidity2.Text;
			string Temperature3=this.txtTemperature3.Text;
			string Humidity3=this.txtHumidity3.Text;
			DateTime MonitorTime=DateTime.Parse(this.txtMonitorTime.Text);


			YueYePlat.Model.refrighousemonitoring model=new YueYePlat.Model.refrighousemonitoring();
			model.Id=Id;
			model.HouseId=HouseId;
			model.Temperature1=Temperature1;
			model.Humidity1=Humidity1;
			model.Temperature2=Temperature2;
			model.Humidity2=Humidity2;
			model.Temperature3=Temperature3;
			model.Humidity3=Humidity3;
			model.MonitorTime=MonitorTime;

			YueYePlat.BLL.refrighousemonitoring bll=new YueYePlat.BLL.refrighousemonitoring();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

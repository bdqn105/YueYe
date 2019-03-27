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
namespace YueYePlat.Web.deliverycurtempinfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					long Id=(Convert.ToInt64(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(long Id)
	{
		YueYePlat.BLL.deliverycurtempinfo bll=new YueYePlat.BLL.deliverycurtempinfo();
		YueYePlat.Model.deliverycurtempinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDeliveryId.Text=model.DeliveryId;
		this.txtTemperature1.Text=model.Temperature1;
		this.txtHumidity1.Text=model.Humidity1;
		this.txtTemperature2.Text=model.Temperature2;
		this.txtHumidity2.Text=model.Humidity2;
		this.txtTemperature3.Text=model.Temperature3;
		this.txtHumidity3.Text=model.Humidity3;
		this.txtCurrentTime.Text=model.CurrentTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliveryId.Text.Trim().Length==0)
			{
				strErr+="DeliveryId不能为空！\\n";	
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
			if(!PageValidate.IsDateTime(txtCurrentTime.Text))
			{
				strErr+="CurrentTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long Id=long.Parse(this.lblId.Text);
			string DeliveryId=this.txtDeliveryId.Text;
			string Temperature1=this.txtTemperature1.Text;
			string Humidity1=this.txtHumidity1.Text;
			string Temperature2=this.txtTemperature2.Text;
			string Humidity2=this.txtHumidity2.Text;
			string Temperature3=this.txtTemperature3.Text;
			string Humidity3=this.txtHumidity3.Text;
			DateTime CurrentTime=DateTime.Parse(this.txtCurrentTime.Text);


			YueYePlat.Model.deliverycurtempinfo model=new YueYePlat.Model.deliverycurtempinfo();
			model.Id=Id;
			model.DeliveryId=DeliveryId;
			model.Temperature1=Temperature1;
			model.Humidity1=Humidity1;
			model.Temperature2=Temperature2;
			model.Humidity2=Humidity2;
			model.Temperature3=Temperature3;
			model.Humidity3=Humidity3;
			model.CurrentTime=CurrentTime;

			YueYePlat.BLL.deliverycurtempinfo bll=new YueYePlat.BLL.deliverycurtempinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

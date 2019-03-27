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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtId.Text))
			{
				strErr+="Id格式错误！\\n";	
			}
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
			int Id=int.Parse(this.txtId.Text);
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

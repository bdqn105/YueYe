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
namespace YueYePlat.Web.deliverycurgpsinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliveryId.Text.Trim().Length==0)
			{
				strErr+="DeliveryId不能为空！\\n";	
			}
			if(this.txtLongitude.Text.Trim().Length==0)
			{
				strErr+="Longitude不能为空！\\n";	
			}
			if(this.txtLatitude.Text.Trim().Length==0)
			{
				strErr+="Latitude不能为空！\\n";	
			}
			if(this.txtSpeed.Text.Trim().Length==0)
			{
				strErr+="Speed不能为空！\\n";	
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
			string DeliveryId=this.txtDeliveryId.Text;
			string Longitude=this.txtLongitude.Text;
			string Latitude=this.txtLatitude.Text;
			string Speed=this.txtSpeed.Text;
			DateTime CurrentTime=DateTime.Parse(this.txtCurrentTime.Text);

			YueYePlat.Model.deliverycurgpsinfo model=new YueYePlat.Model.deliverycurgpsinfo();
			model.DeliveryId=DeliveryId;
			model.Longitude=Longitude;
			model.Latitude=Latitude;
			model.Speed=Speed;
			model.CurrentTime=CurrentTime;

			YueYePlat.BLL.deliverycurgpsinfo bll=new YueYePlat.BLL.deliverycurgpsinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

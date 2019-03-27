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
namespace YueYePlat.Web.vehiclejam
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeliverId.Text.Trim().Length==0)
			{
				strErr+="DeliverId不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtJamTime.Text))
			{
				strErr+="JamTime格式错误！\\n";	
			}
			if(this.txtJamLocation.Text.Trim().Length==0)
			{
				strErr+="JamLocation不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DeliverId=this.txtDeliverId.Text;
			DateTime JamTime=DateTime.Parse(this.txtJamTime.Text);
			string JamLocation=this.txtJamLocation.Text;

			YueYePlat.Model.vehiclejam model=new YueYePlat.Model.vehiclejam();
			model.DeliverId=DeliverId;
			model.JamTime=JamTime;
			model.JamLocation=JamLocation;

			YueYePlat.BLL.vehiclejam bll=new YueYePlat.BLL.vehiclejam();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

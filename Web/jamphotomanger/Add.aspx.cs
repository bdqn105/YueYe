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
namespace YueYePlat.Web.jamphotomanger
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtJamId.Text.Trim().Length==0)
			{
				strErr+="JamId不能为空！\\n";	
			}
			if(this.txtJamPhotos.Text.Trim().Length==0)
			{
				strErr+="JamPhotos不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string JamId=this.txtJamId.Text;
			string JamPhotos=this.txtJamPhotos.Text;

			YueYePlat.Model.jamphotomanger model=new YueYePlat.Model.jamphotomanger();
			model.JamId=JamId;
			model.JamPhotos=JamPhotos;

			YueYePlat.BLL.jamphotomanger bll=new YueYePlat.BLL.jamphotomanger();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

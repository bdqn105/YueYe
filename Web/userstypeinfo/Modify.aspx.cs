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
namespace YueYePlat.Web.userstypeinfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UserTypeId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(UserTypeId);
				}
			}
		}
			
	private void ShowInfo(int UserTypeId)
	{
		YueYePlat.BLL.userstypeinfo bll=new YueYePlat.BLL.userstypeinfo();
		YueYePlat.Model.userstypeinfo model=bll.GetModel(UserTypeId);
		this.lblUserTypeId.Text=model.UserTypeId.ToString();
		this.txtUserTypeName.Text=model.UserTypeName;
		this.txtUserControlId.Text=model.UserControlId;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserTypeName.Text.Trim().Length==0)
			{
				strErr+="UserTypeName不能为空！\\n";	
			}
			if(this.txtUserControlId.Text.Trim().Length==0)
			{
				strErr+="UserControlId不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UserTypeId=int.Parse(this.lblUserTypeId.Text);
			string UserTypeName=this.txtUserTypeName.Text;
			string UserControlId=this.txtUserControlId.Text;


			YueYePlat.Model.userstypeinfo model=new YueYePlat.Model.userstypeinfo();
			model.UserTypeId=UserTypeId;
			model.UserTypeName=UserTypeName;
			model.UserControlId=UserControlId;

			YueYePlat.BLL.userstypeinfo bll=new YueYePlat.BLL.userstypeinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

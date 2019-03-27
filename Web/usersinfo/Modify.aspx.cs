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
namespace YueYePlat.Web.usersinfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		YueYePlat.BLL.usersinfo bll=new YueYePlat.BLL.usersinfo();
		YueYePlat.Model.usersinfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtUserId.Text=model.UserId;
		this.txtUserName.Text=model.UserName;
		this.txtUserSex.Text=model.UserSex;
		this.txtUserPassword.Text=model.UserPassword;
		this.txtUserState.Text=model.UserState.ToString();
		this.txtUserTypeId.Text=model.UserTypeId;
		this.txtCompanyId.Text=model.CompanyId;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserId.Text.Trim().Length==0)
			{
				strErr+="UserId不能为空！\\n";	
			}
			if(this.txtUserName.Text.Trim().Length==0)
			{
				strErr+="UserName不能为空！\\n";	
			}
			if(this.txtUserSex.Text.Trim().Length==0)
			{
				strErr+="UserSex不能为空！\\n";	
			}
			if(this.txtUserPassword.Text.Trim().Length==0)
			{
				strErr+="UserPassword不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserState.Text))
			{
				strErr+="UserState格式错误！\\n";	
			}
			if(this.txtUserTypeId.Text.Trim().Length==0)
			{
				strErr+="UserTypeId不能为空！\\n";	
			}
			if(this.txtCompanyId.Text.Trim().Length==0)
			{
				strErr+="CompanyId不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string UserId=this.txtUserId.Text;
			string UserName=this.txtUserName.Text;
			string UserSex=this.txtUserSex.Text;
			string UserPassword=this.txtUserPassword.Text;
			int UserState=int.Parse(this.txtUserState.Text);
			string UserTypeId=this.txtUserTypeId.Text;
			string CompanyId=this.txtCompanyId.Text;


			YueYePlat.Model.usersinfo model=new YueYePlat.Model.usersinfo();
			model.ID=ID;
			model.UserId=UserId;
			model.UserName=UserName;
			model.UserSex=UserSex;
			model.UserPassword=UserPassword;
			model.UserState=UserState;
			model.UserTypeId=UserTypeId;
			model.CompanyId=CompanyId;

			YueYePlat.BLL.usersinfo bll=new YueYePlat.BLL.usersinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

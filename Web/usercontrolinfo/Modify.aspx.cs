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
namespace YueYePlat.Web.usercontrolinfo
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
		YueYePlat.BLL.usercontrolinfo bll=new YueYePlat.BLL.usercontrolinfo();
		YueYePlat.Model.usercontrolinfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtUserControlId.Text=model.UserControlId;
		this.txtUserControlName.Text=model.UserControlName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserControlId.Text.Trim().Length==0)
			{
				strErr+="UserControlId不能为空！\\n";	
			}
			if(this.txtUserControlName.Text.Trim().Length==0)
			{
				strErr+="UserControlName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string UserControlId=this.txtUserControlId.Text;
			string UserControlName=this.txtUserControlName.Text;


			YueYePlat.Model.usercontrolinfo model=new YueYePlat.Model.usercontrolinfo();
			model.Id=Id;
			model.UserControlId=UserControlId;
			model.UserControlName=UserControlName;

			YueYePlat.BLL.usercontrolinfo bll=new YueYePlat.BLL.usercontrolinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

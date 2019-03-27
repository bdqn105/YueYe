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
namespace YueYePlat.Web.logistouser
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtLogisCompanyID.Text.Trim().Length==0)
			{
				strErr+="LogisCompanyID不能为空！\\n";	
			}
			if(this.txtUserID.Text.Trim().Length==0)
			{
				strErr+="UserID不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCurDate.Text))
			{
				strErr+="CurDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string LogisCompanyID=this.txtLogisCompanyID.Text;
			string UserID=this.txtUserID.Text;
			DateTime CurDate=DateTime.Parse(this.txtCurDate.Text);

			YueYePlat.Model.logistouser model=new YueYePlat.Model.logistouser();
			model.LogisCompanyID=LogisCompanyID;
			model.UserID=UserID;
			model.CurDate=CurDate;

			YueYePlat.BLL.logistouser bll=new YueYePlat.BLL.logistouser();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

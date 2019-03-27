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
namespace YueYePlat.Web.exceptioninfo
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
			if(this.txtExceptionType.Text.Trim().Length==0)
			{
				strErr+="ExceptionType不能为空！\\n";	
			}
			if(this.txtExceptiondescribe.Text.Trim().Length==0)
			{
				strErr+="Exceptiondescribe不能为空！\\n";	
			}
			if(this.txtExceptionDispose.Text.Trim().Length==0)
			{
				strErr+="ExceptionDispose不能为空！\\n";	
			}
			if(this.txtSender.Text.Trim().Length==0)
			{
				strErr+="Sender不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSendTime.Text))
			{
				strErr+="SendTime格式错误！\\n";	
			}
			if(this.txtConductor.Text.Trim().Length==0)
			{
				strErr+="Conductor不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDisposeTime.Text))
			{
				strErr+="DisposeTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DeliverId=this.txtDeliverId.Text;
			string ExceptionType=this.txtExceptionType.Text;
			string Exceptiondescribe=this.txtExceptiondescribe.Text;
			string ExceptionDispose=this.txtExceptionDispose.Text;
			string Sender=this.txtSender.Text;
			DateTime SendTime=DateTime.Parse(this.txtSendTime.Text);
			string Conductor=this.txtConductor.Text;
			DateTime DisposeTime=DateTime.Parse(this.txtDisposeTime.Text);

			YueYePlat.Model.exceptioninfo model=new YueYePlat.Model.exceptioninfo();
			model.DeliverId=DeliverId;
			model.ExceptionType=ExceptionType;
			model.Exceptiondescribe=Exceptiondescribe;
			model.ExceptionDispose=ExceptionDispose;
			model.Sender=Sender;
			model.SendTime=SendTime;
			model.Conductor=Conductor;
			model.DisposeTime=DisposeTime;

			YueYePlat.BLL.exceptioninfo bll=new YueYePlat.BLL.exceptioninfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

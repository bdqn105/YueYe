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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					long JamId=(Convert.ToInt64(Request.Params["id"]));
					ShowInfo(JamId);
				}
			}
		}
			
	private void ShowInfo(long JamId)
	{
		YueYePlat.BLL.vehiclejam bll=new YueYePlat.BLL.vehiclejam();
		YueYePlat.Model.vehiclejam model=bll.GetModel(JamId);
		this.lblJamId.Text=model.JamId.ToString();
		this.txtDeliverId.Text=model.DeliverId;
		this.txtJamTime.Text=model.JamTime.ToString();
		this.txtJamLocation.Text=model.JamLocation;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			long JamId=long.Parse(this.lblJamId.Text);
			string DeliverId=this.txtDeliverId.Text;
			DateTime JamTime=DateTime.Parse(this.txtJamTime.Text);
			string JamLocation=this.txtJamLocation.Text;


			YueYePlat.Model.vehiclejam model=new YueYePlat.Model.vehiclejam();
			model.JamId=JamId;
			model.DeliverId=DeliverId;
			model.JamTime=JamTime;
			model.JamLocation=JamLocation;

			YueYePlat.BLL.vehiclejam bll=new YueYePlat.BLL.vehiclejam();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

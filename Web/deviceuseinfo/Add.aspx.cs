﻿using System;
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
namespace YueYePlat.Web.deviceuseinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeviceId.Text.Trim().Length==0)
			{
				strErr+="DeviceId不能为空！\\n";	
			}
			if(this.txtVehicleId.Text.Trim().Length==0)
			{
				strErr+="VehicleId不能为空！\\n";	
			}
			if(this.txtIfBind.Text.Trim().Length==0)
			{
				strErr+="IfBind不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBindTime.Text))
			{
				strErr+="BindTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUnbindTime.Text))
			{
				strErr+="UnbindTime格式错误！\\n";	
			}
			if(this.txtComment.Text.Trim().Length==0)
			{
				strErr+="Comment不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DeviceId=this.txtDeviceId.Text;
			string VehicleId=this.txtVehicleId.Text;
			string IfBind=this.txtIfBind.Text;
			DateTime BindTime=DateTime.Parse(this.txtBindTime.Text);
			DateTime UnbindTime=DateTime.Parse(this.txtUnbindTime.Text);
			string Comment=this.txtComment.Text;

			YueYePlat.Model.deviceuseinfo model=new YueYePlat.Model.deviceuseinfo();
			model.DeviceId=DeviceId;
			model.VehicleId=VehicleId;
			model.IfBind=IfBind;
			model.BindTime=BindTime;
			model.UnbindTime=UnbindTime;
			model.Comment=Comment;

			YueYePlat.BLL.deviceuseinfo bll=new YueYePlat.BLL.deviceuseinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
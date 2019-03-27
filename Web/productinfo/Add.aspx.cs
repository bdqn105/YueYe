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
namespace YueYePlat.Web.productinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtProductId.Text.Trim().Length==0)
			{
				strErr+="ProductId不能为空！\\n";	
			}
			if(this.txtProductName.Text.Trim().Length==0)
			{
				strErr+="ProductName不能为空！\\n";	
			}
			if(this.txtProductType.Text.Trim().Length==0)
			{
				strErr+="ProductType不能为空！\\n";	
			}
			if(this.txtSpecification.Text.Trim().Length==0)
			{
				strErr+="Specification不能为空！\\n";	
			}
			if(this.txtManufaturer.Text.Trim().Length==0)
			{
				strErr+="Manufaturer不能为空！\\n";	
			}
			if(this.txtBatchNum.Text.Trim().Length==0)
			{
				strErr+="BatchNum不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDataofManufaturer.Text))
			{
				strErr+="DataofManufaturer格式错误！\\n";	
			}
			if(this.txtUnitofMeasurement.Text.Trim().Length==0)
			{
				strErr+="UnitofMeasurement不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProductId=this.txtProductId.Text;
			string ProductName=this.txtProductName.Text;
			string ProductType=this.txtProductType.Text;
			string Specification=this.txtSpecification.Text;
			string Manufaturer=this.txtManufaturer.Text;
			string BatchNum=this.txtBatchNum.Text;
			DateTime DataofManufaturer=DateTime.Parse(this.txtDataofManufaturer.Text);
			string UnitofMeasurement=this.txtUnitofMeasurement.Text;

			YueYePlat.Model.productinfo model=new YueYePlat.Model.productinfo();
			model.ProductId=ProductId;
			model.ProductName=ProductName;
			model.ProductType=ProductType;
			model.Specification=Specification;
			model.Manufaturer=Manufaturer;
			model.BatchNum=BatchNum;
			model.DataofManufaturer=DataofManufaturer;
			model.UnitofMeasurement=UnitofMeasurement;

			YueYePlat.BLL.productinfo bll=new YueYePlat.BLL.productinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

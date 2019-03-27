using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisPrj
{
    public partial class FrmExceptionInfo : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        public YueYePlat.Model.exceptioninfo exception;
        List<YueYePlat.Model.exceptioninfo> exceptionList;
        public FrmExceptionInfo()
        {
            InitializeComponent();
        }

        private void FrmExceptionInfo_Load(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            InitComponent();           
            dateSendTime.Value = DateTime.Now;
            dateDisposeTime.CustomFormat = " ";
            dateDisposeTime.Checked = false;
            cbxConductor.SelectedValue = "";
            cbxSender.SelectedValue = "";
            cbxExceptionType.Text = "车辆故障";        
            if (exception != null)
            {
                dateDisposeTime.CustomFormat = " ";
                txtDeliveryId.Text = exception.DeliverId;
                cbxExceptionType.SelectedValue = int.Parse ( exception.ExceptionType);
                txtExceptiondescribe.Text = exception.Exceptiondescribe;
                txtExceptionDispose.Text = exception.ExceptionDispose;
                cbxSender.SelectedValue = exception.Sender;
                dateSendTime.Text = exception.SendTime.ToString();
                if (exception.Conductor != null && exception.Conductor != "")
                {
                    cbxConductor.SelectedValue = exception.Conductor;
                    if (exception.DisposeTime.ToString().Trim() != "" && exception.DisposeTime != null)
                    {
                        dateDisposeTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
                        dateDisposeTime.Text = exception.DisposeTime.ToString();
                    }
                }                
            }
        }

        private void InitComponent()
        {
            List<YueYePlat.Model.exceptiontype> type = new YueYePlat.BLL.exceptiontype().GetModelList("");
            cbxExceptionType.DisplayMember = "TypeName";
            cbxExceptionType.ValueMember = "TypeId";
            cbxExceptionType.DataSource = type;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.usersinfo> users = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("CompanyId='{0}' and UserTypeId='WL01'", usersInfo.CompanyId));
            cbxConductor.DisplayMember = "UserName";
            cbxConductor.ValueMember = "UserId";
            cbxConductor.DataSource = users;
            List<YueYePlat.Model.usersinfo> senders = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("CompanyId='{0}' and  (UserTypeId='WL01' or UserTypeId='DriverApp')", usersInfo.CompanyId));
            cbxSender.DisplayMember = "UserName";
            cbxSender.ValueMember = "UserId";
            cbxSender.DataSource = senders;
            //List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDeliveryId.Text.Trim() != "" && cbxExceptionType.SelectedValue != null)
            {
                if (exception != null)
                {
                    if (MessageBox.Show("您确定要修改" + txtDeliveryId.Text + "异常信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        //exception.DeliverId = cbxDeliverId.SelectedValue.ToString();
                        exception.ExceptionType = cbxExceptionType.SelectedValue.ToString();
                        exception.Exceptiondescribe = txtExceptiondescribe.Text;
                        exception.ExceptionDispose = txtExceptionDispose.Text;
                        exception.Sender = cbxSender.SelectedValue.ToString();
                        exception.SendTime = dateSendTime.Value;
                        if (cbxConductor.SelectedValue != null && cbxConductor.SelectedValue.ToString() != "")
                        {
                            exception.Conductor = cbxConductor.SelectedValue.ToString();
                            exception.DisposeTime = dateDisposeTime.Value;
                        }

                        if (new YueYePlat.BLL.exceptioninfo().Update(exception))
                        {
                            MessageBox.Show("修改成功！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("您确定要增加异常信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        YueYePlat.Model.exceptioninfo exception = new YueYePlat.Model.exceptioninfo();
                        exception.DeliverId = txtDeliveryId.Text;
                        exception.ExceptionType = cbxExceptionType.SelectedValue.ToString();
                        exception.Exceptiondescribe = txtExceptiondescribe.Text;
                        exception.ExceptionDispose = txtExceptionDispose.Text;
                        exception.Sender = cbxSender.SelectedValue.ToString();
                        exception.SendTime = dateSendTime.Value;
                        if (cbxConductor.SelectedValue != null && cbxConductor.SelectedValue.ToString() != "")
                        {
                            exception.Conductor = cbxConductor.SelectedValue.ToString();
                            exception.DisposeTime = dateDisposeTime.Value;
                        }

                        if (new YueYePlat.BLL.exceptioninfo().Add(exception))
                        {
                            MessageBox.Show("增加成功！");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                if (txtDeliveryId.Text.Trim() == "")
                {
                    MessageBox.Show("请输入车辆配送单号");
                }
                else if (cbxExceptionType.SelectedValue == null)
                {
                    MessageBox.Show("请选择异常信息类型！");
                }
            }

        }

        private void btnAddException_Click(object sender, EventArgs e)
        {
            FrmExceptionType exceptiontype = new FrmExceptionType();
            if (exceptiontype.ShowDialog() == DialogResult.OK)
            {
                List<YueYePlat.Model.exceptiontype> typeList = new YueYePlat.BLL.exceptiontype().GetModelList("");
                cbxExceptionType.DisplayMember = "TypeName";
                cbxExceptionType.ValueMember = "TypeId";
                cbxExceptionType.DataSource = typeList;
                cbxExceptionType.SelectedValue = typeList[typeList.Count-1].TypeID;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ActiveControl is TextBox || ActiveControl is ComboBox) &&
                keyData == Keys.Enter)
            {
                keyData = Keys.Tab;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void dateDisposeTime_Enter(object sender, EventArgs e)
        {
            dateDisposeTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }
}

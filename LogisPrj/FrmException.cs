using Log;
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
    public partial class FrmException : Form
    {
        List<YueYePlat.Model.logiscompanyinfo> logiscompanyList;
        YueYePlat.BLL.exceptioninfo bll;
        List<YueYePlat.Model.exceptioninfo> exceptionList;
        YueYePlat.Model.exceptioninfo exception;
        private int exceptionId = -1;       
        public YueYePlat.Model.usersinfo usersInfo;
        static FrmException  instance;
        public string tabPageTitle = "";
        public string strDeliveryId = "";
        public FrmException()
        {
            InitializeComponent();
            bll = new YueYePlat.BLL.exceptioninfo();
        }
        public static FrmException getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LogisPrj.FrmException();
            }
            return instance;
        }
        private void FrmException_Load(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                InitComponent();
                dgvException.AutoGenerateColumns = false;
                //dateSendTime.Value = DateTime.Now;
                //dateDisposeTime.CustomFormat = " ";
                //dateDisposeTime.Checked = false;
                //cbxConductor.SelectedValue = "";
                //cbxSender.SelectedValue = "";
                //cbxExceptionType.SelectedValue = "";
                if (exceptionList == null) exceptionList = new List<YueYePlat.Model.exceptioninfo>();
                if (strDeliveryId != "")
                {
                    txtDeliveryId.Text = strDeliveryId;
                    exceptionList = bll.GetModelList(String.Format("DeliverId='{0}'", txtDeliveryId.Text));
                    if (exceptionList.Count > 0)
                    {
                        for (int i = 0; i < exceptionList.Count; i++)
                        {
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            exceptionList[i].Sender = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Sender))[0].UserName;
                            if (exceptionList[i].Conductor != null && exceptionList[i].Conductor.ToString() != "")
                            {
                                exceptionList[i].Conductor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Conductor))[0].UserName;
                            }
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                            exceptionList[i].ExceptionType = new YueYePlat.BLL.exceptiontype().GetModelList(String.Format("TypeId='{0}'", exceptionList[i].ExceptionType))[0].Typename;
                        }
                        dgvException.DataSource = null;
                        dgvException.DataSource = exceptionList;
                        if (dgvException.Rows.Count > 0)
                        {
                            dgvException.Rows[0].Selected = false;
                        }
                    }
                }
                else
                {
                    exceptionList = bll.GetModelList("");
                    for (int i = 0; i < exceptionList.Count; i++)
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        try
                        {
                            exceptionList[i].Sender = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Sender))[0].UserName;
                        }
                        catch (Exception ex)
                        {

                        }
                        if (exceptionList[i].Conductor != null && exceptionList[i].Conductor.ToString() != "")
                        {
                            exceptionList[i].Conductor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Conductor))[0].UserName;
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        exceptionList[i].ExceptionType = new YueYePlat.BLL.exceptiontype().GetModelList(String.Format("TypeId='{0}'", exceptionList[i].ExceptionType))[0].Typename;
                    }
                    dgvException.DataSource = null;
                    dgvException.DataSource = exceptionList;
                    if (dgvException.Rows.Count > 0)
                    {
                        dgvException.Rows[0].Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }                
        }

        private void InitComponent()
        {
            //List<YueYePlat.Model.exceptiontype> type = new YueYePlat.BLL.exceptiontype().GetModelList("");
            //cbxExceptionType.DisplayMember = "TypeName";
            //cbxExceptionType.ValueMember = "TypeId";
            //cbxExceptionType.DataSource = type;
            //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            //List<YueYePlat.Model.usersinfo> users = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("CompanyId='{0}' and UserTypeId='WL01'", usersInfo.CompanyId));
            //cbxConductor.DisplayMember = "UserName";
            //cbxConductor.ValueMember = "UserId";
            //cbxConductor.DataSource = users;
            //List<YueYePlat.Model.usersinfo> senders = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("CompanyId='{0}' and  (UserTypeId='WL01' or UserTypeId='DriverApp')", usersInfo.CompanyId));
            //cbxSender.DisplayMember = "UserName";
            //cbxSender.ValueMember = "UserId";
            //cbxSender.DataSource = senders;
            ////List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyId='{0}'", usersInfo.CompanyId));
            //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要增加异常信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FrmExceptionInfo exception = new FrmExceptionInfo();
                exception.usersInfo = usersInfo;
                if (exception.ShowDialog() == DialogResult.OK)
                {
                    exceptionList = bll.GetModelList("");
                    for (int i = 0; i < exceptionList.Count; i++)
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        exceptionList[i].Sender = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Sender))[0].UserName;
                        if (exceptionList[i].Conductor != null && exceptionList[i].Conductor.ToString() != "")
                        {
                            exceptionList[i].Conductor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Conductor))[0].UserName;
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        exceptionList[i].ExceptionType = new YueYePlat.BLL.exceptiontype().GetModelList(String.Format("TypeId='{0}'", exceptionList[i].ExceptionType))[0].Typename;
                    }
                    dgvException.DataSource = null;
                    dgvException.DataSource = exceptionList;
                    if (dgvException.Rows.Count > 0)
                    {
                        dgvException.Rows[0].Selected = false;
                    }
                }
            }

            //if (MessageBox.Show("您确定要增加异常信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    YueYePlat.Model.exceptioninfo exception = new YueYePlat.Model.exceptioninfo();
            //    exception.DeliverId = txtDeliveryId.Text;
            //    exception.ExceptionType = cbxExceptionType.SelectedValue.ToString();
            //    exception.Exceptiondescribe = txtExceptiondescribe.Text;
            //    exception.ExceptionDispose = txtExceptionDispose.Text;
            //    exception.Sender = cbxSender.SelectedValue.ToString ();
            //    exception.SendTime = dateSendTime.Value;
            //    if (cbxConductor.SelectedValue != null && cbxConductor.SelectedValue.ToString() != "")
            //    {
            //        exception.Conductor = cbxConductor.SelectedValue.ToString();
            //    }                
            //    exception.DisposeTime = dateDisposeTime.Value;                
            //    if (new YueYePlat.BLL.exceptioninfo().Add(exception))
            //    {
            //        MessageBox.Show("增加成功！");
            //        exceptionList = bll.GetModelList("");
            //        for (int i = 0; i < exceptionList.Count; i++)
            //        {
            //            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            //            exceptionList[i].Sender = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Sender))[0].UserName;
            //            if (exceptionList[i].Conductor != null && exceptionList[i].Conductor.ToString() != "")
            //            {
            //                exceptionList[i].Conductor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Conductor))[0].UserName;
            //            }
            //            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            //            exceptionList[i].ExceptionType = new YueYePlat.BLL.exceptiontype().GetModelList(String.Format("TypeId='{0}'", exceptionList[i].ExceptionType))[0].Typename;
            //        }
            //        dgvException.DataSource = null;
            //        dgvException.DataSource = exceptionList;
            //        if (dgvException.Rows.Count > 0)
            //        {
            //            dgvException.Rows[0].Selected = false;
            //        }
            //    }
            //}
        }

        private void btnModify_Click(object sender, EventArgs e)
        {


            //if (exceptionId != -1)
            //{
            //    if (MessageBox.Show("您确定要修改"+txtDeliveryId.Text +"异常信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //    {                   
            //        //exception.DeliverId = cbxDeliverId.SelectedValue.ToString();
            //        exception.ExceptionType = cbxExceptionType.SelectedValue.ToString();
            //        exception.Exceptiondescribe = txtExceptiondescribe.Text;
            //        exception.ExceptionDispose = txtExceptionDispose.Text;
            //        exception.Sender = cbxSender.SelectedValue.ToString();
            //        exception.SendTime = dateSendTime.Value;
            //        if (cbxConductor.SelectedValue != null && cbxConductor.SelectedValue.ToString() != "")
            //        {
            //            exception.Conductor = cbxConductor.SelectedValue.ToString();
            //        }
            //        exception.DisposeTime = dateDisposeTime.Value;
            //        if (new YueYePlat.BLL.exceptioninfo().Update (exception))
            //        {
            //            MessageBox.Show("修改成功！");
            //            exceptionList = bll.GetModelList("");
            //            for (int i = 0; i < exceptionList.Count; i++)
            //            {
            //                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            //                exceptionList[i].Sender = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Sender))[0].UserName;
            //                if (exceptionList[i].Conductor != null && exceptionList[i].Conductor.ToString() != "")
            //                {
            //                    exceptionList[i].Conductor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Conductor))[0].UserName;
            //                }
            //                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            //                exceptionList[i].ExceptionType = new YueYePlat.BLL.exceptiontype().GetModelList(String.Format("TypeId='{0}'", exceptionList[i].ExceptionType))[0].Typename;
            //            }
            //            dgvException.DataSource = null;
            //            dgvException.DataSource = exceptionList;
            //            if (dgvException.Rows.Count > 0)
            //            {
            //                dgvException.Rows[0].Selected = false;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("请选择要修改的异常信息！");
            //}
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (exceptionId != -1)
            {
                if (MessageBox.Show("您确定要删除" + txtDeliveryId.Text  + "异常信息？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isSuccess = new YueYePlat.BLL.exceptioninfo().Delete(exceptionId);
                    if (isSuccess == true)
                    {
                        MessageBox.Show("删除成功！");
                        exceptionList = bll.GetModelList("");
                        for (int i = 0; i < exceptionList.Count; i++)
                        {
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            exceptionList[i].Sender = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Sender))[0].UserName;
                            if (exceptionList[i].Conductor != null && exceptionList[i].Conductor.ToString() != "")
                            {
                                exceptionList[i].Conductor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Conductor))[0].UserName;
                            }
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                            exceptionList[i].ExceptionType = new YueYePlat.BLL.exceptiontype().GetModelList(String.Format("TypeId='{0}'", exceptionList[i].ExceptionType))[0].Typename;
                        }
                        dgvException.DataSource = null;
                        dgvException.DataSource = exceptionList;
                        if (dgvException.Rows.Count > 0)
                        {
                            dgvException.Rows[0].Selected = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的异常信息！");
            }
        }

        private void dgvException_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    exceptionId = int.Parse(dgvException.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                }
                catch (Exception ex)
                {
                    exceptionId = -1;
                }
            }
            YueYePlat.Model.exceptioninfo info = exceptionList.Find(v => v.Id .Equals(exceptionId));
            exception = info;
            //if (exception != null)
            //{
            //    dateDisposeTime.CustomFormat = " ";
            //    txtDeliveryId.Text  = exception.DeliverId;
            //    cbxExceptionType.Text  = exception.ExceptionType;
            //    txtExceptiondescribe.Text = exception.Exceptiondescribe;
            //    txtExceptionDispose.Text = exception.ExceptionDispose;
            //    cbxSender .Text  = exception.Sender;
            //    dateSendTime.Text  = exception.SendTime.ToString ();
            //    cbxConductor.Text  = exception.Conductor;
            //    if (exception.DisposeTime.ToString() .Trim()!= "" && exception.DisposeTime!=null)
            //    {
            //        dateDisposeTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            //        dateDisposeTime.Text = exception.DisposeTime.ToString ();
            //    }
               
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabPageTitle = "";
            if (Parent != null)
            {
                Parent.Dispose();
            }           
            this.Close();
            this.Dispose();
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

        private void dgvException_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvException.Rows[e.RowIndex].Cells["colId"].Value.ToString();
                List<YueYePlat.Model.exceptioninfo> exceptionList = new YueYePlat.BLL.exceptioninfo().GetModelList(String.Format("ID='{0}'", str));
                YueYePlat.Model.exceptioninfo exceptionInfo = exceptionList.Find(v => v.Id.ToString().Equals(str));
                int cid = e.ColumnIndex;
                FrmExceptionInfo exception = new FrmExceptionInfo();
                exception.usersInfo = usersInfo;
                exception.exception = exceptionInfo;
                if (exception.ShowDialog() == DialogResult.OK)
                {
                    exceptionList = bll.GetModelList("");
                    for (int i = 0; i < exceptionList.Count; i++)
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                        exceptionList[i].Sender = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Sender))[0].UserName;
                        if (exceptionList[i].Conductor != null && exceptionList[i].Conductor.ToString() != "")
                        {
                            exceptionList[i].Conductor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exceptionList[i].Conductor))[0].UserName;
                        }
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                        exceptionList[i].ExceptionType = new YueYePlat.BLL.exceptiontype().GetModelList(String.Format("TypeId='{0}'", exceptionList[i].ExceptionType))[0].Typename;
                    }
                    dgvException.DataSource = null;
                    dgvException.DataSource = exceptionList;
                    if (dgvException.Rows.Count > 0)
                    {
                        dgvException.Rows[0].Selected = false;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDeliveryId.Text.Trim() != "")
                {
                    List<YueYePlat.Model.exceptioninfo> exception = new YueYePlat.BLL.exceptioninfo().GetModelList(String.Format("DeliverId='{0}'", txtDeliveryId.Text));
                    if (exception.Count == 0)
                    {
                        MessageBox.Show("该订单没有异常信息！");
                        dgvException.DataSource = null;
                    }
                    else
                    {
                        for (int i = 0; i < exception.Count; i++)
                        {
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                            exception[i].Sender = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exception[i].Sender))[0].UserName;
                            if (exception[i].Conductor != null && exception[i].Conductor.ToString() != "")
                            {
                                exception[i].Conductor = new YueYePlat.BLL.usersinfo().GetModelList(String.Format("UserId='{0}'", exception[i].Conductor))[0].UserName;
                            }
                            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
                            exception[i].ExceptionType = new YueYePlat.BLL.exceptiontype().GetModelList(String.Format("TypeId='{0}'", exception[i].ExceptionType))[0].Typename;
                        }
                        dgvException.DataSource = null;
                        dgvException.DataSource = exception;
                        if (dgvException.Rows.Count > 0)
                        {
                            dgvException.Rows[0].Selected = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请输入配送编号!");
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
        }
    }
}

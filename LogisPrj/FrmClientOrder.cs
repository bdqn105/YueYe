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
    public partial class FrmClientOrder : Form
    {
        public YueYePlat.Model.usersinfo usersInfo;
        string strId = "";
        YueYePlat.Model.clientorder clientOrder;
        public FrmClientOrder()
        {
            InitializeComponent();
        }

        private void FrmClientOrder_Load(object sender, EventArgs e)
        {

            List<YueYePlat.Model.clientinfo> clientList = new YueYePlat.BLL.clientinfo().GetModelList("");
            cbxClientId.DisplayMember = "ClientName";
            cbxClientId.ValueMember = "ClientId";
            cbxClientId.DataSource = clientList;
            cbxClientId.SelectedValue = "";
            //dgvClientOrder.AutoGenerateColumns = false;
            //List<YueYePlat.Model.clientorder> clientorderList = new YueYePlat.BLL.clientorder().GetModelList("");
            //dgvClientOrder.DataSource = null;
            //dgvClientOrder.DataSource = clientorderList;
            //if(dgvClientOrder.Rows.Count>0)
            //{
            //    dgvClientOrder.Rows[0].Selected = false;
            //}            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvClientOrder.AutoGenerateColumns = false;
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
            List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format ("CompanyId='{0}'",usersInfo .CompanyId ));
            Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyList[0].CompanyDBName);
            string strWhere = "";
            strWhere = "1=1";
            if (cbxStatus.SelectedText != null)
            {
                if (cbxStatus.SelectedText == "待处理")
                {
                    strWhere += String.Format(" and  IsDeal=false ");
                }
                else if (cbxStatus.SelectedText == "已处理")
                {
                    strWhere += String.Format(" and  IsDeal=true ");
                }
            }
            if (cbxClientId.SelectedValue != null&& cbxClientId.SelectedValue.ToString ()!="")
            {
                strWhere += String.Format(" and ClientId = '{0}'", cbxClientId.SelectedValue.ToString());
            }
            if (dTStart.Value != null)
            {
                strWhere += String.Format(" and ClientOrderId like '%{0}%'",dTStart.Value.ToString("yyMMdd"));

            }
            if (cbxClientId.SelectedValue != null || cbxStatus.Text != ""|| dTStart.Value!=null)
            {
                List<YueYePlat.Model.clientorder> clientorderList = new YueYePlat.BLL.clientorder().GetModelList(String.Format(strWhere));
                if (clientorderList.Count > 0)
                {
                    for (int i = 0; i < clientorderList.Count; i++)
                    {
                        clientorderList[i].ClientName = new YueYePlat.BLL.clientinfo().GetModelList(String.Format ("ClientId='{0}'",clientorderList[i].ClientId))[0].ClientName;
                        if (clientorderList[i].IsDeal == true) clientorderList[i].IsDealName = "已处理";
                        else clientorderList[i].IsDealName = "待处理";
                        if (clientorderList[i].IsDeliver == true) clientorderList[i].IsDeliveryName = "是";
                        else clientorderList[i].IsDeliveryName = "否";
                    }
                    dgvClientOrder.DataSource = null;
                    dgvClientOrder.DataSource = clientorderList;
                    if (dgvClientOrder.Rows.Count > 0)
                    {
                        dgvClientOrder.Rows[0].Selected = false;
                    }
                }
                else
                {
                    MessageBox.Show("没有查询到对应的信息！");
                }
            }
        }
        private void dgvClientOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = dgvClientOrder.Rows[e.RowIndex].Cells["colId"].Value.ToString();
                List<YueYePlat.Model.clientorder> clientOrderList = new YueYePlat.BLL.clientorder().GetModelList(String.Format("Id='{0}'", int.Parse(str)));
                YueYePlat.Model.clientorder clientOrderInfo = clientOrderList.Find(v => v.Id.Equals(int.Parse(str)));
                int cid = e.ColumnIndex;
                FrmClientOrderInfo info = new FrmClientOrderInfo();
                info.usersInfo = usersInfo;
                info.clientorderInfo = clientOrderInfo;
                info.ShowDialog();
            }
        }
        private void dgvClientOrder_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgvClientOrder.Columns[e.ColumnIndex].Name == "colDealName")
            {
                if (e.Value.ToString() == "待处理")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                { }
            }
        }

        private void TSMenuDeliveryOrder_Click(object sender, EventArgs e)
        {
            if (clientOrder != null)
            {
                YueYePlat.Model.deliveryorder order = new YueYePlat.Model.deliveryorder();
                order.AirWaybillID = clientOrder.AirWaybillID;
                order.SourceTransType = clientOrder.SourTransType;
                order.SourceTransId = clientOrder.SourceTransId;
                order.ClientId = clientOrder.ClientId;
                order.Destination = clientOrder.ReceiverAddress;
                order.Origin = clientOrder.ClientAddress;
                order.Receiver = clientOrder.Receiver;
                order.ReceiverPhone1 = clientOrder.ReceiverPhone;
                FrmTransferOrderInfo orderInfo = new FrmTransferOrderInfo();
                orderInfo.usersinfo = usersInfo;
                orderInfo.operate = "add";
                orderInfo.clientOrder = order;
                if (orderInfo.ShowDialog() == DialogResult.OK)
                {
                    clientOrder.IsDeal = true;
                    new YueYePlat.BLL.clientorder().Update(clientOrder);
                    List<YueYePlat.Model.clientorder> clientOrderList = new YueYePlat.BLL.clientorder().GetModelList("");
                    dgvClientOrder.DataSource = null;
                    dgvClientOrder.DataSource = clientOrderList;
                    if (dgvClientOrder.Rows.Count > 0)
                    {
                        dgvClientOrder.Rows[0].Selected = false;
                    }
                }
            }   
        }
        private void dgvClientOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvClientOrder.Rows[e.RowIndex].Selected == false)
                    {
                        dgvClientOrder.ClearSelection();
                        dgvClientOrder.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvClientOrder.SelectedRows.Count == 1)
                    {
                        //  dgvOrderList.CurrentCell = dgvOrderList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                         int Id = int.Parse (dgvClientOrder.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                        List<YueYePlat.Model.clientorder> clientorderList = new YueYePlat.BLL.clientorder().GetModelList(String.Format ("Id='{0}'",Id));
                        clientOrder = clientorderList.Find(v => v.Id.Equals(Id));
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
    }
}

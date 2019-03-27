using Log;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace LogisPrj
{
    public partial class FrmTransferOrderReport : Form
    {
        public YueYePlat.Model.logiscompanyinfo logiscompanyInfo;
        public YueYePlat.Model.usersinfo usersInfo;
        List<YueYePlat.Model.deliveryorder> orderReportList;
        List<YueYePlat.Model.productdelivery> productList;
        List<YueYePlat.Model.deliveryorderfee> orderfeeList;
        List<YueYePlat.Model.deliveryorder> orderList;
        List<YueYePlat.Model.deliveryorderfee> orderProductFeeList;
        public string strDetailFee = "";
        public string deliveryOrderId = "";
        public FrmTransferOrderReport()
        {
            InitializeComponent();
        }
        /// <summary>  
        /// 生成二维码图片  
        /// </summary>  
        /// <param name="codeNumber">要生成二维码的字符串</param>       
        /// <param name="size">大小尺寸</param>  
        /// <returns>二维码图片</returns>  
        public Bitmap Create_ImgCode(string codeNumber, int size)
        {
            //创建二维码生成类  
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            //设置编码模式  
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            //设置编码测量度  
            qrCodeEncoder.QRCodeScale = size;
            //设置编码版本  
            qrCodeEncoder.QRCodeVersion = 0;
            //设置编码错误纠正  
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //生成二维码图片  
            System.Drawing.Bitmap image = qrCodeEncoder.Encode(codeNumber);
            return image;
        }
        public string CreateImageStr(string cargoBarCode)
        {
            Bitmap QR = Create_ImgCode(cargoBarCode, 2);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            QR.Save(ms, ImageFormat.Png);
            byte[] byteImage = new Byte[ms.Length];
            byteImage = ms.ToArray();
            return Convert.ToBase64String(byteImage);
        }
        private void FrmTransferOrderReport_Load(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("yueyeplatdb");
                //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("ysdlogisplatdb");                  
                List<YueYePlat.Model.logiscompanyinfo> logiscompanyList = new YueYePlat.BLL.logiscompanyinfo().GetModelList(String.Format("CompanyID='{0}'", usersInfo.CompanyId));
                logiscompanyInfo = logiscompanyList.Find(v => v.CompanyID.Equals(usersInfo.CompanyId));
                Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                productList = new List<YueYePlat.Model.productdelivery>();
                orderfeeList = new List<YueYePlat.Model.deliveryorderfee>();
                orderProductFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                orderReportList = new List<YueYePlat.Model.deliveryorder>();
                //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("ysdlogisplatdb");
                orderList = new YueYePlat.BLL.deliveryorder().GetModelList(String.Format("DeliveryOrderId='{0}'", deliveryOrderId));
                List<YueYePlat.Model.productdelivery> productdeliveryList = new YueYePlat.BLL.productdelivery().GetModelList(String.Format("DeliveryOrderId='{0}'", deliveryOrderId));
                List<YueYePlat.Model.deliveryorderfee> deliveryOrderFeeList = new YueYePlat.BLL.deliveryorderfee().GetModelList(String.Format("DeliveryOrderId='{0}'", deliveryOrderId));
                productList.AddRange(productdeliveryList);
                decimal totalFee = 0;
                if (strDetailFee == "detailFee")
                {
                    List<YueYePlat.Model.deliveryorderfee> productFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                    for (int k = 0; k < deliveryOrderFeeList.Count; k++)
                    {
                        if (deliveryOrderFeeList[k].IsShow == true)
                        {
                            if (deliveryOrderFeeList[k].Fee != 0)
                            {
                                deliveryOrderFeeList[k].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", deliveryOrderFeeList[k].FeeTypeId))[0].FeeTypeName;
                                productFeeList.Add(deliveryOrderFeeList[k]);
                                totalFee += deliveryOrderFeeList[k].Fee;
                            }
                        }
                    }
                    orderList[0].TotalFee = orderList[0].Receivable + totalFee;
                    orderProductFeeList.AddRange(productFeeList);
                }
                else if (strDetailFee == "nodetailFee")
                {
                    for (int k = 0; k < orderList.Count; k++)
                    {
                        orderList[k].TotalFee = orderList[k].Receivable;
                    }
                    List<YueYePlat.Model.deliveryorderfee> productFeeList = new List<YueYePlat.Model.deliveryorderfee>();
                    orderProductFeeList.AddRange(productFeeList);
                }
                orderList[0].StrCarCodeImage = CreateImageStr(orderList[0].DeliveryOrderId);
                if (orderList[0].ReceiverPhone2.ToString().Trim() != "")
                {
                    orderList[0].ReceiverPhone1 = orderList[0].ReceiverPhone1 + ";" + orderList[0].ReceiverPhone2;
                }
                if (orderList[0].ReceiverPhone3.ToString().Trim() != "")
                {
                    orderList[0].ReceiverPhone1 = orderList[0].ReceiverPhone1 + ";" + orderList[0].ReceiverPhone3;
                }
                if (orderList[0].SourceTransType == "汽运" || orderList[0].SourceTransType == "铁运")
                {
                    orderList[0].SourceTransId = orderList[0].SourceTransType;
                }
                orderReportList.AddRange(orderList);
                for (int j = 0; j < orderReportList.Count; j++)
                {
                    //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("ysdlogisplatdb");
                    List<YueYePlat.Model.clientinfo> clientInfo = new YueYePlat.BLL.clientinfo().GetModelList(String.Format("ClientId='{0}'", orderReportList[j].ClientId));
                    orderReportList[j].ClientName = new YueYePlat.BLL.companyinfo().GetModelList(String.Format("CompanyID='{0}'", clientInfo[0].CompanyId))[0].CompanyName;
                }
                for (int i = 0; i < productList.Count; i++)
                {
                    try
                    {
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("YueYeplatdb");
                        productList[i].ProductName = new YueYePlat.BLL.productinfo().GetModelList(String.Format("ProductId='{0}'", productList[i].ProductId))[0].ProductName;
                        //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString("ysdlogisplatdb"); 
                        Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                        if (productList[i].Feetype != null && productList[i].Feetype.ToString() != "")
                        {
                            productList[i].FeetypeName = new YueYePlat.BLL.feetype().GetModelList(String.Format("Id='{0}'", productList[i].Feetype))[0].FeeTypeName;
                        }
                    }
                    catch (Exception ex)
                    {
                        LogHelper.WriteLog(ex);
                    }
                }
                this.rpViewOrder.LocalReport.DataSources.Clear();
                //Maticsoft.DBUtility.DbHelperMySQL.UpdateConnectionString(logiscompanyInfo.CompanyDBName);
                this.rpViewOrder.LocalReport.DataSources.Add(new ReportDataSource("myOrderList", orderList));
                this.rpViewOrder.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubReportProcessingEventHandler);
                //PageSettings pages = new System.Drawing.Printing.PageSettings();
                //pages.Landscape = false;//强制设置纵向打印      
                //rpViewOrder.SetPageSettings(pages);
                this.rpViewOrder.RefreshReport();
                this.rpViewOrder.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                //缩放模式为百分比,以100%方式显示
                this.rpViewOrder.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                this.rpViewOrder.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
        }
        private void SubReportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("myProductList", productList));
            //     e.DataSources.Add(new ReportDataSource("myDeliveryOrderFeeList", orderfeeList));
            this.rpViewOrder.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(FeeSubReportProcessingEventHandler);
        }

        private void FeeSubReportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("myOrderFeeList", orderProductFeeList));
        }
        private void FrmTransferOrderReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void FrmTransferOrderReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void rpViewOrder_Print(object sender, ReportPrintEventArgs e)
        {
            
            
        }

        private void rpViewOrder_Load(object sender, EventArgs e)
        {

        }
    }
}

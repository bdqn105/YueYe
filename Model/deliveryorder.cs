using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// deliveryorder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class deliveryorder
	{
		public deliveryorder()
		{}
		#region Model
		private int _id;
		private string _deliveryorderid;
		private string _deliveryid;
		private string _sourcetranstype;
		private string _sourcetransid;
		private string _airwaybillid;
		private string _origin;
		private DateTime? _begintime;
		private string _destination;
		private double? _longitude;
		private double? _latitude;
		private DateTime? _predictdeliverytime;
		private DateTime? _deliverytime;
		private string _clientid;
		private DateTime? _arrivetime;
		private string _receiver;
		private string _receiverphone1;
		private string _receiverphone2;
		private string _receiverphone3;
		private bool _iftransfer;
		private string _transfername;
		private decimal? _transferfee;
		private string _signer;
		private string _signercardid;
		private string _telephone;
		private bool _isbackfee;
		private decimal? _receivable;
		private decimal? _amount;
		private bool _isdeliver;
		private decimal? _totalfee;
		private string _returnordersrc;
		private string _clientreturnordersrc;
		private string _terminator;
		private bool _isend;
		private string _paymentmethod;
		private string _auditor;
		private bool _ischecked;
		private string _logiscompanyshortname;
		private string _logiscompanyid;
		private string _remark;
		private string _recorderid;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeliveryOrderId
		{
			set{ _deliveryorderid=value;}
			get{return _deliveryorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeliveryId
		{
			set{ _deliveryid=value;}
			get{return _deliveryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SourceTransType
		{
			set{ _sourcetranstype=value;}
			get{return _sourcetranstype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SourceTransId
		{
			set{ _sourcetransid=value;}
			get{return _sourcetransid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AirWaybillID
		{
			set{ _airwaybillid=value;}
			get{return _airwaybillid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Origin
		{
			set{ _origin=value;}
			get{return _origin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Destination
		{
			set{ _destination=value;}
			get{return _destination;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Longitude
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Latitude
		{
			set{ _latitude=value;}
			get{return _latitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PredictDeliveryTime
		{
			set{ _predictdeliverytime=value;}
			get{return _predictdeliverytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DeliveryTime
		{
			set{ _deliverytime=value;}
			get{return _deliverytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientId
		{
			set{ _clientid=value;}
			get{return _clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ArriveTime
		{
			set{ _arrivetime=value;}
			get{return _arrivetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Receiver
		{
			set{ _receiver=value;}
			get{return _receiver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiverPhone1
		{
			set{ _receiverphone1=value;}
			get{return _receiverphone1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiverPhone2
		{
			set{ _receiverphone2=value;}
			get{return _receiverphone2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiverPhone3
		{
			set{ _receiverphone3=value;}
			get{return _receiverphone3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IfTransfer
		{
			set{ _iftransfer=value;}
			get{return _iftransfer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TransferName
		{
			set{ _transfername=value;}
			get{return _transfername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TransferFee
		{
			set{ _transferfee=value;}
			get{return _transferfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Signer
		{
			set{ _signer=value;}
			get{return _signer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SignerCardID
		{
			set{ _signercardid=value;}
			get{return _signercardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsBackFee
		{
			set{ _isbackfee=value;}
			get{return _isbackfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Receivable
		{
			set{ _receivable=value;}
			get{return _receivable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsDeliver
		{
			set{ _isdeliver=value;}
			get{return _isdeliver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalFee
		{
			set{ _totalfee=value;}
			get{return _totalfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReturnOrderSrc
		{
			set{ _returnordersrc=value;}
			get{return _returnordersrc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientReturnOrderSrc
		{
			set{ _clientreturnordersrc=value;}
			get{return _clientreturnordersrc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Terminator
		{
			set{ _terminator=value;}
			get{return _terminator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsEnd
		{
			set{ _isend=value;}
			get{return _isend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PaymentMethod
		{
			set{ _paymentmethod=value;}
			get{return _paymentmethod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Auditor
		{
			set{ _auditor=value;}
			get{return _auditor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsChecked
		{
			set{ _ischecked=value;}
			get{return _ischecked;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogisCompanyShortName
		{
			set{ _logiscompanyshortname=value;}
			get{return _logiscompanyshortname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogisCompanyID
		{
			set{ _logiscompanyid=value;}
			get{return _logiscompanyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecorderID
		{
			set{ _recorderid=value;}
			get{return _recorderid;}
		}
		#endregion Model

	}
}


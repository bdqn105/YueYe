using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// clientorder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class clientorder
	{
		public clientorder()
		{}
		#region Model
		private int _id;
		private string _clientorderid;
		private string _listnumber;
		private string _airwaybillid;
		private string _sourtranstype;
		private string _sourcetransid;
		private DateTime? _airarrivertime;
		private string _clientid;
		private string _clientphone;
		private string _clientaddress;
		private string _receiver;
		private string _receiverphone;
		private string _receiveraddress;
		private string _productid;
		private int? _quantity;
		private decimal? _weight;
		private bool _isdeliver;
		private bool _isdeal;
		private string _remark;
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
		public string ClientOrderId
		{
			set{ _clientorderid=value;}
			get{return _clientorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Listnumber
		{
			set{ _listnumber=value;}
			get{return _listnumber;}
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
		public string SourTransType
		{
			set{ _sourtranstype=value;}
			get{return _sourtranstype;}
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
		public DateTime? AirArriverTime
		{
			set{ _airarrivertime=value;}
			get{return _airarrivertime;}
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
		public string ClientPhone
		{
			set{ _clientphone=value;}
			get{return _clientphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientAddress
		{
			set{ _clientaddress=value;}
			get{return _clientaddress;}
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
		public string ReceiverPhone
		{
			set{ _receiverphone=value;}
			get{return _receiverphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiverAddress
		{
			set{ _receiveraddress=value;}
			get{return _receiveraddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductId
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Weight
		{
			set{ _weight=value;}
			get{return _weight;}
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
		public bool IsDeal
		{
			set{ _isdeal=value;}
			get{return _isdeal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}


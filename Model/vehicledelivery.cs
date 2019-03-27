using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// vehicledelivery:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vehicledelivery
	{
		public vehicledelivery()
		{}
		#region Model
		private int _id;
		private string _deliveryid;
		private string _deviceid;
		private string _vehicleid;
		private string _driver1id;
		private string _driver2id;
		private string _origin;
		private DateTime? _begintime;
		private double? _mintempthreshold;
		private double? _maxtempthreshold;
		private double? _minhumthreshold;
		private double? _maxhumthreshold;
		private bool _ifend;
		private string _recordid;
		private string _auditor;
		private bool _ifchargeback;
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
		public string DeliveryId
		{
			set{ _deliveryid=value;}
			get{return _deliveryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeviceId
		{
			set{ _deviceid=value;}
			get{return _deviceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VehicleId
		{
			set{ _vehicleid=value;}
			get{return _vehicleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Driver1Id
		{
			set{ _driver1id=value;}
			get{return _driver1id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Driver2Id
		{
			set{ _driver2id=value;}
			get{return _driver2id;}
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
		public double? MinTempThreshold
		{
			set{ _mintempthreshold=value;}
			get{return _mintempthreshold;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? MaxTempThreshold
		{
			set{ _maxtempthreshold=value;}
			get{return _maxtempthreshold;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? MinHumThreshold
		{
			set{ _minhumthreshold=value;}
			get{return _minhumthreshold;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? MaxHumThreshold
		{
			set{ _maxhumthreshold=value;}
			get{return _maxhumthreshold;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IfEnd
		{
			set{ _ifend=value;}
			get{return _ifend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecordId
		{
			set{ _recordid=value;}
			get{return _recordid;}
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
		public bool IfChargeback
		{
			set{ _ifchargeback=value;}
			get{return _ifchargeback;}
		}
		#endregion Model

	}
}


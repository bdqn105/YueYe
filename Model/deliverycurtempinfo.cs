using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// deliverycurtempinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class deliverycurtempinfo
	{
		public deliverycurtempinfo()
		{}
		#region Model
		private long _id;
		private string _deliveryid;
		private double? _temperature1;
		private double? _humidity1;
		private double? _temperature2;
		private double? _humidity2;
		private double? _temperature3;
		private double? _humidity3;
		private DateTime? _currenttime;
		/// <summary>
		/// auto_increment
		/// </summary>
		public long Id
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
		public double? Temperature1
		{
			set{ _temperature1=value;}
			get{return _temperature1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Humidity1
		{
			set{ _humidity1=value;}
			get{return _humidity1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Temperature2
		{
			set{ _temperature2=value;}
			get{return _temperature2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Humidity2
		{
			set{ _humidity2=value;}
			get{return _humidity2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Temperature3
		{
			set{ _temperature3=value;}
			get{return _temperature3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Humidity3
		{
			set{ _humidity3=value;}
			get{return _humidity3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CurrentTime
		{
			set{ _currenttime=value;}
			get{return _currenttime;}
		}
		#endregion Model

	}
}


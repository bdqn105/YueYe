using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// deliverycurgyroinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class deliverycurgyroinfo
	{
		public deliverycurgyroinfo()
		{}
		#region Model
		private long _id;
		private string _deliveryid;
		private decimal? _xaccelerated;
		private decimal? _yaccelerated;
		private decimal? _zaccelerated;
		private decimal? _xangular;
		private decimal? _yangular;
		private decimal? _zangular;
		private decimal? _longitude;
		private decimal? _latitude;
		private decimal? _speed;
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
		public decimal? Xaccelerated
		{
			set{ _xaccelerated=value;}
			get{return _xaccelerated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Yaccelerated
		{
			set{ _yaccelerated=value;}
			get{return _yaccelerated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Zaccelerated
		{
			set{ _zaccelerated=value;}
			get{return _zaccelerated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Xangular
		{
			set{ _xangular=value;}
			get{return _xangular;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Yangular
		{
			set{ _yangular=value;}
			get{return _yangular;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Zangular
		{
			set{ _zangular=value;}
			get{return _zangular;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Longitude
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Latitude
		{
			set{ _latitude=value;}
			get{return _latitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Speed
		{
			set{ _speed=value;}
			get{return _speed;}
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


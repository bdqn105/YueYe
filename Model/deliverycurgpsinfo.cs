using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// deliverycurgpsinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class deliverycurgpsinfo
	{
		public deliverycurgpsinfo()
		{}
		#region Model
		private long _id;
		private string _deliveryid;
		private decimal? _longitude;
		private decimal? _latitude;
		private decimal? _speed;
		private decimal? _direction;
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
		public decimal? Direction
		{
			set{ _direction=value;}
			get{return _direction;}
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


using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// deliverycurhumiinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class deliverycurhumiinfo
	{
		public deliverycurhumiinfo()
		{}
		#region Model
		private long _id;
		private string _deliveryid;
		private double? _humidity1;
		private double? _humidity2;
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
		public double? Humidity1
		{
			set{ _humidity1=value;}
			get{return _humidity1;}
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


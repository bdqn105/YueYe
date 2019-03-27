using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// regionalparkmanage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class regionalparkmanage
	{
		public regionalparkmanage()
		{}
		#region Model
		private int _id;
		private string _deliveryid;
		private double? _longitude;
		private double? _latitude;
		private DateTime? _parkingtime;
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
		public DateTime? ParkingTime
		{
			set{ _parkingtime=value;}
			get{return _parkingtime;}
		}
		#endregion Model

	}
}


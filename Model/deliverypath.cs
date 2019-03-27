using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// deliverypath:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class deliverypath
	{
		public deliverypath()
		{}
		#region Model
		private int _id;
		private string _deliverid;
		private int? _ordernumber;
		private double? _longitude;
		private double? _latitude;
		private double? _limitspeed;
		private string _locationname;
		private string _locationsign;
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
		public string DeliverId
		{
			set{ _deliverid=value;}
			get{return _deliverid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderNumber
		{
			set{ _ordernumber=value;}
			get{return _ordernumber;}
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
		public double? LimitSpeed
		{
			set{ _limitspeed=value;}
			get{return _limitspeed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LocationName
		{
			set{ _locationname=value;}
			get{return _locationname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LocationSign
		{
			set{ _locationsign=value;}
			get{return _locationsign;}
		}
		#endregion Model

	}
}


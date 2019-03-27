using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// incubator:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class incubator
	{
		public incubator()
		{}
		#region Model
		private int _id;
		private string _incubatorid;
		private string _deliveryid;
		private double? _longitude;
		private double? _latitude;
		private double? _temperture;
		private double? _humidity;
		private DateTime? _time;
		private string _productid;
		private int? _quantity;
		private string _unit;
		private string _destination;
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
		public string IncubatorID
		{
			set{ _incubatorid=value;}
			get{return _incubatorid;}
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
		public double? Temperture
		{
			set{ _temperture=value;}
			get{return _temperture;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Humidity
		{
			set{ _humidity=value;}
			get{return _humidity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
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
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Destination
		{
			set{ _destination=value;}
			get{return _destination;}
		}
		#endregion Model

	}
}


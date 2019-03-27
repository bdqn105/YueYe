using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// refueling:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class refueling
	{
		public refueling()
		{}
		#region Model
		private int _id;
		private string _vehicleid;
		private string _deliveryid;
		private double? _longitude;
		private double? _latitude;
		private string _petrolstation;
		private decimal? _money;
		private decimal? _quantity;
		private DateTime? _refueltime;
		private string _invoicephoto;
		private string _driverid;
		private bool _ifverifyed;
		private string _verfielid;
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
		public string VehicleID
		{
			set{ _vehicleid=value;}
			get{return _vehicleid;}
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
		public string PetrolStation
		{
			set{ _petrolstation=value;}
			get{return _petrolstation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RefuelTime
		{
			set{ _refueltime=value;}
			get{return _refueltime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvoicePhoto
		{
			set{ _invoicephoto=value;}
			get{return _invoicephoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DriverId
		{
			set{ _driverid=value;}
			get{return _driverid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IfVerifyed
		{
			set{ _ifverifyed=value;}
			get{return _ifverifyed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VerfielId
		{
			set{ _verfielid=value;}
			get{return _verfielid;}
		}
		#endregion Model

	}
}


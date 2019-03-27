using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// roadtoll:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class roadtoll
	{
		public roadtoll()
		{}
		#region Model
		private int _id;
		private string _deliveryid;
		private int? _ordernumber;
		private string _tollstation;
		private double? _money;
		private DateTime? _tolltime;
		private string _invoicephoto;
		private string _driverid;
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
		public int? OrderNumber
		{
			set{ _ordernumber=value;}
			get{return _ordernumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TollStation
		{
			set{ _tollstation=value;}
			get{return _tollstation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TollTime
		{
			set{ _tolltime=value;}
			get{return _tolltime;}
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
		#endregion Model

	}
}


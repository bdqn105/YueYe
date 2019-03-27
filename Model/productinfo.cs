using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// productinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class productinfo
	{
		public productinfo()
		{}
		#region Model
		private int _id;
		private string _productid;
		private string _productname;
		private string _producttype;
		private string _specification;
		private string _manufaturer;
		private string _batchnum;
		private DateTime? _dataofmanufaturer;
		private string _unitofmeasurement;
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
		public string ProductId
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductType
		{
			set{ _producttype=value;}
			get{return _producttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Specification
		{
			set{ _specification=value;}
			get{return _specification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Manufaturer
		{
			set{ _manufaturer=value;}
			get{return _manufaturer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BatchNum
		{
			set{ _batchnum=value;}
			get{return _batchnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DataofManufaturer
		{
			set{ _dataofmanufaturer=value;}
			get{return _dataofmanufaturer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnitofMeasurement
		{
			set{ _unitofmeasurement=value;}
			get{return _unitofmeasurement;}
		}
		#endregion Model

	}
}


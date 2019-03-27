using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// vehicleinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vehicleinfo
	{
		public vehicleinfo()
		{}
		#region Model
		private int _id;
		private string _vehicleid;
		private string _vehiclename;
		private string _vehiclenumber;
		private string _companyid;
		private string _vehicletype;
		private string _loadcapacity;
		private string _licensephoto;
		private string _vehiclephoto;
		private bool _ifbelongsto;
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
		public string VehicleId
		{
			set{ _vehicleid=value;}
			get{return _vehicleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VehicleName
		{
			set{ _vehiclename=value;}
			get{return _vehiclename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VehicleNumber
		{
			set{ _vehiclenumber=value;}
			get{return _vehiclenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyId
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VehicleType
		{
			set{ _vehicletype=value;}
			get{return _vehicletype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoadCapacity
		{
			set{ _loadcapacity=value;}
			get{return _loadcapacity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LicensePhoto
		{
			set{ _licensephoto=value;}
			get{return _licensephoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VehiclePhoto
		{
			set{ _vehiclephoto=value;}
			get{return _vehiclephoto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IFBelongsto
		{
			set{ _ifbelongsto=value;}
			get{return _ifbelongsto;}
		}
		#endregion Model

	}
}


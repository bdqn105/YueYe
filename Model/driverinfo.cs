using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// driverinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class driverinfo
	{
		public driverinfo()
		{}
		#region Model
		private int _id;
		private string _driverid;
		private string _drivername;
		private string _driversex;
		private string _familyaddress;
		private string _mobile;
		private string _idnumber;
		private string _driverlicense;
		private string _licensetype;
		private string _driverlocation;
		private string _emergencycontact;
		private string _emergencymobile;
		private string _emergencyrelations;
		private string _driverphoto;
		private string _companyid;
		private string _type;
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
		public string DriverId
		{
			set{ _driverid=value;}
			get{return _driverid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DriverName
		{
			set{ _drivername=value;}
			get{return _drivername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DriverSex
		{
			set{ _driversex=value;}
			get{return _driversex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FamilyAddress
		{
			set{ _familyaddress=value;}
			get{return _familyaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IdNumber
		{
			set{ _idnumber=value;}
			get{return _idnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DriverLicense
		{
			set{ _driverlicense=value;}
			get{return _driverlicense;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LicenseType
		{
			set{ _licensetype=value;}
			get{return _licensetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DriverLocation
		{
			set{ _driverlocation=value;}
			get{return _driverlocation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmergencyContact
		{
			set{ _emergencycontact=value;}
			get{return _emergencycontact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmergencyMobile
		{
			set{ _emergencymobile=value;}
			get{return _emergencymobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmergencyRelations
		{
			set{ _emergencyrelations=value;}
			get{return _emergencyrelations;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DriverPhoto
		{
			set{ _driverphoto=value;}
			get{return _driverphoto;}
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
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}


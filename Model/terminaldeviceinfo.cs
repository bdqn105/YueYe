using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// terminaldeviceinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class terminaldeviceinfo
	{
		public terminaldeviceinfo()
		{}
		#region Model
		private int _id;
		private string _deviceid;
		private string _devicetype;
		private string _devicename;
		private string _companyid;
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
		public string DeviceId
		{
			set{ _deviceid=value;}
			get{return _deviceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeviceType
		{
			set{ _devicetype=value;}
			get{return _devicetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeviceName
		{
			set{ _devicename=value;}
			get{return _devicename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyId
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		#endregion Model

	}
}


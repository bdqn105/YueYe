using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// tempvehicleinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tempvehicleinfo
	{
		public tempvehicleinfo()
		{}
		#region Model
		private int _id;
		private string _vehicleid;
		private string _driverid;
		private DateTime? _time;
		private string _coments;
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
		public string DriverId
		{
			set{ _driverid=value;}
			get{return _driverid;}
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
		public string Coments
		{
			set{ _coments=value;}
			get{return _coments;}
		}
		#endregion Model

	}
}


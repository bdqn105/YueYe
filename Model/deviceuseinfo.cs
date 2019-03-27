using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// deviceuseinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class deviceuseinfo
	{
		public deviceuseinfo()
		{}
		#region Model
		private int _id;
		private string _deviceid;
		private string _vehicleid;
		private bool _ifbind;
		private DateTime? _bindtime;
		private DateTime? _unbindtime;
		private string _comment;
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
		public string VehicleId
		{
			set{ _vehicleid=value;}
			get{return _vehicleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IfBind
		{
			set{ _ifbind=value;}
			get{return _ifbind;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BindTime
		{
			set{ _bindtime=value;}
			get{return _bindtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UnbindTime
		{
			set{ _unbindtime=value;}
			get{return _unbindtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Comment
		{
			set{ _comment=value;}
			get{return _comment;}
		}
		#endregion Model

	}
}


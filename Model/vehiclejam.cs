using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// vehiclejam:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vehiclejam
	{
		public vehiclejam()
		{}
		#region Model
		private long _jamid;
		private string _deliverid;
		private DateTime? _jamtime;
		private string _jamlocation;
		private double? _longitude;
		private double? _latitude;
		private string _jamurl;
		/// <summary>
		/// auto_increment
		/// </summary>
		public long JamId
		{
			set{ _jamid=value;}
			get{return _jamid;}
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
		public DateTime? JamTime
		{
			set{ _jamtime=value;}
			get{return _jamtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JamLocation
		{
			set{ _jamlocation=value;}
			get{return _jamlocation;}
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
		public string JamUrl
		{
			set{ _jamurl=value;}
			get{return _jamurl;}
		}
		#endregion Model

	}
}


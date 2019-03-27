using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// vehicledoors:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vehicledoors
	{
		public vehicledoors()
		{}
		#region Model
		private int _id;
		private string _deliveryid;
		private double? _longitude;
		private double? _latitude;
		private bool _openclose;
		private DateTime? _doortime;
		private string _doorphoto;
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
		public bool OpenClose
		{
			set{ _openclose=value;}
			get{return _openclose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DoorTime
		{
			set{ _doortime=value;}
			get{return _doortime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DoorPhoto
		{
			set{ _doorphoto=value;}
			get{return _doorphoto;}
		}
		#endregion Model

	}
}


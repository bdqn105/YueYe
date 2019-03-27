using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// vehiclepointoff:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vehiclepointoff
	{
		public vehiclepointoff()
		{}
		#region Model
		private int _id;
		private string _deliveryid;
		private double? _longitude;
		private double? _latitude;
		private bool _pointoff;
		private DateTime? _pointofftime;
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
		public bool PointOff
		{
			set{ _pointoff=value;}
			get{return _pointoff;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PointOffTime
		{
			set{ _pointofftime=value;}
			get{return _pointofftime;}
		}
		#endregion Model

	}
}


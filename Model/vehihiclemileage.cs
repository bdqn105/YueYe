using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// vehihiclemileage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vehihiclemileage
	{
		public vehihiclemileage()
		{}
		#region Model
		private int _mileageid;
		private string _vehicleid;
		private double _dailymileage;
		private double _toalmileage;
		private DateTime _curdate;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int MileageID
		{
			set{ _mileageid=value;}
			get{return _mileageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VehicleID
		{
			set{ _vehicleid=value;}
			get{return _vehicleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double DailyMileage
		{
			set{ _dailymileage=value;}
			get{return _dailymileage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double ToalMileage
		{
			set{ _toalmileage=value;}
			get{return _toalmileage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime curDate
		{
			set{ _curdate=value;}
			get{return _curdate;}
		}
		#endregion Model

	}
}


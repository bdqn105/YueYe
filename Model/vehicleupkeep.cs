using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// vehicleupkeep:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vehicleupkeep
	{
		public vehicleupkeep()
		{}
		#region Model
		private int _id;
		private string _vehicleid;
		private string _kilometres;
		private string _upkeepdescribe;
		private string _upkeepmoneys;
		private DateTime? _upkeeptime;
		private string _upkeepman;
		private string _upkeeplocation;
		private string _invoicephoto;
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
		public string Kilometres
		{
			set{ _kilometres=value;}
			get{return _kilometres;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpkeepDescribe
		{
			set{ _upkeepdescribe=value;}
			get{return _upkeepdescribe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpkeepMoneys
		{
			set{ _upkeepmoneys=value;}
			get{return _upkeepmoneys;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpkeepTime
		{
			set{ _upkeeptime=value;}
			get{return _upkeeptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpkeepMan
		{
			set{ _upkeepman=value;}
			get{return _upkeepman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpkeepLocation
		{
			set{ _upkeeplocation=value;}
			get{return _upkeeplocation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvoicePhoto
		{
			set{ _invoicephoto=value;}
			get{return _invoicephoto;}
		}
		#endregion Model

	}
}


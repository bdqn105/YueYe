using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// vehicletype:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vehicletype
	{
		public vehicletype()
		{}
		#region Model
		private int _id;
		private string _vehicletypeid;
		private string _vehicletypename;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VehicleTypeID
		{
			set{ _vehicletypeid=value;}
			get{return _vehicletypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VehicleTypeName
		{
			set{ _vehicletypename=value;}
			get{return _vehicletypename;}
		}
		#endregion Model

	}
}


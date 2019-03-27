using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// printinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class printinfo
	{
		public printinfo()
		{}
		#region Model
		private int _id;
		private string _deliveryid;
		private DateTime? _datastarttime;
		private DateTime? _datatendtime;
		private DateTime? _printtime;
		private string _printerid;
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
		public DateTime? DataStartTime
		{
			set{ _datastarttime=value;}
			get{return _datastarttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DatatEndTime
		{
			set{ _datatendtime=value;}
			get{return _datatendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PrintTime
		{
			set{ _printtime=value;}
			get{return _printtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PrinterId
		{
			set{ _printerid=value;}
			get{return _printerid;}
		}
		#endregion Model

	}
}


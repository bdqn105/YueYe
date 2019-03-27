using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// clientreturnorder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class clientreturnorder
	{
		public clientreturnorder()
		{}
		#region Model
		private int _id;
		private string _deliveryorderid;
		private string _returnorderurl;
		private DateTime? _uploadtime;
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
		public string DeliveryOrderId
		{
			set{ _deliveryorderid=value;}
			get{return _deliveryorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReturnOrderUrl
		{
			set{ _returnorderurl=value;}
			get{return _returnorderurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpLoadTime
		{
			set{ _uploadtime=value;}
			get{return _uploadtime;}
		}
		#endregion Model

	}
}


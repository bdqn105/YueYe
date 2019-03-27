using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// logistouser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class logistouser
	{
		public logistouser()
		{}
		#region Model
		private int _id;
		private string _logiscompanyid;
		private string _userid;
		private DateTime _curdate;
		private int? _ordercount;
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
		public string LogisCompanyID
		{
			set{ _logiscompanyid=value;}
			get{return _logiscompanyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CurDate
		{
			set{ _curdate=value;}
			get{return _curdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderCount
		{
			set{ _ordercount=value;}
			get{return _ordercount;}
		}
		#endregion Model

	}
}


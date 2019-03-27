using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// feetype:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class feetype
	{
		public feetype()
		{}
		#region Model
		private long _id;
		private string _feetypename;
		private bool _isdetail;
		private decimal? _defaultfee;
		private bool _isdetailcount;
		/// <summary>
		/// auto_increment
		/// </summary>
		public long Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FeeTypeName
		{
			set{ _feetypename=value;}
			get{return _feetypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isDetail
		{
			set{ _isdetail=value;}
			get{return _isdetail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DefaultFee
		{
			set{ _defaultfee=value;}
			get{return _defaultfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isDetailCount
		{
			set{ _isdetailcount=value;}
			get{return _isdetailcount;}
		}
		#endregion Model

	}
}


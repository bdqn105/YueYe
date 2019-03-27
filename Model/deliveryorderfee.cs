using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// deliveryorderfee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class deliveryorderfee
	{
		public deliveryorderfee()
		{}
		#region Model
		private long _id;
		private string _deliveryorderid;
		private string _deliveryorderdetailid;
		private int _feetypeid;
		private decimal _fee;
		private bool _isshow;
		private string _remark;
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
		public string DeliveryOrderId
		{
			set{ _deliveryorderid=value;}
			get{return _deliveryorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeliveryOrderDetailID
		{
			set{ _deliveryorderdetailid=value;}
			get{return _deliveryorderdetailid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FeeTypeId
		{
			set{ _feetypeid=value;}
			get{return _feetypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Fee
		{
			set{ _fee=value;}
			get{return _fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}


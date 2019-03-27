using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// productdelivery:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class productdelivery
	{
		public productdelivery()
		{}
		#region Model
		private int _id;
		private string _orderdetailid;
		private string _deliveryorderid;
		private string _invoiceid;
		private string _productid;
		private int? _quantity;
		private double? _weight;
		private string _volumedescription;
		private string _remark;
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
		public string OrderDetailId
		{
			set{ _orderdetailid=value;}
			get{return _orderdetailid;}
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
		public string InvoiceID
		{
			set{ _invoiceid=value;}
			get{return _invoiceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductId
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Weight
		{
			set{ _weight=value;}
			get{return _weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VolumeDescription
		{
			set{ _volumedescription=value;}
			get{return _volumedescription;}
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


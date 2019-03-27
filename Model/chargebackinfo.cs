using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// chargebackinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class chargebackinfo
	{
		public chargebackinfo()
		{}
		#region Model
		private int _id;
		private string _deliveryid;
		private string _deliveryorderid;
		private string _chargebackdispose;
		private string _chargebackid;
		private DateTime? _chargebacktime;
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
		public string DeliveryOrderId
		{
			set{ _deliveryorderid=value;}
			get{return _deliveryorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChargeBackDispose
		{
			set{ _chargebackdispose=value;}
			get{return _chargebackdispose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChargeBackId
		{
			set{ _chargebackid=value;}
			get{return _chargebackid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ChargeBackTime
		{
			set{ _chargebacktime=value;}
			get{return _chargebacktime;}
		}
		#endregion Model

	}
}


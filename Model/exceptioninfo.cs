using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// exceptioninfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class exceptioninfo
	{
		public exceptioninfo()
		{}
		#region Model
		private int _id;
		private string _deliverid;
		private string _exceptiontype;
		private string _exceptiondescribe;
		private string _exceptiondispose;
		private string _sender;
		private DateTime? _sendtime;
		private string _conductor;
		private DateTime? _disposetime;
		private double? _longitude;
		private double? _latitude;
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
		public string DeliverId
		{
			set{ _deliverid=value;}
			get{return _deliverid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExceptionType
		{
			set{ _exceptiontype=value;}
			get{return _exceptiontype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Exceptiondescribe
		{
			set{ _exceptiondescribe=value;}
			get{return _exceptiondescribe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExceptionDispose
		{
			set{ _exceptiondispose=value;}
			get{return _exceptiondispose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sender
		{
			set{ _sender=value;}
			get{return _sender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Conductor
		{
			set{ _conductor=value;}
			get{return _conductor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DisposeTime
		{
			set{ _disposetime=value;}
			get{return _disposetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Longitude
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Latitude
		{
			set{ _latitude=value;}
			get{return _latitude;}
		}
		#endregion Model

	}
}


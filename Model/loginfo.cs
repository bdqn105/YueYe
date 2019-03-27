using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// loginfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class loginfo
	{
		public loginfo()
		{}
		#region Model
		private long _id;
		private string _topic;
		private string _message;
		private DateTime? _extimer;
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
		public string Topic
		{
			set{ _topic=value;}
			get{return _topic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Message
		{
			set{ _message=value;}
			get{return _message;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ExTimer
		{
			set{ _extimer=value;}
			get{return _extimer;}
		}
		#endregion Model

	}
}


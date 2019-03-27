using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// sessions:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sessions
	{
		public sessions()
		{}
		#region Model
		private string _sessionid;
		private string _applicationname;
		private DateTime _created;
		private DateTime _expires;
		private DateTime _lockdate;
		private int _lockid;
		private int _timeout;
		private int _locked;
		private string _sessionitems;
		private int _flags;
		/// <summary>
		/// 
		/// </summary>
		public string SessionId
		{
			set{ _sessionid=value;}
			get{return _sessionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ApplicationName
		{
			set{ _applicationname=value;}
			get{return _applicationname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Created
		{
			set{ _created=value;}
			get{return _created;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Expires
		{
			set{ _expires=value;}
			get{return _expires;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LockDate
		{
			set{ _lockdate=value;}
			get{return _lockdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LockId
		{
			set{ _lockid=value;}
			get{return _lockid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Timeout
		{
			set{ _timeout=value;}
			get{return _timeout;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Locked
		{
			set{ _locked=value;}
			get{return _locked;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SessionItems
		{
			set{ _sessionitems=value;}
			get{return _sessionitems;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Flags
		{
			set{ _flags=value;}
			get{return _flags;}
		}
		#endregion Model

	}
}


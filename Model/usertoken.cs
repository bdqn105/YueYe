using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// usertoken:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class usertoken
	{
		public usertoken()
		{}
		#region Model
		private int _tokenid;
		private string _sessionid;
		private string _userid;
		private string _deviceid;
		private DateTime _createdate;
		private DateTime _lastlogintime;
		private DateTime? _expires;
		private int? _softversion;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int TokenId
		{
			set{ _tokenid=value;}
			get{return _tokenid;}
		}
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
		public string UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeviceId
		{
			set{ _deviceid=value;}
			get{return _deviceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LastLoginTime
		{
			set{ _lastlogintime=value;}
			get{return _lastlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Expires
		{
			set{ _expires=value;}
			get{return _expires;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SoftVersion
		{
			set{ _softversion=value;}
			get{return _softversion;}
		}
		#endregion Model

	}
}


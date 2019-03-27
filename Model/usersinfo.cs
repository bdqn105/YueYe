using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// usersinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class usersinfo
	{
		public usersinfo()
		{}
		#region Model
		private int _id;
		private string _userid;
		private string _username;
		private string _usermobile;
		private string _usersex;
		private string _userpassword;
		private int _userstate;
		private string _usertypeid;
		private string _companyid;
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
		public string UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserMobile
		{
			set{ _usermobile=value;}
			get{return _usermobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserSex
		{
			set{ _usersex=value;}
			get{return _usersex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPassword
		{
			set{ _userpassword=value;}
			get{return _userpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserState
		{
			set{ _userstate=value;}
			get{return _userstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserTypeId
		{
			set{ _usertypeid=value;}
			get{return _usertypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyId
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		#endregion Model

	}
}


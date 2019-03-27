using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// userstypeinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userstypeinfo
	{
		public userstypeinfo()
		{}
		#region Model
		private int _usertypeid;
		private string _usertypename;
		private string _usercontrolid;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int UserTypeId
		{
			set{ _usertypeid=value;}
			get{return _usertypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserTypeName
		{
			set{ _usertypename=value;}
			get{return _usertypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserControlId
		{
			set{ _usercontrolid=value;}
			get{return _usercontrolid;}
		}
		#endregion Model

	}
}


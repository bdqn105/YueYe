using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// usercontrolinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class usercontrolinfo
	{
		public usercontrolinfo()
		{}
		#region Model
		private int _id;
		private string _usercontrolid;
		private string _usercontrolname;
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
		public string UserControlId
		{
			set{ _usercontrolid=value;}
			get{return _usercontrolid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserControlName
		{
			set{ _usercontrolname=value;}
			get{return _usercontrolname;}
		}
		#endregion Model

	}
}


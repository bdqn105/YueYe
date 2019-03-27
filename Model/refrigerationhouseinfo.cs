using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// refrigerationhouseinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class refrigerationhouseinfo
	{
		public refrigerationhouseinfo()
		{}
		#region Model
		private int _id;
		private string _houseid;
		private string _companyid;
		private string _housename;
		private string _houselocation;
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
		public string HouseId
		{
			set{ _houseid=value;}
			get{return _houseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyId
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HouseName
		{
			set{ _housename=value;}
			get{return _housename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HouseLocation
		{
			set{ _houselocation=value;}
			get{return _houselocation;}
		}
		#endregion Model

	}
}


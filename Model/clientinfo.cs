using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// clientinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class clientinfo
	{
		public clientinfo()
		{}
		#region Model
		private int _id;
		private string _clientid;
		private string _clientname;
		private string _telephone;
		private string _mobile;
		private string _companyid;
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
		public string ClientId
		{
			set{ _clientid=value;}
			get{return _clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientName
		{
			set{ _clientname=value;}
			get{return _clientname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
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


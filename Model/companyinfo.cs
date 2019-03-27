using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// companyinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class companyinfo
	{
		public companyinfo()
		{}
		#region Model
		private int _id;
		private string _companyid;
		private string _companyname;
		private string _companyunifiedcode;
		private string _topublicaccount;
		private string _toprivateaccount;
		private string _companylocation;
		private string _companyaddress;
		private string _businessnature;
		private string _legalrepresentative;
		private string _telephone;
		private string _mobile;
		private string _faxno;
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
		public string CompanyID
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyUnifiedCode
		{
			set{ _companyunifiedcode=value;}
			get{return _companyunifiedcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToPublicAccount
		{
			set{ _topublicaccount=value;}
			get{return _topublicaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToPrivateAccount
		{
			set{ _toprivateaccount=value;}
			get{return _toprivateaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyLocation
		{
			set{ _companylocation=value;}
			get{return _companylocation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyAddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinessNature
		{
			set{ _businessnature=value;}
			get{return _businessnature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LegalRepresentative
		{
			set{ _legalrepresentative=value;}
			get{return _legalrepresentative;}
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
		public string FaxNo
		{
			set{ _faxno=value;}
			get{return _faxno;}
		}
		#endregion Model

	}
}


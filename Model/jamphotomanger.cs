using System;
namespace YueYePlat.Model
{
	/// <summary>
	/// jamphotomanger:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class jamphotomanger
	{
		public jamphotomanger()
		{}
		#region Model
		private int _id;
		private long? _jamid;
		private string _jamphotos;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? JamId
		{
			set{ _jamid=value;}
			get{return _jamid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JamPhotos
		{
			set{ _jamphotos=value;}
			get{return _jamphotos;}
		}
		#endregion Model

	}
}


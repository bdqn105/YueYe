using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using YueYePlat.Model;
namespace YueYePlat.BLL
{
	/// <summary>
	/// sessions
	/// </summary>
	public partial class sessions
	{
		private readonly YueYePlat.DAL.sessions dal=new YueYePlat.DAL.sessions();
		public sessions()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SessionId,string ApplicationName)
		{
			return dal.Exists(SessionId,ApplicationName);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.sessions model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YueYePlat.Model.sessions model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string SessionId,string ApplicationName)
		{
			
			return dal.Delete(SessionId,ApplicationName);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueYePlat.Model.sessions GetModel(string SessionId,string ApplicationName)
		{
			
			return dal.GetModel(SessionId,ApplicationName);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YueYePlat.Model.sessions GetModelByCache(string SessionId,string ApplicationName)
		{
			
			string CacheKey = "sessionsModel-" + SessionId+ApplicationName;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SessionId,ApplicationName);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YueYePlat.Model.sessions)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YueYePlat.Model.sessions> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YueYePlat.Model.sessions> DataTableToList(DataTable dt)
		{
			List<YueYePlat.Model.sessions> modelList = new List<YueYePlat.Model.sessions>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YueYePlat.Model.sessions model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}


using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using YueYePlat.Model;
namespace YueYePlat.BLL
{
	/// <summary>
	/// vehiclejam
	/// </summary>
	public partial class vehiclejam
	{
		private readonly YueYePlat.DAL.vehiclejam dal=new YueYePlat.DAL.vehiclejam();
		public vehiclejam()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long JamId)
		{
			return dal.Exists(JamId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.vehiclejam model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YueYePlat.Model.vehiclejam model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long JamId)
		{
			
			return dal.Delete(JamId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string JamIdlist )
		{
			return dal.DeleteList(JamIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueYePlat.Model.vehiclejam GetModel(long JamId)
		{
			
			return dal.GetModel(JamId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YueYePlat.Model.vehiclejam GetModelByCache(long JamId)
		{
			
			string CacheKey = "vehiclejamModel-" + JamId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(JamId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YueYePlat.Model.vehiclejam)objModel;
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
		public List<YueYePlat.Model.vehiclejam> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YueYePlat.Model.vehiclejam> DataTableToList(DataTable dt)
		{
			List<YueYePlat.Model.vehiclejam> modelList = new List<YueYePlat.Model.vehiclejam>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YueYePlat.Model.vehiclejam model;
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


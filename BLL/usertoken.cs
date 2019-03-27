using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using YueYePlat.Model;
namespace YueYePlat.BLL
{
	/// <summary>
	/// usertoken
	/// </summary>
	public partial class usertoken
	{
		private readonly YueYePlat.DAL.usertoken dal=new YueYePlat.DAL.usertoken();
		public usertoken()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TokenId)
		{
			return dal.Exists(TokenId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.usertoken model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YueYePlat.Model.usertoken model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int TokenId)
		{
			
			return dal.Delete(TokenId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string TokenIdlist )
		{
			return dal.DeleteList(TokenIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueYePlat.Model.usertoken GetModel(int TokenId)
		{
			
			return dal.GetModel(TokenId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YueYePlat.Model.usertoken GetModelByCache(int TokenId)
		{
			
			string CacheKey = "usertokenModel-" + TokenId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(TokenId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YueYePlat.Model.usertoken)objModel;
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
		public List<YueYePlat.Model.usertoken> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YueYePlat.Model.usertoken> DataTableToList(DataTable dt)
		{
			List<YueYePlat.Model.usertoken> modelList = new List<YueYePlat.Model.usertoken>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YueYePlat.Model.usertoken model;
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


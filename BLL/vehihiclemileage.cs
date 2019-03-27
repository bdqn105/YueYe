using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using YueYePlat.Model;
namespace YueYePlat.BLL
{
	/// <summary>
	/// vehihiclemileage
	/// </summary>
	public partial class vehihiclemileage
	{
		private readonly YueYePlat.DAL.vehihiclemileage dal=new YueYePlat.DAL.vehihiclemileage();
		public vehihiclemileage()
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
		public bool Exists(int MileageID)
		{
			return dal.Exists(MileageID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.vehihiclemileage model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YueYePlat.Model.vehihiclemileage model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int MileageID)
		{
			
			return dal.Delete(MileageID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string MileageIDlist )
		{
			return dal.DeleteList(MileageIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueYePlat.Model.vehihiclemileage GetModel(int MileageID)
		{
			
			return dal.GetModel(MileageID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YueYePlat.Model.vehihiclemileage GetModelByCache(int MileageID)
		{
			
			string CacheKey = "vehihiclemileageModel-" + MileageID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(MileageID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YueYePlat.Model.vehihiclemileage)objModel;
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
		public List<YueYePlat.Model.vehihiclemileage> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YueYePlat.Model.vehihiclemileage> DataTableToList(DataTable dt)
		{
			List<YueYePlat.Model.vehihiclemileage> modelList = new List<YueYePlat.Model.vehihiclemileage>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YueYePlat.Model.vehihiclemileage model;
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


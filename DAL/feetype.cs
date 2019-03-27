
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:feetype
	/// </summary>
	public partial class feetype
	{
		public feetype()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from feetype");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.feetype model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into feetype(");
			strSql.Append("FeeTypeName,isDetail,DefaultFee,isDetailCount)");
			strSql.Append(" values (");
			strSql.Append("@FeeTypeName,@isDetail,@DefaultFee,@isDetailCount)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@FeeTypeName", MySqlDbType.VarChar,50),
					new MySqlParameter("@isDetail", MySqlDbType.Bit),
					new MySqlParameter("@DefaultFee", MySqlDbType.Decimal,15),
					new MySqlParameter("@isDetailCount", MySqlDbType.Bit)};
			parameters[0].Value = model.FeeTypeName;
			parameters[1].Value = model.isDetail;
			parameters[2].Value = model.DefaultFee;
			parameters[3].Value = model.isDetailCount;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YueYePlat.Model.feetype model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update feetype set ");
			strSql.Append("FeeTypeName=@FeeTypeName,");
			strSql.Append("isDetail=@isDetail,");
			strSql.Append("DefaultFee=@DefaultFee,");
			strSql.Append("isDetailCount=@isDetailCount");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@FeeTypeName", MySqlDbType.VarChar,50),
					new MySqlParameter("@isDetail", MySqlDbType.Bit),
					new MySqlParameter("@DefaultFee", MySqlDbType.Decimal,15),
					new MySqlParameter("@isDetailCount", MySqlDbType.Bit),
					new MySqlParameter("@Id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.FeeTypeName;
			parameters[1].Value = model.isDetail;
			parameters[2].Value = model.DefaultFee;
			parameters[3].Value = model.isDetailCount;
			parameters[4].Value = model.Id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from feetype ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
			parameters[0].Value = Id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from feetype ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueYePlat.Model.feetype GetModel(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,FeeTypeName,isDetail,DefaultFee,isDetailCount from feetype ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.feetype model=new YueYePlat.Model.feetype();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YueYePlat.Model.feetype DataRowToModel(DataRow row)
		{
			YueYePlat.Model.feetype model=new YueYePlat.Model.feetype();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=long.Parse(row["Id"].ToString());
				}
				if(row["FeeTypeName"]!=null)
				{
					model.FeeTypeName=row["FeeTypeName"].ToString();
				}
				if(row["isDetail"]!=null && row["isDetail"].ToString()!="")
				{
					if((row["isDetail"].ToString()=="1")||(row["isDetail"].ToString().ToLower()=="true"))
					{
						model.isDetail=true;
					}
					else
					{
						model.isDetail=false;
					}
				}
				if(row["DefaultFee"]!=null && row["DefaultFee"].ToString()!="")
				{
					model.DefaultFee=decimal.Parse(row["DefaultFee"].ToString());
				}
				if(row["isDetailCount"]!=null && row["isDetailCount"].ToString()!="")
				{
					if((row["isDetailCount"].ToString()=="1")||(row["isDetailCount"].ToString().ToLower()=="true"))
					{
						model.isDetailCount=true;
					}
					else
					{
						model.isDetailCount=false;
					}
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,FeeTypeName,isDetail,DefaultFee,isDetailCount ");
			strSql.Append(" FROM feetype ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM feetype ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from feetype T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "feetype";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}


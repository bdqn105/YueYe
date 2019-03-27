using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:userstypeinfo
	/// </summary>
	public partial class userstypeinfo
	{
		public userstypeinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("UserTypeId", "userstypeinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserTypeId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userstypeinfo");
			strSql.Append(" where UserTypeId=@UserTypeId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserTypeId", MySqlDbType.Int32)
			};
			parameters[0].Value = UserTypeId;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.userstypeinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userstypeinfo(");
			strSql.Append("UserTypeName,UserControlId)");
			strSql.Append(" values (");
			strSql.Append("@UserTypeName,@UserControlId)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserTypeName", MySqlDbType.VarChar,20),
					new MySqlParameter("@UserControlId", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.UserTypeName;
			parameters[1].Value = model.UserControlId;

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
		public bool Update(YueYePlat.Model.userstypeinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userstypeinfo set ");
			strSql.Append("UserTypeName=@UserTypeName,");
			strSql.Append("UserControlId=@UserControlId");
			strSql.Append(" where UserTypeId=@UserTypeId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserTypeName", MySqlDbType.VarChar,20),
					new MySqlParameter("@UserControlId", MySqlDbType.VarChar,20),
					new MySqlParameter("@UserTypeId", MySqlDbType.Int32,11)};
			parameters[0].Value = model.UserTypeName;
			parameters[1].Value = model.UserControlId;
			parameters[2].Value = model.UserTypeId;

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
		public bool Delete(int UserTypeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userstypeinfo ");
			strSql.Append(" where UserTypeId=@UserTypeId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserTypeId", MySqlDbType.Int32)
			};
			parameters[0].Value = UserTypeId;

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
		public bool DeleteList(string UserTypeIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userstypeinfo ");
			strSql.Append(" where UserTypeId in ("+UserTypeIdlist + ")  ");
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
		public YueYePlat.Model.userstypeinfo GetModel(int UserTypeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select UserTypeId,UserTypeName,UserControlId from userstypeinfo ");
			strSql.Append(" where UserTypeId=@UserTypeId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserTypeId", MySqlDbType.Int32)
			};
			parameters[0].Value = UserTypeId;

			YueYePlat.Model.userstypeinfo model=new YueYePlat.Model.userstypeinfo();
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
		public YueYePlat.Model.userstypeinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.userstypeinfo model=new YueYePlat.Model.userstypeinfo();
			if (row != null)
			{
				if(row["UserTypeId"]!=null && row["UserTypeId"].ToString()!="")
				{
					model.UserTypeId=int.Parse(row["UserTypeId"].ToString());
				}
				if(row["UserTypeName"]!=null)
				{
					model.UserTypeName=row["UserTypeName"].ToString();
				}
				if(row["UserControlId"]!=null)
				{
					model.UserControlId=row["UserControlId"].ToString();
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
			strSql.Append("select UserTypeId,UserTypeName,UserControlId ");
			strSql.Append(" FROM userstypeinfo ");
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
			strSql.Append("select count(1) FROM userstypeinfo ");
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
				strSql.Append("order by T.UserTypeId desc");
			}
			strSql.Append(")AS Row, T.*  from userstypeinfo T ");
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
			parameters[0].Value = "userstypeinfo";
			parameters[1].Value = "UserTypeId";
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


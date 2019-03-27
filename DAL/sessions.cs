using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:sessions
	/// </summary>
	public partial class sessions
	{
		public sessions()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SessionId,string ApplicationName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sessions");
			strSql.Append(" where SessionId=@SessionId and ApplicationName=@ApplicationName ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SessionId", MySqlDbType.VarChar,80),
					new MySqlParameter("@ApplicationName", MySqlDbType.VarChar,255)			};
			parameters[0].Value = SessionId;
			parameters[1].Value = ApplicationName;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.sessions model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sessions(");
			strSql.Append("SessionId,ApplicationName,Created,Expires,LockDate,LockId,Timeout,Locked,SessionItems,Flags)");
			strSql.Append(" values (");
			strSql.Append("@SessionId,@ApplicationName,@Created,@Expires,@LockDate,@LockId,@Timeout,@Locked,@SessionItems,@Flags)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SessionId", MySqlDbType.VarChar,80),
					new MySqlParameter("@ApplicationName", MySqlDbType.VarChar,255),
					new MySqlParameter("@Created", MySqlDbType.DateTime),
					new MySqlParameter("@Expires", MySqlDbType.DateTime),
					new MySqlParameter("@LockDate", MySqlDbType.DateTime),
					new MySqlParameter("@LockId", MySqlDbType.Int32,10),
					new MySqlParameter("@Timeout", MySqlDbType.Int32,10),
					new MySqlParameter("@Locked", MySqlDbType.Int16,1),
					new MySqlParameter("@SessionItems", MySqlDbType.LongText),
					new MySqlParameter("@Flags", MySqlDbType.Int32,10)};
			parameters[0].Value = model.SessionId;
			parameters[1].Value = model.ApplicationName;
			parameters[2].Value = model.Created;
			parameters[3].Value = model.Expires;
			parameters[4].Value = model.LockDate;
			parameters[5].Value = model.LockId;
			parameters[6].Value = model.Timeout;
			parameters[7].Value = model.Locked;
			parameters[8].Value = model.SessionItems;
			parameters[9].Value = model.Flags;

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
		public bool Update(YueYePlat.Model.sessions model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sessions set ");
			strSql.Append("Created=@Created,");
			strSql.Append("Expires=@Expires,");
			strSql.Append("LockDate=@LockDate,");
			strSql.Append("LockId=@LockId,");
			strSql.Append("Timeout=@Timeout,");
			strSql.Append("Locked=@Locked,");
			strSql.Append("SessionItems=@SessionItems,");
			strSql.Append("Flags=@Flags");
			strSql.Append(" where SessionId=@SessionId and ApplicationName=@ApplicationName ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Created", MySqlDbType.DateTime),
					new MySqlParameter("@Expires", MySqlDbType.DateTime),
					new MySqlParameter("@LockDate", MySqlDbType.DateTime),
					new MySqlParameter("@LockId", MySqlDbType.Int32,10),
					new MySqlParameter("@Timeout", MySqlDbType.Int32,10),
					new MySqlParameter("@Locked", MySqlDbType.Int16,1),
					new MySqlParameter("@SessionItems", MySqlDbType.LongText),
					new MySqlParameter("@Flags", MySqlDbType.Int32,10),
					new MySqlParameter("@SessionId", MySqlDbType.VarChar,80),
					new MySqlParameter("@ApplicationName", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Created;
			parameters[1].Value = model.Expires;
			parameters[2].Value = model.LockDate;
			parameters[3].Value = model.LockId;
			parameters[4].Value = model.Timeout;
			parameters[5].Value = model.Locked;
			parameters[6].Value = model.SessionItems;
			parameters[7].Value = model.Flags;
			parameters[8].Value = model.SessionId;
			parameters[9].Value = model.ApplicationName;

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
		public bool Delete(string SessionId,string ApplicationName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sessions ");
			strSql.Append(" where SessionId=@SessionId and ApplicationName=@ApplicationName ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SessionId", MySqlDbType.VarChar,80),
					new MySqlParameter("@ApplicationName", MySqlDbType.VarChar,255)			};
			parameters[0].Value = SessionId;
			parameters[1].Value = ApplicationName;

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
		/// 得到一个对象实体
		/// </summary>
		public YueYePlat.Model.sessions GetModel(string SessionId,string ApplicationName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SessionId,ApplicationName,Created,Expires,LockDate,LockId,Timeout,Locked,SessionItems,Flags from sessions ");
			strSql.Append(" where SessionId=@SessionId and ApplicationName=@ApplicationName ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SessionId", MySqlDbType.VarChar,80),
					new MySqlParameter("@ApplicationName", MySqlDbType.VarChar,255)			};
			parameters[0].Value = SessionId;
			parameters[1].Value = ApplicationName;

			YueYePlat.Model.sessions model=new YueYePlat.Model.sessions();
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
		public YueYePlat.Model.sessions DataRowToModel(DataRow row)
		{
			YueYePlat.Model.sessions model=new YueYePlat.Model.sessions();
			if (row != null)
			{
				if(row["SessionId"]!=null)
				{
					model.SessionId=row["SessionId"].ToString();
				}
				if(row["ApplicationName"]!=null)
				{
					model.ApplicationName=row["ApplicationName"].ToString();
				}
				if(row["Created"]!=null && row["Created"].ToString()!="")
				{
					model.Created=DateTime.Parse(row["Created"].ToString());
				}
				if(row["Expires"]!=null && row["Expires"].ToString()!="")
				{
					model.Expires=DateTime.Parse(row["Expires"].ToString());
				}
				if(row["LockDate"]!=null && row["LockDate"].ToString()!="")
				{
					model.LockDate=DateTime.Parse(row["LockDate"].ToString());
				}
				if(row["LockId"]!=null && row["LockId"].ToString()!="")
				{
					model.LockId=int.Parse(row["LockId"].ToString());
				}
				if(row["Timeout"]!=null && row["Timeout"].ToString()!="")
				{
					model.Timeout=int.Parse(row["Timeout"].ToString());
				}
				if(row["Locked"]!=null && row["Locked"].ToString()!="")
				{
					model.Locked=int.Parse(row["Locked"].ToString());
				}
				if(row["SessionItems"]!=null)
				{
					model.SessionItems=row["SessionItems"].ToString();
				}
				if(row["Flags"]!=null && row["Flags"].ToString()!="")
				{
					model.Flags=int.Parse(row["Flags"].ToString());
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
			strSql.Append("select SessionId,ApplicationName,Created,Expires,LockDate,LockId,Timeout,Locked,SessionItems,Flags ");
			strSql.Append(" FROM sessions ");
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
			strSql.Append("select count(1) FROM sessions ");
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
				strSql.Append("order by T.ApplicationName desc");
			}
			strSql.Append(")AS Row, T.*  from sessions T ");
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
			parameters[0].Value = "sessions";
			parameters[1].Value = "ApplicationName";
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


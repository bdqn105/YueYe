using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:usertoken
	/// </summary>
	public partial class usertoken
	{
		public usertoken()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("TokenId", "usertoken"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TokenId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from usertoken");
			strSql.Append(" where TokenId=@TokenId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TokenId", MySqlDbType.Int32)
			};
			parameters[0].Value = TokenId;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.usertoken model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into usertoken(");
			strSql.Append("SessionId,UserId,DeviceId,CreateDate,LastLoginTime,Expires,SoftVersion)");
			strSql.Append(" values (");
			strSql.Append("@SessionId,@UserId,@DeviceId,@CreateDate,@LastLoginTime,@Expires,@SoftVersion)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SessionId", MySqlDbType.VarChar,80),
					new MySqlParameter("@UserId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeviceId", MySqlDbType.VarChar,50),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@LastLoginTime", MySqlDbType.DateTime),
					new MySqlParameter("@Expires", MySqlDbType.DateTime),
					new MySqlParameter("@SoftVersion", MySqlDbType.Int32,11)};
			parameters[0].Value = model.SessionId;
			parameters[1].Value = model.UserId;
			parameters[2].Value = model.DeviceId;
			parameters[3].Value = model.CreateDate;
			parameters[4].Value = model.LastLoginTime;
			parameters[5].Value = model.Expires;
			parameters[6].Value = model.SoftVersion;

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
		public bool Update(YueYePlat.Model.usertoken model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update usertoken set ");
			strSql.Append("SessionId=@SessionId,");
			strSql.Append("UserId=@UserId,");
			strSql.Append("DeviceId=@DeviceId,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("LastLoginTime=@LastLoginTime,");
			strSql.Append("Expires=@Expires,");
			strSql.Append("SoftVersion=@SoftVersion");
			strSql.Append(" where TokenId=@TokenId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SessionId", MySqlDbType.VarChar,80),
					new MySqlParameter("@UserId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeviceId", MySqlDbType.VarChar,50),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@LastLoginTime", MySqlDbType.DateTime),
					new MySqlParameter("@Expires", MySqlDbType.DateTime),
					new MySqlParameter("@SoftVersion", MySqlDbType.Int32,11),
					new MySqlParameter("@TokenId", MySqlDbType.Int32,11)};
			parameters[0].Value = model.SessionId;
			parameters[1].Value = model.UserId;
			parameters[2].Value = model.DeviceId;
			parameters[3].Value = model.CreateDate;
			parameters[4].Value = model.LastLoginTime;
			parameters[5].Value = model.Expires;
			parameters[6].Value = model.SoftVersion;
			parameters[7].Value = model.TokenId;

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
		public bool Delete(int TokenId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from usertoken ");
			strSql.Append(" where TokenId=@TokenId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TokenId", MySqlDbType.Int32)
			};
			parameters[0].Value = TokenId;

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
		public bool DeleteList(string TokenIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from usertoken ");
			strSql.Append(" where TokenId in ("+TokenIdlist + ")  ");
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
		public YueYePlat.Model.usertoken GetModel(int TokenId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TokenId,SessionId,UserId,DeviceId,CreateDate,LastLoginTime,Expires,SoftVersion from usertoken ");
			strSql.Append(" where TokenId=@TokenId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@TokenId", MySqlDbType.Int32)
			};
			parameters[0].Value = TokenId;

			YueYePlat.Model.usertoken model=new YueYePlat.Model.usertoken();
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
		public YueYePlat.Model.usertoken DataRowToModel(DataRow row)
		{
			YueYePlat.Model.usertoken model=new YueYePlat.Model.usertoken();
			if (row != null)
			{
				if(row["TokenId"]!=null && row["TokenId"].ToString()!="")
				{
					model.TokenId=int.Parse(row["TokenId"].ToString());
				}
				if(row["SessionId"]!=null)
				{
					model.SessionId=row["SessionId"].ToString();
				}
				if(row["UserId"]!=null)
				{
					model.UserId=row["UserId"].ToString();
				}
				if(row["DeviceId"]!=null)
				{
					model.DeviceId=row["DeviceId"].ToString();
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["LastLoginTime"]!=null && row["LastLoginTime"].ToString()!="")
				{
					model.LastLoginTime=DateTime.Parse(row["LastLoginTime"].ToString());
				}
				if(row["Expires"]!=null && row["Expires"].ToString()!="")
				{
					model.Expires=DateTime.Parse(row["Expires"].ToString());
				}
				if(row["SoftVersion"]!=null && row["SoftVersion"].ToString()!="")
				{
					model.SoftVersion=int.Parse(row["SoftVersion"].ToString());
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
			strSql.Append("select TokenId,SessionId,UserId,DeviceId,CreateDate,LastLoginTime,Expires,SoftVersion ");
			strSql.Append(" FROM usertoken ");
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
			strSql.Append("select count(1) FROM usertoken ");
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
				strSql.Append("order by T.TokenId desc");
			}
			strSql.Append(")AS Row, T.*  from usertoken T ");
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
			parameters[0].Value = "usertoken";
			parameters[1].Value = "TokenId";
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


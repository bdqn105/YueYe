using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:usersinfo
	/// </summary>
	public partial class usersinfo
	{
		public usersinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("ID", "usersinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from usersinfo");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32)
			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.usersinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into usersinfo(");
			strSql.Append("UserId,UserName,UserMobile,UserSex,UserPassword,UserState,UserTypeId,CompanyId)");
			strSql.Append(" values (");
			strSql.Append("@UserId,@UserName,@UserMobile,@UserSex,@UserPassword,@UserState,@UserTypeId,@CompanyId)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,100),
					new MySqlParameter("@UserMobile", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserSex", MySqlDbType.VarChar,2),
					new MySqlParameter("@UserPassword", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserState", MySqlDbType.Int32,11),
					new MySqlParameter("@UserTypeId", MySqlDbType.VarChar,20),
					new MySqlParameter("@CompanyId", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.UserId;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.UserMobile;
			parameters[3].Value = model.UserSex;
			parameters[4].Value = model.UserPassword;
			parameters[5].Value = model.UserState;
			parameters[6].Value = model.UserTypeId;
			parameters[7].Value = model.CompanyId;

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
		public bool Update(YueYePlat.Model.usersinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update usersinfo set ");
			strSql.Append("UserId=@UserId,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserMobile=@UserMobile,");
			strSql.Append("UserSex=@UserSex,");
			strSql.Append("UserPassword=@UserPassword,");
			strSql.Append("UserState=@UserState,");
			strSql.Append("UserTypeId=@UserTypeId,");
			strSql.Append("CompanyId=@CompanyId");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,100),
					new MySqlParameter("@UserMobile", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserSex", MySqlDbType.VarChar,2),
					new MySqlParameter("@UserPassword", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserState", MySqlDbType.Int32,11),
					new MySqlParameter("@UserTypeId", MySqlDbType.VarChar,20),
					new MySqlParameter("@CompanyId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ID", MySqlDbType.Int32,11)};
			parameters[0].Value = model.UserId;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.UserMobile;
			parameters[3].Value = model.UserSex;
			parameters[4].Value = model.UserPassword;
			parameters[5].Value = model.UserState;
			parameters[6].Value = model.UserTypeId;
			parameters[7].Value = model.CompanyId;
			parameters[8].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from usersinfo ");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from usersinfo ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public YueYePlat.Model.usersinfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,UserId,UserName,UserMobile,UserSex,UserPassword,UserState,UserTypeId,CompanyId from usersinfo ");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32)
			};
			parameters[0].Value = ID;

			YueYePlat.Model.usersinfo model=new YueYePlat.Model.usersinfo();
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
		public YueYePlat.Model.usersinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.usersinfo model=new YueYePlat.Model.usersinfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["UserId"]!=null)
				{
					model.UserId=row["UserId"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["UserMobile"]!=null)
				{
					model.UserMobile=row["UserMobile"].ToString();
				}
				if(row["UserSex"]!=null)
				{
					model.UserSex=row["UserSex"].ToString();
				}
				if(row["UserPassword"]!=null)
				{
					model.UserPassword=row["UserPassword"].ToString();
				}
				if(row["UserState"]!=null && row["UserState"].ToString()!="")
				{
					model.UserState=int.Parse(row["UserState"].ToString());
				}
				if(row["UserTypeId"]!=null)
				{
					model.UserTypeId=row["UserTypeId"].ToString();
				}
				if(row["CompanyId"]!=null)
				{
					model.CompanyId=row["CompanyId"].ToString();
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
			strSql.Append("select ID,UserId,UserName,UserMobile,UserSex,UserPassword,UserState,UserTypeId,CompanyId ");
			strSql.Append(" FROM usersinfo ");
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
			strSql.Append("select count(1) FROM usersinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperMySQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from usersinfo T ");
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
			parameters[0].Value = "usersinfo";
			parameters[1].Value = "ID";
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


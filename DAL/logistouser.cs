﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:logistouser
	/// </summary>
	public partial class logistouser
	{
		public logistouser()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("ID", "logistouser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from logistouser");
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
		public bool Add(YueYePlat.Model.logistouser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into logistouser(");
			strSql.Append("LogisCompanyID,UserID,CurDate,OrderCount)");
			strSql.Append(" values (");
			strSql.Append("@LogisCompanyID,@UserID,@CurDate,@OrderCount)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@LogisCompanyID", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserID", MySqlDbType.VarChar,50),
					new MySqlParameter("@CurDate", MySqlDbType.DateTime),
					new MySqlParameter("@OrderCount", MySqlDbType.Int32,11)};
			parameters[0].Value = model.LogisCompanyID;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.CurDate;
			parameters[3].Value = model.OrderCount;

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
		public bool Update(YueYePlat.Model.logistouser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update logistouser set ");
			strSql.Append("LogisCompanyID=@LogisCompanyID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("CurDate=@CurDate,");
			strSql.Append("OrderCount=@OrderCount");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@LogisCompanyID", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserID", MySqlDbType.VarChar,50),
					new MySqlParameter("@CurDate", MySqlDbType.DateTime),
					new MySqlParameter("@OrderCount", MySqlDbType.Int32,11),
					new MySqlParameter("@ID", MySqlDbType.Int32,11)};
			parameters[0].Value = model.LogisCompanyID;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.CurDate;
			parameters[3].Value = model.OrderCount;
			parameters[4].Value = model.ID;

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
			strSql.Append("delete from logistouser ");
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
			strSql.Append("delete from logistouser ");
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
		public YueYePlat.Model.logistouser GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,LogisCompanyID,UserID,CurDate,OrderCount from logistouser ");
			strSql.Append(" where ID=@ID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32)
			};
			parameters[0].Value = ID;

			YueYePlat.Model.logistouser model=new YueYePlat.Model.logistouser();
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
		public YueYePlat.Model.logistouser DataRowToModel(DataRow row)
		{
			YueYePlat.Model.logistouser model=new YueYePlat.Model.logistouser();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["LogisCompanyID"]!=null)
				{
					model.LogisCompanyID=row["LogisCompanyID"].ToString();
				}
				if(row["UserID"]!=null)
				{
					model.UserID=row["UserID"].ToString();
				}
				if(row["CurDate"]!=null && row["CurDate"].ToString()!="")
				{
					model.CurDate=DateTime.Parse(row["CurDate"].ToString());
				}
				if(row["OrderCount"]!=null && row["OrderCount"].ToString()!="")
				{
					model.OrderCount=int.Parse(row["OrderCount"].ToString());
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
			strSql.Append("select ID,LogisCompanyID,UserID,CurDate,OrderCount ");
			strSql.Append(" FROM logistouser ");
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
			strSql.Append("select count(1) FROM logistouser ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from logistouser T ");
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
			parameters[0].Value = "logistouser";
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


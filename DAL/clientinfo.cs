﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:clientinfo
	/// </summary>
	public partial class clientinfo
	{
		public clientinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "clientinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from clientinfo");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.clientinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into clientinfo(");
			strSql.Append("ClientId,ClientName,Telephone,Mobile,CompanyId)");
			strSql.Append(" values (");
			strSql.Append("@ClientId,@ClientName,@Telephone,@Mobile,@CompanyId)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ClientId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ClientName", MySqlDbType.VarChar,50),
					new MySqlParameter("@Telephone", MySqlDbType.VarChar,50),
					new MySqlParameter("@Mobile", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyId", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.ClientId;
			parameters[1].Value = model.ClientName;
			parameters[2].Value = model.Telephone;
			parameters[3].Value = model.Mobile;
			parameters[4].Value = model.CompanyId;

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
		public bool Update(YueYePlat.Model.clientinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update clientinfo set ");
			strSql.Append("ClientId=@ClientId,");
			strSql.Append("ClientName=@ClientName,");
			strSql.Append("Telephone=@Telephone,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("CompanyId=@CompanyId");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ClientId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ClientName", MySqlDbType.VarChar,50),
					new MySqlParameter("@Telephone", MySqlDbType.VarChar,50),
					new MySqlParameter("@Mobile", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.ClientId;
			parameters[1].Value = model.ClientName;
			parameters[2].Value = model.Telephone;
			parameters[3].Value = model.Mobile;
			parameters[4].Value = model.CompanyId;
			parameters[5].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from clientinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
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
			strSql.Append("delete from clientinfo ");
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
		public YueYePlat.Model.clientinfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,ClientId,ClientName,Telephone,Mobile,CompanyId from clientinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.clientinfo model=new YueYePlat.Model.clientinfo();
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
		public YueYePlat.Model.clientinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.clientinfo model=new YueYePlat.Model.clientinfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["ClientId"]!=null)
				{
					model.ClientId=row["ClientId"].ToString();
				}
				if(row["ClientName"]!=null)
				{
					model.ClientName=row["ClientName"].ToString();
				}
				if(row["Telephone"]!=null)
				{
					model.Telephone=row["Telephone"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
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
			strSql.Append("select Id,ClientId,ClientName,Telephone,Mobile,CompanyId ");
			strSql.Append(" FROM clientinfo ");
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
			strSql.Append("select count(1) FROM clientinfo ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from clientinfo T ");
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
			parameters[0].Value = "clientinfo";
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


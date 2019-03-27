﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:chargebackinfo
	/// </summary>
	public partial class chargebackinfo
	{
		public chargebackinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "chargebackinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from chargebackinfo");
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
		public bool Add(YueYePlat.Model.chargebackinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into chargebackinfo(");
			strSql.Append("DeliveryId,DeliveryOrderId,ChargeBackDispose,ChargeBackId,ChargeBackTime)");
			strSql.Append(" values (");
			strSql.Append("@DeliveryId,@DeliveryOrderId,@ChargeBackDispose,@ChargeBackId,@ChargeBackTime)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeliveryOrderId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ChargeBackDispose", MySqlDbType.VarChar,500),
					new MySqlParameter("@ChargeBackId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ChargeBackTime", MySqlDbType.DateTime)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.DeliveryOrderId;
			parameters[2].Value = model.ChargeBackDispose;
			parameters[3].Value = model.ChargeBackId;
			parameters[4].Value = model.ChargeBackTime;

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
		public bool Update(YueYePlat.Model.chargebackinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update chargebackinfo set ");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("DeliveryOrderId=@DeliveryOrderId,");
			strSql.Append("ChargeBackDispose=@ChargeBackDispose,");
			strSql.Append("ChargeBackId=@ChargeBackId,");
			strSql.Append("ChargeBackTime=@ChargeBackTime");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeliveryOrderId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ChargeBackDispose", MySqlDbType.VarChar,500),
					new MySqlParameter("@ChargeBackId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ChargeBackTime", MySqlDbType.DateTime),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.DeliveryOrderId;
			parameters[2].Value = model.ChargeBackDispose;
			parameters[3].Value = model.ChargeBackId;
			parameters[4].Value = model.ChargeBackTime;
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
			strSql.Append("delete from chargebackinfo ");
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
			strSql.Append("delete from chargebackinfo ");
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
		public YueYePlat.Model.chargebackinfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliveryId,DeliveryOrderId,ChargeBackDispose,ChargeBackId,ChargeBackTime from chargebackinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.chargebackinfo model=new YueYePlat.Model.chargebackinfo();
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
		public YueYePlat.Model.chargebackinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.chargebackinfo model=new YueYePlat.Model.chargebackinfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DeliveryId"]!=null)
				{
					model.DeliveryId=row["DeliveryId"].ToString();
				}
				if(row["DeliveryOrderId"]!=null)
				{
					model.DeliveryOrderId=row["DeliveryOrderId"].ToString();
				}
				if(row["ChargeBackDispose"]!=null)
				{
					model.ChargeBackDispose=row["ChargeBackDispose"].ToString();
				}
				if(row["ChargeBackId"]!=null)
				{
					model.ChargeBackId=row["ChargeBackId"].ToString();
				}
				if(row["ChargeBackTime"]!=null && row["ChargeBackTime"].ToString()!="")
				{
					model.ChargeBackTime=DateTime.Parse(row["ChargeBackTime"].ToString());
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
			strSql.Append("select Id,DeliveryId,DeliveryOrderId,ChargeBackDispose,ChargeBackId,ChargeBackTime ");
			strSql.Append(" FROM chargebackinfo ");
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
			strSql.Append("select count(1) FROM chargebackinfo ");
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
			strSql.Append(")AS Row, T.*  from chargebackinfo T ");
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
			parameters[0].Value = "chargebackinfo";
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


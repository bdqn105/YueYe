using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:deliveryorderfee
	/// </summary>
	public partial class deliveryorderfee
	{
		public deliveryorderfee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from deliveryorderfee");
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
		public bool Add(YueYePlat.Model.deliveryorderfee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into deliveryorderfee(");
			strSql.Append("DeliveryOrderId,DeliveryOrderDetailID,FeeTypeId,Fee,IsShow,Remark)");
			strSql.Append(" values (");
			strSql.Append("@DeliveryOrderId,@DeliveryOrderDetailID,@FeeTypeId,@Fee,@IsShow,@Remark)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryOrderId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeliveryOrderDetailID", MySqlDbType.VarChar,11),
					new MySqlParameter("@FeeTypeId", MySqlDbType.Int32,11),
					new MySqlParameter("@Fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@IsShow", MySqlDbType.Bit),
					new MySqlParameter("@Remark", MySqlDbType.Text)};
			parameters[0].Value = model.DeliveryOrderId;
			parameters[1].Value = model.DeliveryOrderDetailID;
			parameters[2].Value = model.FeeTypeId;
			parameters[3].Value = model.Fee;
			parameters[4].Value = model.IsShow;
			parameters[5].Value = model.Remark;

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
		public bool Update(YueYePlat.Model.deliveryorderfee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update deliveryorderfee set ");
			strSql.Append("DeliveryOrderId=@DeliveryOrderId,");
			strSql.Append("DeliveryOrderDetailID=@DeliveryOrderDetailID,");
			strSql.Append("FeeTypeId=@FeeTypeId,");
			strSql.Append("Fee=@Fee,");
			strSql.Append("IsShow=@IsShow,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryOrderId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeliveryOrderDetailID", MySqlDbType.VarChar,11),
					new MySqlParameter("@FeeTypeId", MySqlDbType.Int32,11),
					new MySqlParameter("@Fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@IsShow", MySqlDbType.Bit),
					new MySqlParameter("@Remark", MySqlDbType.Text),
					new MySqlParameter("@Id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.DeliveryOrderId;
			parameters[1].Value = model.DeliveryOrderDetailID;
			parameters[2].Value = model.FeeTypeId;
			parameters[3].Value = model.Fee;
			parameters[4].Value = model.IsShow;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.Id;

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
			strSql.Append("delete from deliveryorderfee ");
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
			strSql.Append("delete from deliveryorderfee ");
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
		public YueYePlat.Model.deliveryorderfee GetModel(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliveryOrderId,DeliveryOrderDetailID,FeeTypeId,Fee,IsShow,Remark from deliveryorderfee ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.deliveryorderfee model=new YueYePlat.Model.deliveryorderfee();
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
		public YueYePlat.Model.deliveryorderfee DataRowToModel(DataRow row)
		{
			YueYePlat.Model.deliveryorderfee model=new YueYePlat.Model.deliveryorderfee();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=long.Parse(row["Id"].ToString());
				}
				if(row["DeliveryOrderId"]!=null)
				{
					model.DeliveryOrderId=row["DeliveryOrderId"].ToString();
				}
				if(row["DeliveryOrderDetailID"]!=null)
				{
					model.DeliveryOrderDetailID=row["DeliveryOrderDetailID"].ToString();
				}
				if(row["FeeTypeId"]!=null && row["FeeTypeId"].ToString()!="")
				{
					model.FeeTypeId=int.Parse(row["FeeTypeId"].ToString());
				}
				if(row["Fee"]!=null && row["Fee"].ToString()!="")
				{
					model.Fee=decimal.Parse(row["Fee"].ToString());
				}
				if(row["IsShow"]!=null && row["IsShow"].ToString()!="")
				{
					if((row["IsShow"].ToString()=="1")||(row["IsShow"].ToString().ToLower()=="true"))
					{
						model.IsShow=true;
					}
					else
					{
						model.IsShow=false;
					}
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select Id,DeliveryOrderId,DeliveryOrderDetailID,FeeTypeId,Fee,IsShow,Remark ");
			strSql.Append(" FROM deliveryorderfee ");
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
			strSql.Append("select count(1) FROM deliveryorderfee ");
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
			strSql.Append(")AS Row, T.*  from deliveryorderfee T ");
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
			parameters[0].Value = "deliveryorderfee";
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


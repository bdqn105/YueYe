using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:roadtoll
	/// </summary>
	public partial class roadtoll
	{
		public roadtoll()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "roadtoll"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from roadtoll");
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
		public bool Add(YueYePlat.Model.roadtoll model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into roadtoll(");
			strSql.Append("DeliveryId,OrderNumber,TollStation,Money,TollTime,InvoicePhoto,DriverId)");
			strSql.Append(" values (");
			strSql.Append("@DeliveryId,@OrderNumber,@TollStation,@Money,@TollTime,@InvoicePhoto,@DriverId)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@OrderNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@TollStation", MySqlDbType.VarChar,50),
					new MySqlParameter("@Money", MySqlDbType.Double),
					new MySqlParameter("@TollTime", MySqlDbType.DateTime),
					new MySqlParameter("@InvoicePhoto", MySqlDbType.VarChar,100),
					new MySqlParameter("@DriverId", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.OrderNumber;
			parameters[2].Value = model.TollStation;
			parameters[3].Value = model.Money;
			parameters[4].Value = model.TollTime;
			parameters[5].Value = model.InvoicePhoto;
			parameters[6].Value = model.DriverId;

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
		public bool Update(YueYePlat.Model.roadtoll model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update roadtoll set ");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("OrderNumber=@OrderNumber,");
			strSql.Append("TollStation=@TollStation,");
			strSql.Append("Money=@Money,");
			strSql.Append("TollTime=@TollTime,");
			strSql.Append("InvoicePhoto=@InvoicePhoto,");
			strSql.Append("DriverId=@DriverId");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@OrderNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@TollStation", MySqlDbType.VarChar,50),
					new MySqlParameter("@Money", MySqlDbType.Double),
					new MySqlParameter("@TollTime", MySqlDbType.DateTime),
					new MySqlParameter("@InvoicePhoto", MySqlDbType.VarChar,100),
					new MySqlParameter("@DriverId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.OrderNumber;
			parameters[2].Value = model.TollStation;
			parameters[3].Value = model.Money;
			parameters[4].Value = model.TollTime;
			parameters[5].Value = model.InvoicePhoto;
			parameters[6].Value = model.DriverId;
			parameters[7].Value = model.Id;

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
			strSql.Append("delete from roadtoll ");
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
			strSql.Append("delete from roadtoll ");
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
		public YueYePlat.Model.roadtoll GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliveryId,OrderNumber,TollStation,Money,TollTime,InvoicePhoto,DriverId from roadtoll ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.roadtoll model=new YueYePlat.Model.roadtoll();
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
		public YueYePlat.Model.roadtoll DataRowToModel(DataRow row)
		{
			YueYePlat.Model.roadtoll model=new YueYePlat.Model.roadtoll();
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
				if(row["OrderNumber"]!=null && row["OrderNumber"].ToString()!="")
				{
					model.OrderNumber=int.Parse(row["OrderNumber"].ToString());
				}
				if(row["TollStation"]!=null)
				{
					model.TollStation=row["TollStation"].ToString();
				}
                if (row["Money"] != null)
                {
                    model.Money = double.Parse (row["Money"].ToString());
                }
					//model.Money=row["Money"].ToString();
				if(row["TollTime"]!=null && row["TollTime"].ToString()!="")
				{
					model.TollTime=DateTime.Parse(row["TollTime"].ToString());
				}
				if(row["InvoicePhoto"]!=null)
				{
					model.InvoicePhoto=row["InvoicePhoto"].ToString();
				}
				if(row["DriverId"]!=null)
				{
					model.DriverId=row["DriverId"].ToString();
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
			strSql.Append("select Id,DeliveryId,OrderNumber,TollStation,Money,TollTime,InvoicePhoto,DriverId ");
			strSql.Append(" FROM roadtoll ");
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
			strSql.Append("select count(1) FROM roadtoll ");
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
			strSql.Append(")AS Row, T.*  from roadtoll T ");
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
			parameters[0].Value = "roadtoll";
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


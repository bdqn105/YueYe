using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:incubator
	/// </summary>
	public partial class incubator
	{
		public incubator()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "incubator"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from incubator");
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
		public bool Add(YueYePlat.Model.incubator model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into incubator(");
			strSql.Append("IncubatorID,DeliveryId,Longitude,Latitude,Temperture,Humidity,Time,ProductId,Quantity,Unit,Destination)");
			strSql.Append(" values (");
			strSql.Append("@IncubatorID,@DeliveryId,@Longitude,@Latitude,@Temperture,@Humidity,@Time,@ProductId,@Quantity,@Unit,@Destination)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@IncubatorID", MySqlDbType.VarChar,8),
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@Temperture", MySqlDbType.Double),
					new MySqlParameter("@Humidity", MySqlDbType.Double),
					new MySqlParameter("@Time", MySqlDbType.DateTime),
					new MySqlParameter("@ProductId", MySqlDbType.VarChar,6),
					new MySqlParameter("@Quantity", MySqlDbType.Int32,11),
					new MySqlParameter("@Unit", MySqlDbType.VarChar,10),
					new MySqlParameter("@Destination", MySqlDbType.VarChar,300)};
			parameters[0].Value = model.IncubatorID;
			parameters[1].Value = model.DeliveryId;
			parameters[2].Value = model.Longitude;
			parameters[3].Value = model.Latitude;
			parameters[4].Value = model.Temperture;
			parameters[5].Value = model.Humidity;
			parameters[6].Value = model.Time;
			parameters[7].Value = model.ProductId;
			parameters[8].Value = model.Quantity;
			parameters[9].Value = model.Unit;
			parameters[10].Value = model.Destination;

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
		public bool Update(YueYePlat.Model.incubator model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update incubator set ");
			strSql.Append("IncubatorID=@IncubatorID,");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Latitude=@Latitude,");
			strSql.Append("Temperture=@Temperture,");
			strSql.Append("Humidity=@Humidity,");
			strSql.Append("Time=@Time,");
			strSql.Append("ProductId=@ProductId,");
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("Destination=@Destination");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@IncubatorID", MySqlDbType.VarChar,8),
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@Temperture", MySqlDbType.Double),
					new MySqlParameter("@Humidity", MySqlDbType.Double),
					new MySqlParameter("@Time", MySqlDbType.DateTime),
					new MySqlParameter("@ProductId", MySqlDbType.VarChar,6),
					new MySqlParameter("@Quantity", MySqlDbType.Int32,11),
					new MySqlParameter("@Unit", MySqlDbType.VarChar,10),
					new MySqlParameter("@Destination", MySqlDbType.VarChar,300),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.IncubatorID;
			parameters[1].Value = model.DeliveryId;
			parameters[2].Value = model.Longitude;
			parameters[3].Value = model.Latitude;
			parameters[4].Value = model.Temperture;
			parameters[5].Value = model.Humidity;
			parameters[6].Value = model.Time;
			parameters[7].Value = model.ProductId;
			parameters[8].Value = model.Quantity;
			parameters[9].Value = model.Unit;
			parameters[10].Value = model.Destination;
			parameters[11].Value = model.Id;

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
			strSql.Append("delete from incubator ");
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
			strSql.Append("delete from incubator ");
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
		public YueYePlat.Model.incubator GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,IncubatorID,DeliveryId,Longitude,Latitude,Temperture,Humidity,Time,ProductId,Quantity,Unit,Destination from incubator ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.incubator model=new YueYePlat.Model.incubator();
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
		public YueYePlat.Model.incubator DataRowToModel(DataRow row)
		{
			YueYePlat.Model.incubator model=new YueYePlat.Model.incubator();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["IncubatorID"]!=null)
				{
					model.IncubatorID=row["IncubatorID"].ToString();
				}
				if(row["DeliveryId"]!=null)
				{
					model.DeliveryId=row["DeliveryId"].ToString();
				}
                if (row["Longitude"] != null && row["Longitude"].ToString() != "")
                {
                    model.Longitude = Double.Parse(row["Longitude"].ToString());
                }
                if (row["Latitude"] != null && row["Latitude"].ToString() != "")
                {
                    model.Latitude = Double.Parse(row["Latitude"].ToString());
                }
                if (row["Temperture"] != null && row["Temperture"].ToString() != "")
                {
                    model.Temperture = Double.Parse(row["Temperture"].ToString());
                }
                if (row["Humidity"] != null && row["Humidity"].ToString() != "")
                {
                    model.Humidity = Double.Parse(row["Humidity"].ToString());
                }
                //model.Longitude=row["Longitude"].ToString();
                //model.Latitude=row["Latitude"].ToString();
                //model.Temperture=row["Temperture"].ToString();
                //model.Humidity=row["Humidity"].ToString();
                if (row["Time"]!=null && row["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(row["Time"].ToString());
				}
				if(row["ProductId"]!=null)
				{
					model.ProductId=row["ProductId"].ToString();
				}
				if(row["Quantity"]!=null && row["Quantity"].ToString()!="")
				{
					model.Quantity=int.Parse(row["Quantity"].ToString());
				}
				if(row["Unit"]!=null)
				{
					model.Unit=row["Unit"].ToString();
				}
				if(row["Destination"]!=null)
				{
					model.Destination=row["Destination"].ToString();
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
			strSql.Append("select Id,IncubatorID,DeliveryId,Longitude,Latitude,Temperture,Humidity,Time,ProductId,Quantity,Unit,Destination ");
			strSql.Append(" FROM incubator ");
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
			strSql.Append("select count(1) FROM incubator ");
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
			strSql.Append(")AS Row, T.*  from incubator T ");
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
			parameters[0].Value = "incubator";
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


using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:deliverypath
	/// </summary>
	public partial class deliverypath
	{
		public deliverypath()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "deliverypath"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from deliverypath");
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
		public bool Add(YueYePlat.Model.deliverypath model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into deliverypath(");
			strSql.Append("DeliverId,OrderNumber,Longitude,Latitude,LimitSpeed,LocationName,LocationSign)");
			strSql.Append(" values (");
			strSql.Append("@DeliverId,@OrderNumber,@Longitude,@Latitude,@LimitSpeed,@LocationName,@LocationSign)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliverId", MySqlDbType.VarChar,16),
					new MySqlParameter("@OrderNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@LimitSpeed", MySqlDbType.Double),
					new MySqlParameter("@LocationName", MySqlDbType.VarChar,30),
					new MySqlParameter("@LocationSign", MySqlDbType.VarChar,30)};
			parameters[0].Value = model.DeliverId;
			parameters[1].Value = model.OrderNumber;
			parameters[2].Value = model.Longitude;
			parameters[3].Value = model.Latitude;
			parameters[4].Value = model.LimitSpeed;
			parameters[5].Value = model.LocationName;
			parameters[6].Value = model.LocationSign;

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
		public bool Update(YueYePlat.Model.deliverypath model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update deliverypath set ");
			strSql.Append("DeliverId=@DeliverId,");
			strSql.Append("OrderNumber=@OrderNumber,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Latitude=@Latitude,");
			strSql.Append("LimitSpeed=@LimitSpeed,");
			strSql.Append("LocationName=@LocationName,");
			strSql.Append("LocationSign=@LocationSign");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliverId", MySqlDbType.VarChar,16),
					new MySqlParameter("@OrderNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@LimitSpeed", MySqlDbType.Double),
					new MySqlParameter("@LocationName", MySqlDbType.VarChar,30),
					new MySqlParameter("@LocationSign", MySqlDbType.VarChar,30),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DeliverId;
			parameters[1].Value = model.OrderNumber;
			parameters[2].Value = model.Longitude;
			parameters[3].Value = model.Latitude;
			parameters[4].Value = model.LimitSpeed;
			parameters[5].Value = model.LocationName;
			parameters[6].Value = model.LocationSign;
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
			strSql.Append("delete from deliverypath ");
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
			strSql.Append("delete from deliverypath ");
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
		public YueYePlat.Model.deliverypath GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliverId,OrderNumber,Longitude,Latitude,LimitSpeed,LocationName,LocationSign from deliverypath ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.deliverypath model=new YueYePlat.Model.deliverypath();
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
		public YueYePlat.Model.deliverypath DataRowToModel(DataRow row)
		{
			YueYePlat.Model.deliverypath model=new YueYePlat.Model.deliverypath();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DeliverId"]!=null)
				{
					model.DeliverId=row["DeliverId"].ToString();
				}
				if(row["OrderNumber"]!=null && row["OrderNumber"].ToString()!="")
				{
					model.OrderNumber=int.Parse(row["OrderNumber"].ToString());
				}
                if (row["Longitude"] != null && row["Longitude"].ToString ()!="")
                {
                    model.Longitude = double.Parse ( row["Longitude"].ToString());
                }
                if (row["Latitude"] != null && row["Latitude"].ToString ()!="")
                {
                    model.Latitude = double.Parse ( row["Latitude"].ToString());
                }
                if (row["LimitSpeed"] != null && row["LimitSpeed"].ToString() != "")
                {
                    model.LimitSpeed = double.Parse(row["LimitSpeed"].ToString());
                }
                //model.Longitude=row["Longitude"].ToString();
                //model.Latitude=row["Latitude"].ToString();
                //model.LimitSpeed=row["LimitSpeed"].ToString();
                if (row["LocationName"]!=null)
				{
					model.LocationName=row["LocationName"].ToString();
				}
				if(row["LocationSign"]!=null)
				{
					model.LocationSign=row["LocationSign"].ToString();
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
			strSql.Append("select Id,DeliverId,OrderNumber,Longitude,Latitude,LimitSpeed,LocationName,LocationSign ");
			strSql.Append(" FROM deliverypath ");
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
			strSql.Append("select count(1) FROM deliverypath ");
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
			strSql.Append(")AS Row, T.*  from deliverypath T ");
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
			parameters[0].Value = "deliverypath";
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


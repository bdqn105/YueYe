using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:deliverycurgyroinfo
	/// </summary>
	public partial class deliverycurgyroinfo
	{
		public deliverycurgyroinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from deliverycurgyroinfo");
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
		public bool Add(YueYePlat.Model.deliverycurgyroinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into deliverycurgyroinfo(");
			strSql.Append("DeliveryId,Xaccelerated,Yaccelerated,Zaccelerated,Xangular,Yangular,Zangular,Longitude,Latitude,Speed,CurrentTime)");
			strSql.Append(" values (");
			strSql.Append("@DeliveryId,@Xaccelerated,@Yaccelerated,@Zaccelerated,@Xangular,@Yangular,@Zangular,@Longitude,@Latitude,@Speed,@CurrentTime)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Xaccelerated", MySqlDbType.Float),
					new MySqlParameter("@Yaccelerated", MySqlDbType.Float),
					new MySqlParameter("@Zaccelerated", MySqlDbType.Float),
					new MySqlParameter("@Xangular", MySqlDbType.Float),
					new MySqlParameter("@Yangular", MySqlDbType.Float),
					new MySqlParameter("@Zangular", MySqlDbType.Float),
					new MySqlParameter("@Longitude", MySqlDbType.Decimal,20),
					new MySqlParameter("@Latitude", MySqlDbType.Decimal,20),
					new MySqlParameter("@Speed", MySqlDbType.Decimal,10),
					new MySqlParameter("@CurrentTime", MySqlDbType.DateTime)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.Xaccelerated;
			parameters[2].Value = model.Yaccelerated;
			parameters[3].Value = model.Zaccelerated;
			parameters[4].Value = model.Xangular;
			parameters[5].Value = model.Yangular;
			parameters[6].Value = model.Zangular;
			parameters[7].Value = model.Longitude;
			parameters[8].Value = model.Latitude;
			parameters[9].Value = model.Speed;
			parameters[10].Value = model.CurrentTime;

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
		public bool Update(YueYePlat.Model.deliverycurgyroinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update deliverycurgyroinfo set ");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("Xaccelerated=@Xaccelerated,");
			strSql.Append("Yaccelerated=@Yaccelerated,");
			strSql.Append("Zaccelerated=@Zaccelerated,");
			strSql.Append("Xangular=@Xangular,");
			strSql.Append("Yangular=@Yangular,");
			strSql.Append("Zangular=@Zangular,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Latitude=@Latitude,");
			strSql.Append("Speed=@Speed,");
			strSql.Append("CurrentTime=@CurrentTime");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Xaccelerated", MySqlDbType.Float),
					new MySqlParameter("@Yaccelerated", MySqlDbType.Float),
					new MySqlParameter("@Zaccelerated", MySqlDbType.Float),
					new MySqlParameter("@Xangular", MySqlDbType.Float),
					new MySqlParameter("@Yangular", MySqlDbType.Float),
					new MySqlParameter("@Zangular", MySqlDbType.Float),
					new MySqlParameter("@Longitude", MySqlDbType.Decimal,20),
					new MySqlParameter("@Latitude", MySqlDbType.Decimal,20),
					new MySqlParameter("@Speed", MySqlDbType.Decimal,10),
					new MySqlParameter("@CurrentTime", MySqlDbType.DateTime),
					new MySqlParameter("@Id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.Xaccelerated;
			parameters[2].Value = model.Yaccelerated;
			parameters[3].Value = model.Zaccelerated;
			parameters[4].Value = model.Xangular;
			parameters[5].Value = model.Yangular;
			parameters[6].Value = model.Zangular;
			parameters[7].Value = model.Longitude;
			parameters[8].Value = model.Latitude;
			parameters[9].Value = model.Speed;
			parameters[10].Value = model.CurrentTime;
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
		public bool Delete(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from deliverycurgyroinfo ");
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
			strSql.Append("delete from deliverycurgyroinfo ");
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
		public YueYePlat.Model.deliverycurgyroinfo GetModel(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliveryId,Xaccelerated,Yaccelerated,Zaccelerated,Xangular,Yangular,Zangular,Longitude,Latitude,Speed,CurrentTime from deliverycurgyroinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.deliverycurgyroinfo model=new YueYePlat.Model.deliverycurgyroinfo();
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
		public YueYePlat.Model.deliverycurgyroinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.deliverycurgyroinfo model=new YueYePlat.Model.deliverycurgyroinfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=long.Parse(row["Id"].ToString());
				}
				if(row["DeliveryId"]!=null)
				{
					model.DeliveryId=row["DeliveryId"].ToString();
				}
				if(row["Xaccelerated"]!=null && row["Xaccelerated"].ToString()!="")
				{
					model.Xaccelerated=decimal.Parse(row["Xaccelerated"].ToString());
				}
				if(row["Yaccelerated"]!=null && row["Yaccelerated"].ToString()!="")
				{
					model.Yaccelerated=decimal.Parse(row["Yaccelerated"].ToString());
				}
				if(row["Zaccelerated"]!=null && row["Zaccelerated"].ToString()!="")
				{
					model.Zaccelerated=decimal.Parse(row["Zaccelerated"].ToString());
				}
				if(row["Xangular"]!=null && row["Xangular"].ToString()!="")
				{
					model.Xangular=decimal.Parse(row["Xangular"].ToString());
				}
				if(row["Yangular"]!=null && row["Yangular"].ToString()!="")
				{
					model.Yangular=decimal.Parse(row["Yangular"].ToString());
				}
				if(row["Zangular"]!=null && row["Zangular"].ToString()!="")
				{
					model.Zangular=decimal.Parse(row["Zangular"].ToString());
				}
				if(row["Longitude"]!=null && row["Longitude"].ToString()!="")
				{
					model.Longitude=decimal.Parse(row["Longitude"].ToString());
				}
				if(row["Latitude"]!=null && row["Latitude"].ToString()!="")
				{
					model.Latitude=decimal.Parse(row["Latitude"].ToString());
				}
				if(row["Speed"]!=null && row["Speed"].ToString()!="")
				{
					model.Speed=decimal.Parse(row["Speed"].ToString());
				}
				if(row["CurrentTime"]!=null && row["CurrentTime"].ToString()!="")
				{
					model.CurrentTime=DateTime.Parse(row["CurrentTime"].ToString());
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
			strSql.Append("select Id,DeliveryId,Xaccelerated,Yaccelerated,Zaccelerated,Xangular,Yangular,Zangular,Longitude,Latitude,Speed,CurrentTime ");
			strSql.Append(" FROM deliverycurgyroinfo ");
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
			strSql.Append("select count(1) FROM deliverycurgyroinfo ");
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
			strSql.Append(")AS Row, T.*  from deliverycurgyroinfo T ");
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
			parameters[0].Value = "deliverycurgyroinfo";
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


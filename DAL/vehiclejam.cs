using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:vehiclejam
	/// </summary>
	public partial class vehiclejam
	{
		public vehiclejam()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long JamId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from vehiclejam");
			strSql.Append(" where JamId=@JamId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@JamId", MySqlDbType.Int64)
			};
			parameters[0].Value = JamId;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.vehiclejam model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into vehiclejam(");
			strSql.Append("DeliverId,JamTime,JamLocation,Longitude,Latitude,JamUrl)");
			strSql.Append(" values (");
			strSql.Append("@DeliverId,@JamTime,@JamLocation,@Longitude,@Latitude,@JamUrl)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliverId", MySqlDbType.VarChar,16),
					new MySqlParameter("@JamTime", MySqlDbType.DateTime),
					new MySqlParameter("@JamLocation", MySqlDbType.VarChar,300),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@JamUrl", MySqlDbType.VarChar,200)};
			parameters[0].Value = model.DeliverId;
			parameters[1].Value = model.JamTime;
			parameters[2].Value = model.JamLocation;
			parameters[3].Value = model.Longitude;
			parameters[4].Value = model.Latitude;
			parameters[5].Value = model.JamUrl;

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
		public bool Update(YueYePlat.Model.vehiclejam model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update vehiclejam set ");
			strSql.Append("DeliverId=@DeliverId,");
			strSql.Append("JamTime=@JamTime,");
			strSql.Append("JamLocation=@JamLocation,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Latitude=@Latitude,");
			strSql.Append("JamUrl=@JamUrl");
			strSql.Append(" where JamId=@JamId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliverId", MySqlDbType.VarChar,16),
					new MySqlParameter("@JamTime", MySqlDbType.DateTime),
					new MySqlParameter("@JamLocation", MySqlDbType.VarChar,300),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@JamUrl", MySqlDbType.VarChar,200),
					new MySqlParameter("@JamId", MySqlDbType.Int64,20)};
			parameters[0].Value = model.DeliverId;
			parameters[1].Value = model.JamTime;
			parameters[2].Value = model.JamLocation;
			parameters[3].Value = model.Longitude;
			parameters[4].Value = model.Latitude;
			parameters[5].Value = model.JamUrl;
			parameters[6].Value = model.JamId;

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
		public bool Delete(long JamId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from vehiclejam ");
			strSql.Append(" where JamId=@JamId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@JamId", MySqlDbType.Int64)
			};
			parameters[0].Value = JamId;

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
		public bool DeleteList(string JamIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from vehiclejam ");
			strSql.Append(" where JamId in ("+JamIdlist + ")  ");
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
		public YueYePlat.Model.vehiclejam GetModel(long JamId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select JamId,DeliverId,JamTime,JamLocation,Longitude,Latitude,JamUrl from vehiclejam ");
			strSql.Append(" where JamId=@JamId");
			MySqlParameter[] parameters = {
					new MySqlParameter("@JamId", MySqlDbType.Int64)
			};
			parameters[0].Value = JamId;

			YueYePlat.Model.vehiclejam model=new YueYePlat.Model.vehiclejam();
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
		public YueYePlat.Model.vehiclejam DataRowToModel(DataRow row)
		{
			YueYePlat.Model.vehiclejam model=new YueYePlat.Model.vehiclejam();
			if (row != null)
			{
				if(row["JamId"]!=null && row["JamId"].ToString()!="")
				{
					model.JamId=long.Parse(row["JamId"].ToString());
				}
				if(row["DeliverId"]!=null)
				{
					model.DeliverId=row["DeliverId"].ToString();
				}
				if(row["JamTime"]!=null && row["JamTime"].ToString()!="")
				{
					model.JamTime=DateTime.Parse(row["JamTime"].ToString());
				}
				if(row["JamLocation"]!=null)
				{
					model.JamLocation=row["JamLocation"].ToString();
				}
				if(row["Longitude"]!=null&& row["Longitude"].ToString()!="")
				{
                    model.Longitude = double.Parse ( row["Longitude"].ToString());
				}
				if(row["Latitude"]!=null&&row["Latitude"].ToString()!="")
				{
					model.Latitude=double.Parse ( row["Latitude"].ToString());
				}
					//model.Longitude=row["Longitude"].ToString();
					//model.Latitude=row["Latitude"].ToString();
				if(row["JamUrl"]!=null)
				{
					model.JamUrl=row["JamUrl"].ToString();
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
			strSql.Append("select JamId,DeliverId,JamTime,JamLocation,Longitude,Latitude,JamUrl ");
			strSql.Append(" FROM vehiclejam ");
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
			strSql.Append("select count(1) FROM vehiclejam ");
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
				strSql.Append("order by T.JamId desc");
			}
			strSql.Append(")AS Row, T.*  from vehiclejam T ");
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
			parameters[0].Value = "vehiclejam";
			parameters[1].Value = "JamId";
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


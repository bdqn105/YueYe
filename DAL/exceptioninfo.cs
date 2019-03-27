using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:exceptioninfo
	/// </summary>
	public partial class exceptioninfo
	{
		public exceptioninfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "exceptioninfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from exceptioninfo");
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
		public bool Add(YueYePlat.Model.exceptioninfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into exceptioninfo(");
			strSql.Append("DeliverId,ExceptionType,Exceptiondescribe,ExceptionDispose,Sender,SendTime,Conductor,DisposeTime,Longitude,Latitude)");
			strSql.Append(" values (");
			strSql.Append("@DeliverId,@ExceptionType,@Exceptiondescribe,@ExceptionDispose,@Sender,@SendTime,@Conductor,@DisposeTime,@Longitude,@Latitude)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliverId", MySqlDbType.VarChar,16),
					new MySqlParameter("@ExceptionType", MySqlDbType.VarChar,50),
					new MySqlParameter("@Exceptiondescribe", MySqlDbType.VarChar,500),
					new MySqlParameter("@ExceptionDispose", MySqlDbType.VarChar,500),
					new MySqlParameter("@Sender", MySqlDbType.VarChar,30),
					new MySqlParameter("@SendTime", MySqlDbType.DateTime),
					new MySqlParameter("@Conductor", MySqlDbType.VarChar,50),
					new MySqlParameter("@DisposeTime", MySqlDbType.DateTime),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double)};
			parameters[0].Value = model.DeliverId;
			parameters[1].Value = model.ExceptionType;
			parameters[2].Value = model.Exceptiondescribe;
			parameters[3].Value = model.ExceptionDispose;
			parameters[4].Value = model.Sender;
			parameters[5].Value = model.SendTime;
			parameters[6].Value = model.Conductor;
			parameters[7].Value = model.DisposeTime;
			parameters[8].Value = model.Longitude;
			parameters[9].Value = model.Latitude;

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
		public bool Update(YueYePlat.Model.exceptioninfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update exceptioninfo set ");
			strSql.Append("DeliverId=@DeliverId,");
			strSql.Append("ExceptionType=@ExceptionType,");
			strSql.Append("Exceptiondescribe=@Exceptiondescribe,");
			strSql.Append("ExceptionDispose=@ExceptionDispose,");
			strSql.Append("Sender=@Sender,");
			strSql.Append("SendTime=@SendTime,");
			strSql.Append("Conductor=@Conductor,");
			strSql.Append("DisposeTime=@DisposeTime,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Latitude=@Latitude");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliverId", MySqlDbType.VarChar,16),
					new MySqlParameter("@ExceptionType", MySqlDbType.VarChar,50),
					new MySqlParameter("@Exceptiondescribe", MySqlDbType.VarChar,500),
					new MySqlParameter("@ExceptionDispose", MySqlDbType.VarChar,500),
					new MySqlParameter("@Sender", MySqlDbType.VarChar,30),
					new MySqlParameter("@SendTime", MySqlDbType.DateTime),
					new MySqlParameter("@Conductor", MySqlDbType.VarChar,50),
					new MySqlParameter("@DisposeTime", MySqlDbType.DateTime),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DeliverId;
			parameters[1].Value = model.ExceptionType;
			parameters[2].Value = model.Exceptiondescribe;
			parameters[3].Value = model.ExceptionDispose;
			parameters[4].Value = model.Sender;
			parameters[5].Value = model.SendTime;
			parameters[6].Value = model.Conductor;
			parameters[7].Value = model.DisposeTime;
			parameters[8].Value = model.Longitude;
			parameters[9].Value = model.Latitude;
			parameters[10].Value = model.Id;

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
			strSql.Append("delete from exceptioninfo ");
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
			strSql.Append("delete from exceptioninfo ");
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
		public YueYePlat.Model.exceptioninfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliverId,ExceptionType,Exceptiondescribe,ExceptionDispose,Sender,SendTime,Conductor,DisposeTime,Longitude,Latitude from exceptioninfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.exceptioninfo model=new YueYePlat.Model.exceptioninfo();
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
		public YueYePlat.Model.exceptioninfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.exceptioninfo model=new YueYePlat.Model.exceptioninfo();
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
				if(row["ExceptionType"]!=null)
				{
					model.ExceptionType=row["ExceptionType"].ToString();
				}
				if(row["Exceptiondescribe"]!=null)
				{
					model.Exceptiondescribe=row["Exceptiondescribe"].ToString();
				}
				if(row["ExceptionDispose"]!=null)
				{
					model.ExceptionDispose=row["ExceptionDispose"].ToString();
				}
				if(row["Sender"]!=null)
				{
					model.Sender=row["Sender"].ToString();
				}
				if(row["SendTime"]!=null && row["SendTime"].ToString()!="")
				{
					model.SendTime=DateTime.Parse(row["SendTime"].ToString());
				}
				if(row["Conductor"]!=null)
				{
					model.Conductor=row["Conductor"].ToString();
				}
				if(row["DisposeTime"]!=null && row["DisposeTime"].ToString()!="")
				{
					model.DisposeTime=DateTime.Parse(row["DisposeTime"].ToString());
				}
				if(row["Longitude"]!=null&& row["Longitude"].ToString()!="")
				{
					model.Longitude=double.Parse ( row["Longitude"].ToString());
				}
				if(row["Latitude"]!=null&&row["Latitude"].ToString()!="")
				{
					model.Latitude=double.Parse ( row["Latitude"].ToString());
				}
					//model.Longitude=row["Longitude"].ToString();
					//model.Latitude=row["Latitude"].ToString();
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliverId,ExceptionType,Exceptiondescribe,ExceptionDispose,Sender,SendTime,Conductor,DisposeTime,Longitude,Latitude ");
			strSql.Append(" FROM exceptioninfo ");
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
			strSql.Append("select count(1) FROM exceptioninfo ");
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
			strSql.Append(")AS Row, T.*  from exceptioninfo T ");
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
			parameters[0].Value = "exceptioninfo";
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


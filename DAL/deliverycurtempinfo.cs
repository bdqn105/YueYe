using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:deliverycurtempinfo
	/// </summary>
	public partial class deliverycurtempinfo
	{
		public deliverycurtempinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from deliverycurtempinfo");
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
		public bool Add(YueYePlat.Model.deliverycurtempinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into deliverycurtempinfo(");
			strSql.Append("DeliveryId,Temperature1,Humidity1,Temperature2,Humidity2,Temperature3,Humidity3,CurrentTime)");
			strSql.Append(" values (");
			strSql.Append("@DeliveryId,@Temperature1,@Humidity1,@Temperature2,@Humidity2,@Temperature3,@Humidity3,@CurrentTime)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Temperature1", MySqlDbType.Double),
					new MySqlParameter("@Humidity1", MySqlDbType.Double),
					new MySqlParameter("@Temperature2", MySqlDbType.Double),
					new MySqlParameter("@Humidity2", MySqlDbType.Double),
					new MySqlParameter("@Temperature3", MySqlDbType.Double),
					new MySqlParameter("@Humidity3", MySqlDbType.Double),
					new MySqlParameter("@CurrentTime", MySqlDbType.DateTime)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.Temperature1;
			parameters[2].Value = model.Humidity1;
			parameters[3].Value = model.Temperature2;
			parameters[4].Value = model.Humidity2;
			parameters[5].Value = model.Temperature3;
			parameters[6].Value = model.Humidity3;
			parameters[7].Value = model.CurrentTime;

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
		public bool Update(YueYePlat.Model.deliverycurtempinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update deliverycurtempinfo set ");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("Temperature1=@Temperature1,");
			strSql.Append("Humidity1=@Humidity1,");
			strSql.Append("Temperature2=@Temperature2,");
			strSql.Append("Humidity2=@Humidity2,");
			strSql.Append("Temperature3=@Temperature3,");
			strSql.Append("Humidity3=@Humidity3,");
			strSql.Append("CurrentTime=@CurrentTime");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Temperature1", MySqlDbType.Double),
					new MySqlParameter("@Humidity1", MySqlDbType.Double),
					new MySqlParameter("@Temperature2", MySqlDbType.Double),
					new MySqlParameter("@Humidity2", MySqlDbType.Double),
					new MySqlParameter("@Temperature3", MySqlDbType.Double),
					new MySqlParameter("@Humidity3", MySqlDbType.Double),
					new MySqlParameter("@CurrentTime", MySqlDbType.DateTime),
					new MySqlParameter("@Id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.Temperature1;
			parameters[2].Value = model.Humidity1;
			parameters[3].Value = model.Temperature2;
			parameters[4].Value = model.Humidity2;
			parameters[5].Value = model.Temperature3;
			parameters[6].Value = model.Humidity3;
			parameters[7].Value = model.CurrentTime;
			parameters[8].Value = model.Id;

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
			strSql.Append("delete from deliverycurtempinfo ");
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
			strSql.Append("delete from deliverycurtempinfo ");
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
		public YueYePlat.Model.deliverycurtempinfo GetModel(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliveryId,Temperature1,Humidity1,Temperature2,Humidity2,Temperature3,Humidity3,CurrentTime from deliverycurtempinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int64)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.deliverycurtempinfo model=new YueYePlat.Model.deliverycurtempinfo();
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
		public YueYePlat.Model.deliverycurtempinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.deliverycurtempinfo model=new YueYePlat.Model.deliverycurtempinfo();
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
                if (row["Temperature1"] != null && row["Temperature1"].ToString() != "")
                {
                    model.Temperature1 = Double.Parse(row["Temperature1"].ToString());
                }
                if (row["Temperature2"] != null && row["Temperature2"].ToString() != "")
                {
                    model.Temperature2 = Double.Parse(row["Temperature2"].ToString());
                }
                if (row["Temperature3"] != null && row["Temperature3"].ToString() != "")
                {
                    model.Temperature3 = Double.Parse(row["Temperature3"].ToString());
                }
                if (row["Humidity1"] != null && row["Humidity1"].ToString() != "")
                {
                    model.Humidity1 = Double.Parse(row["Humidity1"].ToString());
                }
                if (row["Humidity2"] != null && row["Humidity2"].ToString() != "")
                {
                    model.Humidity2 = Double.Parse(row["Humidity2"].ToString());
                }
                if (row["Humidity3"] != null && row["Humidity3"].ToString() != "")
                {
                    model.Humidity3 = Double.Parse(row["Humidity3"].ToString());
                }
					//model.Temperature1=row["Temperature1"].ToString();
					//model.Humidity1=row["Humidity1"].ToString();
					//model.Temperature2=row["Temperature2"].ToString();
					//model.Humidity2=row["Humidity2"].ToString();
					//model.Temperature3=row["Temperature3"].ToString();
					//model.Humidity3=row["Humidity3"].ToString();
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
			strSql.Append("select Id,DeliveryId,Temperature1,Humidity1,Temperature2,Humidity2,Temperature3,Humidity3,CurrentTime ");
			strSql.Append(" FROM deliverycurtempinfo ");
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
			strSql.Append("select count(1) FROM deliverycurtempinfo ");
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
			strSql.Append(")AS Row, T.*  from deliverycurtempinfo T ");
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
			parameters[0].Value = "deliverycurtempinfo";
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


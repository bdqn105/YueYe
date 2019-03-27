using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:vehicleupkeep
	/// </summary>
	public partial class vehicleupkeep
	{
		public vehicleupkeep()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "vehicleupkeep"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from vehicleupkeep");
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
		public bool Add(YueYePlat.Model.vehicleupkeep model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into vehicleupkeep(");
			strSql.Append("VehicleId,Kilometres,UpkeepDescribe,UpkeepMoneys,UpkeepTime,UpkeepMan,UpkeepLocation,InvoicePhoto)");
			strSql.Append(" values (");
			strSql.Append("@VehicleId,@Kilometres,@UpkeepDescribe,@UpkeepMoneys,@UpkeepTime,@UpkeepMan,@UpkeepLocation,@InvoicePhoto)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@VehicleId", MySqlDbType.VarChar,12),
					new MySqlParameter("@Kilometres", MySqlDbType.VarChar,50),
					new MySqlParameter("@UpkeepDescribe", MySqlDbType.VarChar,300),
					new MySqlParameter("@UpkeepMoneys", MySqlDbType.VarChar,50),
					new MySqlParameter("@UpkeepTime", MySqlDbType.DateTime),
					new MySqlParameter("@UpkeepMan", MySqlDbType.VarChar,50),
					new MySqlParameter("@UpkeepLocation", MySqlDbType.VarChar,50),
					new MySqlParameter("@InvoicePhoto", MySqlDbType.VarChar,300)};
			parameters[0].Value = model.VehicleId;
			parameters[1].Value = model.Kilometres;
			parameters[2].Value = model.UpkeepDescribe;
			parameters[3].Value = model.UpkeepMoneys;
			parameters[4].Value = model.UpkeepTime;
			parameters[5].Value = model.UpkeepMan;
			parameters[6].Value = model.UpkeepLocation;
			parameters[7].Value = model.InvoicePhoto;

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
		public bool Update(YueYePlat.Model.vehicleupkeep model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update vehicleupkeep set ");
			strSql.Append("VehicleId=@VehicleId,");
			strSql.Append("Kilometres=@Kilometres,");
			strSql.Append("UpkeepDescribe=@UpkeepDescribe,");
			strSql.Append("UpkeepMoneys=@UpkeepMoneys,");
			strSql.Append("UpkeepTime=@UpkeepTime,");
			strSql.Append("UpkeepMan=@UpkeepMan,");
			strSql.Append("UpkeepLocation=@UpkeepLocation,");
			strSql.Append("InvoicePhoto=@InvoicePhoto");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@VehicleId", MySqlDbType.VarChar,12),
					new MySqlParameter("@Kilometres", MySqlDbType.VarChar,50),
					new MySqlParameter("@UpkeepDescribe", MySqlDbType.VarChar,300),
					new MySqlParameter("@UpkeepMoneys", MySqlDbType.VarChar,50),
					new MySqlParameter("@UpkeepTime", MySqlDbType.DateTime),
					new MySqlParameter("@UpkeepMan", MySqlDbType.VarChar,50),
					new MySqlParameter("@UpkeepLocation", MySqlDbType.VarChar,50),
					new MySqlParameter("@InvoicePhoto", MySqlDbType.VarChar,300),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.VehicleId;
			parameters[1].Value = model.Kilometres;
			parameters[2].Value = model.UpkeepDescribe;
			parameters[3].Value = model.UpkeepMoneys;
			parameters[4].Value = model.UpkeepTime;
			parameters[5].Value = model.UpkeepMan;
			parameters[6].Value = model.UpkeepLocation;
			parameters[7].Value = model.InvoicePhoto;
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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from vehicleupkeep ");
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
			strSql.Append("delete from vehicleupkeep ");
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
		public YueYePlat.Model.vehicleupkeep GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,VehicleId,Kilometres,UpkeepDescribe,UpkeepMoneys,UpkeepTime,UpkeepMan,UpkeepLocation,InvoicePhoto from vehicleupkeep ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.vehicleupkeep model=new YueYePlat.Model.vehicleupkeep();
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
		public YueYePlat.Model.vehicleupkeep DataRowToModel(DataRow row)
		{
			YueYePlat.Model.vehicleupkeep model=new YueYePlat.Model.vehicleupkeep();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["VehicleId"]!=null)
				{
					model.VehicleId=row["VehicleId"].ToString();
				}
				if(row["Kilometres"]!=null)
				{
					model.Kilometres=row["Kilometres"].ToString();
				}
				if(row["UpkeepDescribe"]!=null)
				{
					model.UpkeepDescribe=row["UpkeepDescribe"].ToString();
				}
				if(row["UpkeepMoneys"]!=null)
				{
					model.UpkeepMoneys=row["UpkeepMoneys"].ToString();
				}
				if(row["UpkeepTime"]!=null && row["UpkeepTime"].ToString()!="")
				{
					model.UpkeepTime=DateTime.Parse(row["UpkeepTime"].ToString());
				}
				if(row["UpkeepMan"]!=null)
				{
					model.UpkeepMan=row["UpkeepMan"].ToString();
				}
				if(row["UpkeepLocation"]!=null)
				{
					model.UpkeepLocation=row["UpkeepLocation"].ToString();
				}
				if(row["InvoicePhoto"]!=null)
				{
					model.InvoicePhoto=row["InvoicePhoto"].ToString();
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
			strSql.Append("select Id,VehicleId,Kilometres,UpkeepDescribe,UpkeepMoneys,UpkeepTime,UpkeepMan,UpkeepLocation,InvoicePhoto ");
			strSql.Append(" FROM vehicleupkeep ");
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
			strSql.Append("select count(1) FROM vehicleupkeep ");
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
			strSql.Append(")AS Row, T.*  from vehicleupkeep T ");
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
			parameters[0].Value = "vehicleupkeep";
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


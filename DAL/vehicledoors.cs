using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:vehicledoors
	/// </summary>
	public partial class vehicledoors
	{
		public vehicledoors()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "vehicledoors"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from vehicledoors");
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
		public bool Add(YueYePlat.Model.vehicledoors model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into vehicledoors(");
			strSql.Append("DeliveryId,Longitude,Latitude,OpenClose,DoorTime,DoorPhoto)");
			strSql.Append(" values (");
			strSql.Append("@DeliveryId,@Longitude,@Latitude,@OpenClose,@DoorTime,@DoorPhoto)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@OpenClose", MySqlDbType.Bit),
					new MySqlParameter("@DoorTime", MySqlDbType.DateTime),
					new MySqlParameter("@DoorPhoto", MySqlDbType.VarChar,100)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.Longitude;
			parameters[2].Value = model.Latitude;
			parameters[3].Value = model.OpenClose;
			parameters[4].Value = model.DoorTime;
			parameters[5].Value = model.DoorPhoto;

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
		public bool Update(YueYePlat.Model.vehicledoors model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update vehicledoors set ");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Latitude=@Latitude,");
			strSql.Append("OpenClose=@OpenClose,");
			strSql.Append("DoorTime=@DoorTime,");
			strSql.Append("DoorPhoto=@DoorPhoto");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@OpenClose", MySqlDbType.Bit),
					new MySqlParameter("@DoorTime", MySqlDbType.DateTime),
					new MySqlParameter("@DoorPhoto", MySqlDbType.VarChar,100),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.Longitude;
			parameters[2].Value = model.Latitude;
			parameters[3].Value = model.OpenClose;
			parameters[4].Value = model.DoorTime;
			parameters[5].Value = model.DoorPhoto;
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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from vehicledoors ");
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
			strSql.Append("delete from vehicledoors ");
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
		public YueYePlat.Model.vehicledoors GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliveryId,Longitude,Latitude,OpenClose,DoorTime,DoorPhoto from vehicledoors ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.vehicledoors model=new YueYePlat.Model.vehicledoors();
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
		public YueYePlat.Model.vehicledoors DataRowToModel(DataRow row)
		{
			YueYePlat.Model.vehicledoors model=new YueYePlat.Model.vehicledoors();
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
                if (row["Longitude"] != null && row["Longitude"].ToString() != "")
                {
                    model.Longitude = Double.Parse(row["Longitude"].ToString());
                }
                if (row["Latitude"] != null && row["Latitude"].ToString() != "")
                {
                    model.Latitude = Double.Parse(row["Latitude"].ToString());
                }                
                if (row["OpenClose"]!=null && row["OpenClose"].ToString()!="")
				{
					if((row["OpenClose"].ToString()=="1")||(row["OpenClose"].ToString().ToLower()=="true"))
					{
						model.OpenClose=true;
					}
					else
					{
						model.OpenClose=false;
					}
				}
				if(row["DoorTime"]!=null && row["DoorTime"].ToString()!="")
				{
					model.DoorTime=DateTime.Parse(row["DoorTime"].ToString());
				}
				if(row["DoorPhoto"]!=null)
				{
					model.DoorPhoto=row["DoorPhoto"].ToString();
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
			strSql.Append("select Id,DeliveryId,Longitude,Latitude,OpenClose,DoorTime,DoorPhoto ");
			strSql.Append(" FROM vehicledoors ");
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
			strSql.Append("select count(1) FROM vehicledoors ");
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
			strSql.Append(")AS Row, T.*  from vehicledoors T ");
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
			parameters[0].Value = "vehicledoors";
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


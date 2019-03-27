using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:refueling
	/// </summary>
	public partial class refueling
	{
		public refueling()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "refueling"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from refueling");
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
		public bool Add(YueYePlat.Model.refueling model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into refueling(");
			strSql.Append("VehicleID,DeliveryId,Longitude,Latitude,PetrolStation,Money,Quantity,RefuelTime,InvoicePhoto,DriverId,IfVerifyed,VerfielId)");
			strSql.Append(" values (");
			strSql.Append("@VehicleID,@DeliveryId,@Longitude,@Latitude,@PetrolStation,@Money,@Quantity,@RefuelTime,@InvoicePhoto,@DriverId,@IfVerifyed,@VerfielId)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@VehicleID", MySqlDbType.VarChar,12),
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@PetrolStation", MySqlDbType.VarChar,50),
					new MySqlParameter("@Money", MySqlDbType.Decimal,10),
					new MySqlParameter("@Quantity", MySqlDbType.Decimal,10),
					new MySqlParameter("@RefuelTime", MySqlDbType.DateTime),
					new MySqlParameter("@InvoicePhoto", MySqlDbType.VarChar,100),
					new MySqlParameter("@DriverId", MySqlDbType.VarChar,50),
					new MySqlParameter("@IfVerifyed", MySqlDbType.Bit),
					new MySqlParameter("@VerfielId", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.VehicleID;
			parameters[1].Value = model.DeliveryId;
			parameters[2].Value = model.Longitude;
			parameters[3].Value = model.Latitude;
			parameters[4].Value = model.PetrolStation;
			parameters[5].Value = model.Money;
			parameters[6].Value = model.Quantity;
			parameters[7].Value = model.RefuelTime;
			parameters[8].Value = model.InvoicePhoto;
			parameters[9].Value = model.DriverId;
			parameters[10].Value = model.IfVerifyed;
			parameters[11].Value = model.VerfielId;

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
		public bool Update(YueYePlat.Model.refueling model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update refueling set ");
			strSql.Append("VehicleID=@VehicleID,");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Latitude=@Latitude,");
			strSql.Append("PetrolStation=@PetrolStation,");
			strSql.Append("Money=@Money,");
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("RefuelTime=@RefuelTime,");
			strSql.Append("InvoicePhoto=@InvoicePhoto,");
			strSql.Append("DriverId=@DriverId,");
			strSql.Append("IfVerifyed=@IfVerifyed,");
			strSql.Append("VerfielId=@VerfielId");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@VehicleID", MySqlDbType.VarChar,12),
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,16),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@PetrolStation", MySqlDbType.VarChar,50),
					new MySqlParameter("@Money", MySqlDbType.Decimal,10),
					new MySqlParameter("@Quantity", MySqlDbType.Decimal,10),
					new MySqlParameter("@RefuelTime", MySqlDbType.DateTime),
					new MySqlParameter("@InvoicePhoto", MySqlDbType.VarChar,100),
					new MySqlParameter("@DriverId", MySqlDbType.VarChar,50),
					new MySqlParameter("@IfVerifyed", MySqlDbType.Bit),
					new MySqlParameter("@VerfielId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.VehicleID;
			parameters[1].Value = model.DeliveryId;
			parameters[2].Value = model.Longitude;
			parameters[3].Value = model.Latitude;
			parameters[4].Value = model.PetrolStation;
			parameters[5].Value = model.Money;
			parameters[6].Value = model.Quantity;
			parameters[7].Value = model.RefuelTime;
			parameters[8].Value = model.InvoicePhoto;
			parameters[9].Value = model.DriverId;
			parameters[10].Value = model.IfVerifyed;
			parameters[11].Value = model.VerfielId;
			parameters[12].Value = model.Id;

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
			strSql.Append("delete from refueling ");
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
			strSql.Append("delete from refueling ");
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
		public YueYePlat.Model.refueling GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,VehicleID,DeliveryId,Longitude,Latitude,PetrolStation,Money,Quantity,RefuelTime,InvoicePhoto,DriverId,IfVerifyed,VerfielId from refueling ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.refueling model=new YueYePlat.Model.refueling();
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
		public YueYePlat.Model.refueling DataRowToModel(DataRow row)
		{
			YueYePlat.Model.refueling model=new YueYePlat.Model.refueling();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["VehicleID"]!=null)
				{
					model.VehicleID=row["VehicleID"].ToString();
				}
				if(row["DeliveryId"]!=null)
				{
					model.DeliveryId=row["DeliveryId"].ToString();
				}
                if (row["Longitude"] != null)
                {
                    model.Longitude = double.Parse ( row["Longitude"].ToString());
                }
                if (row["Latitude"] != null)
                {
                    model.Latitude = double.Parse(row["Latitude"].ToString());
                }
					//model.Longitude=row["Longitude"].ToString();
					//model.Latitude=row["Latitude"].ToString();
				if(row["PetrolStation"]!=null)
				{
					model.PetrolStation=row["PetrolStation"].ToString();
				}
				if(row["Money"]!=null && row["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(row["Money"].ToString());
				}
				if(row["Quantity"]!=null && row["Quantity"].ToString()!="")
				{
					model.Quantity=decimal.Parse(row["Quantity"].ToString());
				}
				if(row["RefuelTime"]!=null && row["RefuelTime"].ToString()!="")
				{
					model.RefuelTime=DateTime.Parse(row["RefuelTime"].ToString());
				}
				if(row["InvoicePhoto"]!=null)
				{
					model.InvoicePhoto=row["InvoicePhoto"].ToString();
				}
				if(row["DriverId"]!=null)
				{
					model.DriverId=row["DriverId"].ToString();
				}
				if(row["IfVerifyed"]!=null && row["IfVerifyed"].ToString()!="")
				{
					if((row["IfVerifyed"].ToString()=="1")||(row["IfVerifyed"].ToString().ToLower()=="true"))
					{
						model.IfVerifyed=true;
					}
					else
					{
						model.IfVerifyed=false;
					}
				}
				if(row["VerfielId"]!=null)
				{
					model.VerfielId=row["VerfielId"].ToString();
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
			strSql.Append("select Id,VehicleID,DeliveryId,Longitude,Latitude,PetrolStation,Money,Quantity,RefuelTime,InvoicePhoto,DriverId,IfVerifyed,VerfielId ");
			strSql.Append(" FROM refueling ");
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
			strSql.Append("select count(1) FROM refueling ");
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
			strSql.Append(")AS Row, T.*  from refueling T ");
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
			parameters[0].Value = "refueling";
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


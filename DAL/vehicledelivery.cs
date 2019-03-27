using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:vehicledelivery
	/// </summary>
	public partial class vehicledelivery
	{
		public vehicledelivery()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "vehicledelivery"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from vehicledelivery");
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
		public bool Add(YueYePlat.Model.vehicledelivery model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into vehicledelivery(");
			strSql.Append("DeliveryId,DeviceId,VehicleId,Driver1Id,Driver2Id,Origin,BeginTime,MinTempThreshold,MaxTempThreshold,MinHumThreshold,MaxHumThreshold,IfEnd,RecordId,Auditor,IfChargeback)");
			strSql.Append(" values (");
			strSql.Append("@DeliveryId,@DeviceId,@VehicleId,@Driver1Id,@Driver2Id,@Origin,@BeginTime,@MinTempThreshold,@MaxTempThreshold,@MinHumThreshold,@MaxHumThreshold,@IfEnd,@RecordId,@Auditor,@IfChargeback)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeviceId", MySqlDbType.VarChar,14),
					new MySqlParameter("@VehicleId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Driver1Id", MySqlDbType.VarChar,50),
					new MySqlParameter("@Driver2Id", MySqlDbType.VarChar,50),
					new MySqlParameter("@Origin", MySqlDbType.VarChar,50),
					new MySqlParameter("@BeginTime", MySqlDbType.DateTime),
					new MySqlParameter("@MinTempThreshold", MySqlDbType.Double),
					new MySqlParameter("@MaxTempThreshold", MySqlDbType.Double),
					new MySqlParameter("@MinHumThreshold", MySqlDbType.Double),
					new MySqlParameter("@MaxHumThreshold", MySqlDbType.Double),
					new MySqlParameter("@IfEnd", MySqlDbType.Bit),
					new MySqlParameter("@RecordId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Auditor", MySqlDbType.VarChar,50),
					new MySqlParameter("@IfChargeback", MySqlDbType.Bit)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.DeviceId;
			parameters[2].Value = model.VehicleId;
			parameters[3].Value = model.Driver1Id;
			parameters[4].Value = model.Driver2Id;
			parameters[5].Value = model.Origin;
			parameters[6].Value = model.BeginTime;
			parameters[7].Value = model.MinTempThreshold;
			parameters[8].Value = model.MaxTempThreshold;
			parameters[9].Value = model.MinHumThreshold;
			parameters[10].Value = model.MaxHumThreshold;
			parameters[11].Value = model.IfEnd;
			parameters[12].Value = model.RecordId;
			parameters[13].Value = model.Auditor;
			parameters[14].Value = model.IfChargeback;

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
		public bool Update(YueYePlat.Model.vehicledelivery model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update vehicledelivery set ");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("DeviceId=@DeviceId,");
			strSql.Append("VehicleId=@VehicleId,");
			strSql.Append("Driver1Id=@Driver1Id,");
			strSql.Append("Driver2Id=@Driver2Id,");
			strSql.Append("Origin=@Origin,");
			strSql.Append("BeginTime=@BeginTime,");
			strSql.Append("MinTempThreshold=@MinTempThreshold,");
			strSql.Append("MaxTempThreshold=@MaxTempThreshold,");
			strSql.Append("MinHumThreshold=@MinHumThreshold,");
			strSql.Append("MaxHumThreshold=@MaxHumThreshold,");
			strSql.Append("IfEnd=@IfEnd,");
			strSql.Append("RecordId=@RecordId,");
			strSql.Append("Auditor=@Auditor,");
			strSql.Append("IfChargeback=@IfChargeback");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeviceId", MySqlDbType.VarChar,14),
					new MySqlParameter("@VehicleId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Driver1Id", MySqlDbType.VarChar,50),
					new MySqlParameter("@Driver2Id", MySqlDbType.VarChar,50),
					new MySqlParameter("@Origin", MySqlDbType.VarChar,50),
					new MySqlParameter("@BeginTime", MySqlDbType.DateTime),
					new MySqlParameter("@MinTempThreshold", MySqlDbType.Double),
					new MySqlParameter("@MaxTempThreshold", MySqlDbType.Double),
					new MySqlParameter("@MinHumThreshold", MySqlDbType.Double),
					new MySqlParameter("@MaxHumThreshold", MySqlDbType.Double),
					new MySqlParameter("@IfEnd", MySqlDbType.Bit),
					new MySqlParameter("@RecordId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Auditor", MySqlDbType.VarChar,50),
					new MySqlParameter("@IfChargeback", MySqlDbType.Bit),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DeliveryId;
			parameters[1].Value = model.DeviceId;
			parameters[2].Value = model.VehicleId;
			parameters[3].Value = model.Driver1Id;
			parameters[4].Value = model.Driver2Id;
			parameters[5].Value = model.Origin;
			parameters[6].Value = model.BeginTime;
			parameters[7].Value = model.MinTempThreshold;
			parameters[8].Value = model.MaxTempThreshold;
			parameters[9].Value = model.MinHumThreshold;
			parameters[10].Value = model.MaxHumThreshold;
			parameters[11].Value = model.IfEnd;
			parameters[12].Value = model.RecordId;
			parameters[13].Value = model.Auditor;
			parameters[14].Value = model.IfChargeback;
			parameters[15].Value = model.Id;

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
			strSql.Append("delete from vehicledelivery ");
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
			strSql.Append("delete from vehicledelivery ");
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
		public YueYePlat.Model.vehicledelivery GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliveryId,DeviceId,VehicleId,Driver1Id,Driver2Id,Origin,BeginTime,MinTempThreshold,MaxTempThreshold,MinHumThreshold,MaxHumThreshold,IfEnd,RecordId,Auditor,IfChargeback from vehicledelivery ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.vehicledelivery model=new YueYePlat.Model.vehicledelivery();
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
		public YueYePlat.Model.vehicledelivery DataRowToModel(DataRow row)
		{
			YueYePlat.Model.vehicledelivery model=new YueYePlat.Model.vehicledelivery();
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
				if(row["DeviceId"]!=null)
				{
					model.DeviceId=row["DeviceId"].ToString();
				}
				if(row["VehicleId"]!=null)
				{
					model.VehicleId=row["VehicleId"].ToString();
				}
				if(row["Driver1Id"]!=null)
				{
					model.Driver1Id=row["Driver1Id"].ToString();
				}
				if(row["Driver2Id"]!=null)
				{
					model.Driver2Id=row["Driver2Id"].ToString();
				}
				if(row["Origin"]!=null)
				{
					model.Origin=row["Origin"].ToString();
				}
				if(row["BeginTime"]!=null && row["BeginTime"].ToString()!="")
				{
					model.BeginTime=DateTime.Parse(row["BeginTime"].ToString());
				}
				if (row["MinTempThreshold"] != null && row["MinTempThreshold"].ToString() != "")
                {
                    model.MinTempThreshold = Double.Parse(row["MinTempThreshold"].ToString());
                }
                if (row["MaxTempThreshold"] != null && row["MaxTempThreshold"].ToString() != "")
                {
                    model.MaxTempThreshold = Double.Parse(row["MaxTempThreshold"].ToString());
                }
                if (row["MinHumThreshold"] != null && row["MinHumThreshold"].ToString() != "")
                {
                    model.MinHumThreshold = Double.Parse(row["MinHumThreshold"].ToString());
                }
                if (row["MaxHumThreshold"] != null && row["MaxHumThreshold"].ToString() != "")
                {
                    model.MaxHumThreshold = Double.Parse(row["MaxHumThreshold"].ToString());
                }
					//model.MinTempThreshold=row["MinTempThreshold"].ToString();
					//model.MaxTempThreshold=row["MaxTempThreshold"].ToString();
					//model.MinHumThreshold=row["MinHumThreshold"].ToString();
					//model.MaxHumThreshold=row["MaxHumThreshold"].ToString();
				if(row["IfEnd"]!=null && row["IfEnd"].ToString()!="")
				{
					if((row["IfEnd"].ToString()=="1")||(row["IfEnd"].ToString().ToLower()=="true"))
					{
						model.IfEnd=true;
					}
					else
					{
						model.IfEnd=false;
					}
				}
				if(row["RecordId"]!=null)
				{
					model.RecordId=row["RecordId"].ToString();
				}
				if(row["Auditor"]!=null)
				{
					model.Auditor=row["Auditor"].ToString();
				}
				if(row["IfChargeback"]!=null && row["IfChargeback"].ToString()!="")
				{
					if((row["IfChargeback"].ToString()=="1")||(row["IfChargeback"].ToString().ToLower()=="true"))
					{
						model.IfChargeback=true;
					}
					else
					{
						model.IfChargeback=false;
					}
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
			strSql.Append("select Id,DeliveryId,DeviceId,VehicleId,Driver1Id,Driver2Id,Origin,BeginTime,MinTempThreshold,MaxTempThreshold,MinHumThreshold,MaxHumThreshold,IfEnd,RecordId,Auditor,IfChargeback ");
			strSql.Append(" FROM vehicledelivery ");
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
			strSql.Append("select count(1) FROM vehicledelivery ");
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
			strSql.Append(")AS Row, T.*  from vehicledelivery T ");
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
			parameters[0].Value = "vehicledelivery";
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


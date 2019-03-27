using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:vehicleinfo
	/// </summary>
	public partial class vehicleinfo
	{
		public vehicleinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "vehicleinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from vehicleinfo");
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
		public bool Add(YueYePlat.Model.vehicleinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into vehicleinfo(");
			strSql.Append("VehicleId,VehicleName,VehicleNumber,CompanyId,VehicleType,LoadCapacity,LicensePhoto,VehiclePhoto,IFBelongsto)");
			strSql.Append(" values (");
			strSql.Append("@VehicleId,@VehicleName,@VehicleNumber,@CompanyId,@VehicleType,@LoadCapacity,@LicensePhoto,@VehiclePhoto,@IFBelongsto)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@VehicleId", MySqlDbType.VarChar,12),
					new MySqlParameter("@VehicleName", MySqlDbType.VarChar,50),
					new MySqlParameter("@VehicleNumber", MySqlDbType.VarChar,20),
					new MySqlParameter("@CompanyId", MySqlDbType.VarChar,50),
					new MySqlParameter("@VehicleType", MySqlDbType.VarChar,50),
					new MySqlParameter("@LoadCapacity", MySqlDbType.VarChar,20),
					new MySqlParameter("@LicensePhoto", MySqlDbType.VarChar,300),
					new MySqlParameter("@VehiclePhoto", MySqlDbType.VarChar,300),
					new MySqlParameter("@IFBelongsto", MySqlDbType.Bit)};
			parameters[0].Value = model.VehicleId;
			parameters[1].Value = model.VehicleName;
			parameters[2].Value = model.VehicleNumber;
			parameters[3].Value = model.CompanyId;
			parameters[4].Value = model.VehicleType;
			parameters[5].Value = model.LoadCapacity;
			parameters[6].Value = model.LicensePhoto;
			parameters[7].Value = model.VehiclePhoto;
			parameters[8].Value = model.IFBelongsto;

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
		public bool Update(YueYePlat.Model.vehicleinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update vehicleinfo set ");
			strSql.Append("VehicleId=@VehicleId,");
			strSql.Append("VehicleName=@VehicleName,");
			strSql.Append("VehicleNumber=@VehicleNumber,");
			strSql.Append("CompanyId=@CompanyId,");
			strSql.Append("VehicleType=@VehicleType,");
			strSql.Append("LoadCapacity=@LoadCapacity,");
			strSql.Append("LicensePhoto=@LicensePhoto,");
			strSql.Append("VehiclePhoto=@VehiclePhoto,");
			strSql.Append("IFBelongsto=@IFBelongsto");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@VehicleId", MySqlDbType.VarChar,12),
					new MySqlParameter("@VehicleName", MySqlDbType.VarChar,50),
					new MySqlParameter("@VehicleNumber", MySqlDbType.VarChar,20),
					new MySqlParameter("@CompanyId", MySqlDbType.VarChar,50),
					new MySqlParameter("@VehicleType", MySqlDbType.VarChar,50),
					new MySqlParameter("@LoadCapacity", MySqlDbType.VarChar,20),
					new MySqlParameter("@LicensePhoto", MySqlDbType.VarChar,300),
					new MySqlParameter("@VehiclePhoto", MySqlDbType.VarChar,300),
					new MySqlParameter("@IFBelongsto", MySqlDbType.Bit),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.VehicleId;
			parameters[1].Value = model.VehicleName;
			parameters[2].Value = model.VehicleNumber;
			parameters[3].Value = model.CompanyId;
			parameters[4].Value = model.VehicleType;
			parameters[5].Value = model.LoadCapacity;
			parameters[6].Value = model.LicensePhoto;
			parameters[7].Value = model.VehiclePhoto;
			parameters[8].Value = model.IFBelongsto;
			parameters[9].Value = model.Id;

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
			strSql.Append("delete from vehicleinfo ");
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
			strSql.Append("delete from vehicleinfo ");
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
		public YueYePlat.Model.vehicleinfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,VehicleId,VehicleName,VehicleNumber,CompanyId,VehicleType,LoadCapacity,LicensePhoto,VehiclePhoto,IFBelongsto from vehicleinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.vehicleinfo model=new YueYePlat.Model.vehicleinfo();
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
		public YueYePlat.Model.vehicleinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.vehicleinfo model=new YueYePlat.Model.vehicleinfo();
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
				if(row["VehicleName"]!=null)
				{
					model.VehicleName=row["VehicleName"].ToString();
				}
				if(row["VehicleNumber"]!=null)
				{
					model.VehicleNumber=row["VehicleNumber"].ToString();
				}
				if(row["CompanyId"]!=null)
				{
					model.CompanyId=row["CompanyId"].ToString();
				}
				if(row["VehicleType"]!=null)
				{
					model.VehicleType=row["VehicleType"].ToString();
				}
				if(row["LoadCapacity"]!=null)
				{
					model.LoadCapacity=row["LoadCapacity"].ToString();
				}
				if(row["LicensePhoto"]!=null)
				{
					model.LicensePhoto=row["LicensePhoto"].ToString();
				}
				if(row["VehiclePhoto"]!=null)
				{
					model.VehiclePhoto=row["VehiclePhoto"].ToString();
				}
				if(row["IFBelongsto"]!=null && row["IFBelongsto"].ToString()!="")
				{
					if((row["IFBelongsto"].ToString()=="1")||(row["IFBelongsto"].ToString().ToLower()=="true"))
					{
						model.IFBelongsto=true;
					}
					else
					{
						model.IFBelongsto=false;
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
			strSql.Append("select Id,VehicleId,VehicleName,VehicleNumber,CompanyId,VehicleType,LoadCapacity,LicensePhoto,VehiclePhoto,IFBelongsto ");
			strSql.Append(" FROM vehicleinfo ");
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
			strSql.Append("select count(1) FROM vehicleinfo ");
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
			strSql.Append(")AS Row, T.*  from vehicleinfo T ");
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
			parameters[0].Value = "vehicleinfo";
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


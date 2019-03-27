using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:driverinfo
	/// </summary>
	public partial class driverinfo
	{
		public driverinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "driverinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from driverinfo");
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
		public bool Add(YueYePlat.Model.driverinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into driverinfo(");
			strSql.Append("DriverId,DriverName,DriverSex,FamilyAddress,Mobile,IdNumber,DriverLicense,LicenseType,DriverLocation,EmergencyContact,EmergencyMobile,EmergencyRelations,DriverPhoto,CompanyId,Type)");
			strSql.Append(" values (");
			strSql.Append("@DriverId,@DriverName,@DriverSex,@FamilyAddress,@Mobile,@IdNumber,@DriverLicense,@LicenseType,@DriverLocation,@EmergencyContact,@EmergencyMobile,@EmergencyRelations,@DriverPhoto,@CompanyId,@Type)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DriverId", MySqlDbType.VarChar,10),
					new MySqlParameter("@DriverName", MySqlDbType.VarChar,50),
					new MySqlParameter("@DriverSex", MySqlDbType.VarChar,2),
					new MySqlParameter("@FamilyAddress", MySqlDbType.VarChar,300),
					new MySqlParameter("@Mobile", MySqlDbType.VarChar,20),
					new MySqlParameter("@IdNumber", MySqlDbType.VarChar,30),
					new MySqlParameter("@DriverLicense", MySqlDbType.VarChar,30),
					new MySqlParameter("@LicenseType", MySqlDbType.VarChar,20),
					new MySqlParameter("@DriverLocation", MySqlDbType.VarChar,20),
					new MySqlParameter("@EmergencyContact", MySqlDbType.VarChar,50),
					new MySqlParameter("@EmergencyMobile", MySqlDbType.VarChar,20),
					new MySqlParameter("@EmergencyRelations", MySqlDbType.VarChar,10),
					new MySqlParameter("@DriverPhoto", MySqlDbType.VarChar,300),
					new MySqlParameter("@CompanyId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Type", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.DriverId;
			parameters[1].Value = model.DriverName;
			parameters[2].Value = model.DriverSex;
			parameters[3].Value = model.FamilyAddress;
			parameters[4].Value = model.Mobile;
			parameters[5].Value = model.IdNumber;
			parameters[6].Value = model.DriverLicense;
			parameters[7].Value = model.LicenseType;
			parameters[8].Value = model.DriverLocation;
			parameters[9].Value = model.EmergencyContact;
			parameters[10].Value = model.EmergencyMobile;
			parameters[11].Value = model.EmergencyRelations;
			parameters[12].Value = model.DriverPhoto;
			parameters[13].Value = model.CompanyId;
			parameters[14].Value = model.Type;

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
		public bool Update(YueYePlat.Model.driverinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update driverinfo set ");
			strSql.Append("DriverId=@DriverId,");
			strSql.Append("DriverName=@DriverName,");
			strSql.Append("DriverSex=@DriverSex,");
			strSql.Append("FamilyAddress=@FamilyAddress,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("IdNumber=@IdNumber,");
			strSql.Append("DriverLicense=@DriverLicense,");
			strSql.Append("LicenseType=@LicenseType,");
			strSql.Append("DriverLocation=@DriverLocation,");
			strSql.Append("EmergencyContact=@EmergencyContact,");
			strSql.Append("EmergencyMobile=@EmergencyMobile,");
			strSql.Append("EmergencyRelations=@EmergencyRelations,");
			strSql.Append("DriverPhoto=@DriverPhoto,");
			strSql.Append("CompanyId=@CompanyId,");
			strSql.Append("Type=@Type");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DriverId", MySqlDbType.VarChar,10),
					new MySqlParameter("@DriverName", MySqlDbType.VarChar,50),
					new MySqlParameter("@DriverSex", MySqlDbType.VarChar,2),
					new MySqlParameter("@FamilyAddress", MySqlDbType.VarChar,300),
					new MySqlParameter("@Mobile", MySqlDbType.VarChar,20),
					new MySqlParameter("@IdNumber", MySqlDbType.VarChar,30),
					new MySqlParameter("@DriverLicense", MySqlDbType.VarChar,30),
					new MySqlParameter("@LicenseType", MySqlDbType.VarChar,20),
					new MySqlParameter("@DriverLocation", MySqlDbType.VarChar,20),
					new MySqlParameter("@EmergencyContact", MySqlDbType.VarChar,50),
					new MySqlParameter("@EmergencyMobile", MySqlDbType.VarChar,20),
					new MySqlParameter("@EmergencyRelations", MySqlDbType.VarChar,10),
					new MySqlParameter("@DriverPhoto", MySqlDbType.VarChar,300),
					new MySqlParameter("@CompanyId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Type", MySqlDbType.VarChar,20),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DriverId;
			parameters[1].Value = model.DriverName;
			parameters[2].Value = model.DriverSex;
			parameters[3].Value = model.FamilyAddress;
			parameters[4].Value = model.Mobile;
			parameters[5].Value = model.IdNumber;
			parameters[6].Value = model.DriverLicense;
			parameters[7].Value = model.LicenseType;
			parameters[8].Value = model.DriverLocation;
			parameters[9].Value = model.EmergencyContact;
			parameters[10].Value = model.EmergencyMobile;
			parameters[11].Value = model.EmergencyRelations;
			parameters[12].Value = model.DriverPhoto;
			parameters[13].Value = model.CompanyId;
			parameters[14].Value = model.Type;
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
			strSql.Append("delete from driverinfo ");
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
			strSql.Append("delete from driverinfo ");
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
		public YueYePlat.Model.driverinfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DriverId,DriverName,DriverSex,FamilyAddress,Mobile,IdNumber,DriverLicense,LicenseType,DriverLocation,EmergencyContact,EmergencyMobile,EmergencyRelations,DriverPhoto,CompanyId,Type from driverinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.driverinfo model=new YueYePlat.Model.driverinfo();
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
		public YueYePlat.Model.driverinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.driverinfo model=new YueYePlat.Model.driverinfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DriverId"]!=null)
				{
					model.DriverId=row["DriverId"].ToString();
				}
				if(row["DriverName"]!=null)
				{
					model.DriverName=row["DriverName"].ToString();
				}
				if(row["DriverSex"]!=null)
				{
					model.DriverSex=row["DriverSex"].ToString();
				}
				if(row["FamilyAddress"]!=null)
				{
					model.FamilyAddress=row["FamilyAddress"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["IdNumber"]!=null)
				{
					model.IdNumber=row["IdNumber"].ToString();
				}
				if(row["DriverLicense"]!=null)
				{
					model.DriverLicense=row["DriverLicense"].ToString();
				}
				if(row["LicenseType"]!=null)
				{
					model.LicenseType=row["LicenseType"].ToString();
				}
				if(row["DriverLocation"]!=null)
				{
					model.DriverLocation=row["DriverLocation"].ToString();
				}
				if(row["EmergencyContact"]!=null)
				{
					model.EmergencyContact=row["EmergencyContact"].ToString();
				}
				if(row["EmergencyMobile"]!=null)
				{
					model.EmergencyMobile=row["EmergencyMobile"].ToString();
				}
				if(row["EmergencyRelations"]!=null)
				{
					model.EmergencyRelations=row["EmergencyRelations"].ToString();
				}
				if(row["DriverPhoto"]!=null)
				{
					model.DriverPhoto=row["DriverPhoto"].ToString();
				}
				if(row["CompanyId"]!=null)
				{
					model.CompanyId=row["CompanyId"].ToString();
				}
				if(row["Type"]!=null)
				{
					model.Type=row["Type"].ToString();
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
			strSql.Append("select Id,DriverId,DriverName,DriverSex,FamilyAddress,Mobile,IdNumber,DriverLicense,LicenseType,DriverLocation,EmergencyContact,EmergencyMobile,EmergencyRelations,DriverPhoto,CompanyId,Type ");
			strSql.Append(" FROM driverinfo ");
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
			strSql.Append("select count(1) FROM driverinfo ");
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
			strSql.Append(")AS Row, T.*  from driverinfo T ");
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
			parameters[0].Value = "driverinfo";
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


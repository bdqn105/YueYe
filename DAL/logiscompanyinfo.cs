using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:logiscompanyinfo
	/// </summary>
	public partial class logiscompanyinfo
	{
		public logiscompanyinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "logiscompanyinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from logiscompanyinfo");
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
		public bool Add(YueYePlat.Model.logiscompanyinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into logiscompanyinfo(");
			strSql.Append("CompanyID,CompanyName,CompanyShortName,CompanyShortCode,CompanyDBName,CompanyUnifiedCode,CompanyIcon,ToPublicAccount,ToPrivateAccount,CompanyLocation,CompanyAddress,BusinessNature,LegalRepresentative,Telephone,Mobile,FaxNo)");
			strSql.Append(" values (");
			strSql.Append("@CompanyID,@CompanyName,@CompanyShortName,@CompanyShortCode,@CompanyDBName,@CompanyUnifiedCode,@CompanyIcon,@ToPublicAccount,@ToPrivateAccount,@CompanyLocation,@CompanyAddress,@BusinessNature,@LegalRepresentative,@Telephone,@Mobile,@FaxNo)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CompanyID", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyName", MySqlDbType.VarChar,200),
					new MySqlParameter("@CompanyShortName", MySqlDbType.VarChar,100),
					new MySqlParameter("@CompanyShortCode", MySqlDbType.VarChar,10),
					new MySqlParameter("@CompanyDBName", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyUnifiedCode", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyIcon", MySqlDbType.VarChar,200),
					new MySqlParameter("@ToPublicAccount", MySqlDbType.VarChar,50),
					new MySqlParameter("@ToPrivateAccount", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyLocation", MySqlDbType.VarChar,20),
					new MySqlParameter("@CompanyAddress", MySqlDbType.VarChar,400),
					new MySqlParameter("@BusinessNature", MySqlDbType.VarChar,20),
					new MySqlParameter("@LegalRepresentative", MySqlDbType.VarChar,50),
					new MySqlParameter("@Telephone", MySqlDbType.VarChar,20),
					new MySqlParameter("@Mobile", MySqlDbType.VarChar,20),
					new MySqlParameter("@FaxNo", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.CompanyID;
			parameters[1].Value = model.CompanyName;
			parameters[2].Value = model.CompanyShortName;
			parameters[3].Value = model.CompanyShortCode;
			parameters[4].Value = model.CompanyDBName;
			parameters[5].Value = model.CompanyUnifiedCode;
			parameters[6].Value = model.CompanyIcon;
			parameters[7].Value = model.ToPublicAccount;
			parameters[8].Value = model.ToPrivateAccount;
			parameters[9].Value = model.CompanyLocation;
			parameters[10].Value = model.CompanyAddress;
			parameters[11].Value = model.BusinessNature;
			parameters[12].Value = model.LegalRepresentative;
			parameters[13].Value = model.Telephone;
			parameters[14].Value = model.Mobile;
			parameters[15].Value = model.FaxNo;

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
		public bool Update(YueYePlat.Model.logiscompanyinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update logiscompanyinfo set ");
			strSql.Append("CompanyID=@CompanyID,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyShortName=@CompanyShortName,");
			strSql.Append("CompanyShortCode=@CompanyShortCode,");
			strSql.Append("CompanyDBName=@CompanyDBName,");
			strSql.Append("CompanyUnifiedCode=@CompanyUnifiedCode,");
			strSql.Append("CompanyIcon=@CompanyIcon,");
			strSql.Append("ToPublicAccount=@ToPublicAccount,");
			strSql.Append("ToPrivateAccount=@ToPrivateAccount,");
			strSql.Append("CompanyLocation=@CompanyLocation,");
			strSql.Append("CompanyAddress=@CompanyAddress,");
			strSql.Append("BusinessNature=@BusinessNature,");
			strSql.Append("LegalRepresentative=@LegalRepresentative,");
			strSql.Append("Telephone=@Telephone,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("FaxNo=@FaxNo");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CompanyID", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyName", MySqlDbType.VarChar,200),
					new MySqlParameter("@CompanyShortName", MySqlDbType.VarChar,100),
					new MySqlParameter("@CompanyShortCode", MySqlDbType.VarChar,10),
					new MySqlParameter("@CompanyDBName", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyUnifiedCode", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyIcon", MySqlDbType.VarChar,200),
					new MySqlParameter("@ToPublicAccount", MySqlDbType.VarChar,50),
					new MySqlParameter("@ToPrivateAccount", MySqlDbType.VarChar,50),
					new MySqlParameter("@CompanyLocation", MySqlDbType.VarChar,20),
					new MySqlParameter("@CompanyAddress", MySqlDbType.VarChar,400),
					new MySqlParameter("@BusinessNature", MySqlDbType.VarChar,20),
					new MySqlParameter("@LegalRepresentative", MySqlDbType.VarChar,50),
					new MySqlParameter("@Telephone", MySqlDbType.VarChar,20),
					new MySqlParameter("@Mobile", MySqlDbType.VarChar,20),
					new MySqlParameter("@FaxNo", MySqlDbType.VarChar,20),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.CompanyID;
			parameters[1].Value = model.CompanyName;
			parameters[2].Value = model.CompanyShortName;
			parameters[3].Value = model.CompanyShortCode;
			parameters[4].Value = model.CompanyDBName;
			parameters[5].Value = model.CompanyUnifiedCode;
			parameters[6].Value = model.CompanyIcon;
			parameters[7].Value = model.ToPublicAccount;
			parameters[8].Value = model.ToPrivateAccount;
			parameters[9].Value = model.CompanyLocation;
			parameters[10].Value = model.CompanyAddress;
			parameters[11].Value = model.BusinessNature;
			parameters[12].Value = model.LegalRepresentative;
			parameters[13].Value = model.Telephone;
			parameters[14].Value = model.Mobile;
			parameters[15].Value = model.FaxNo;
			parameters[16].Value = model.Id;

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
			strSql.Append("delete from logiscompanyinfo ");
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
			strSql.Append("delete from logiscompanyinfo ");
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
		public YueYePlat.Model.logiscompanyinfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,CompanyID,CompanyName,CompanyShortName,CompanyShortCode,CompanyDBName,CompanyUnifiedCode,CompanyIcon,ToPublicAccount,ToPrivateAccount,CompanyLocation,CompanyAddress,BusinessNature,LegalRepresentative,Telephone,Mobile,FaxNo from logiscompanyinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.logiscompanyinfo model=new YueYePlat.Model.logiscompanyinfo();
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
		public YueYePlat.Model.logiscompanyinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.logiscompanyinfo model=new YueYePlat.Model.logiscompanyinfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["CompanyID"]!=null)
				{
					model.CompanyID=row["CompanyID"].ToString();
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["CompanyShortName"]!=null)
				{
					model.CompanyShortName=row["CompanyShortName"].ToString();
				}
				if(row["CompanyShortCode"]!=null)
				{
					model.CompanyShortCode=row["CompanyShortCode"].ToString();
				}
				if(row["CompanyDBName"]!=null)
				{
					model.CompanyDBName=row["CompanyDBName"].ToString();
				}
				if(row["CompanyUnifiedCode"]!=null)
				{
					model.CompanyUnifiedCode=row["CompanyUnifiedCode"].ToString();
				}
				if(row["CompanyIcon"]!=null)
				{
					model.CompanyIcon=row["CompanyIcon"].ToString();
				}
				if(row["ToPublicAccount"]!=null)
				{
					model.ToPublicAccount=row["ToPublicAccount"].ToString();
				}
				if(row["ToPrivateAccount"]!=null)
				{
					model.ToPrivateAccount=row["ToPrivateAccount"].ToString();
				}
				if(row["CompanyLocation"]!=null)
				{
					model.CompanyLocation=row["CompanyLocation"].ToString();
				}
				if(row["CompanyAddress"]!=null)
				{
					model.CompanyAddress=row["CompanyAddress"].ToString();
				}
				if(row["BusinessNature"]!=null)
				{
					model.BusinessNature=row["BusinessNature"].ToString();
				}
				if(row["LegalRepresentative"]!=null)
				{
					model.LegalRepresentative=row["LegalRepresentative"].ToString();
				}
				if(row["Telephone"]!=null)
				{
					model.Telephone=row["Telephone"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["FaxNo"]!=null)
				{
					model.FaxNo=row["FaxNo"].ToString();
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
			strSql.Append("select Id,CompanyID,CompanyName,CompanyShortName,CompanyShortCode,CompanyDBName,CompanyUnifiedCode,CompanyIcon,ToPublicAccount,ToPrivateAccount,CompanyLocation,CompanyAddress,BusinessNature,LegalRepresentative,Telephone,Mobile,FaxNo ");
			strSql.Append(" FROM logiscompanyinfo ");
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
			strSql.Append("select count(1) FROM logiscompanyinfo ");
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
			strSql.Append(")AS Row, T.*  from logiscompanyinfo T ");
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
			parameters[0].Value = "logiscompanyinfo";
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


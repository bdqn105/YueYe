using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:productinfo
	/// </summary>
	public partial class productinfo
	{
		public productinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "productinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from productinfo");
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
		public bool Add(YueYePlat.Model.productinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into productinfo(");
			strSql.Append("ProductId,ProductName,ProductType,Specification,Manufaturer,BatchNum,DataofManufaturer,UnitofMeasurement)");
			strSql.Append(" values (");
			strSql.Append("@ProductId,@ProductName,@ProductType,@Specification,@Manufaturer,@BatchNum,@DataofManufaturer,@UnitofMeasurement)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProductId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ProductName", MySqlDbType.VarChar,50),
					new MySqlParameter("@ProductType", MySqlDbType.VarChar,20),
					new MySqlParameter("@Specification", MySqlDbType.VarChar,255),
					new MySqlParameter("@Manufaturer", MySqlDbType.VarChar,300),
					new MySqlParameter("@BatchNum", MySqlDbType.VarChar,50),
					new MySqlParameter("@DataofManufaturer", MySqlDbType.DateTime),
					new MySqlParameter("@UnitofMeasurement", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.ProductId;
			parameters[1].Value = model.ProductName;
			parameters[2].Value = model.ProductType;
			parameters[3].Value = model.Specification;
			parameters[4].Value = model.Manufaturer;
			parameters[5].Value = model.BatchNum;
			parameters[6].Value = model.DataofManufaturer;
			parameters[7].Value = model.UnitofMeasurement;

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
		public bool Update(YueYePlat.Model.productinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update productinfo set ");
			strSql.Append("ProductId=@ProductId,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("ProductType=@ProductType,");
			strSql.Append("Specification=@Specification,");
			strSql.Append("Manufaturer=@Manufaturer,");
			strSql.Append("BatchNum=@BatchNum,");
			strSql.Append("DataofManufaturer=@DataofManufaturer,");
			strSql.Append("UnitofMeasurement=@UnitofMeasurement");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ProductId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ProductName", MySqlDbType.VarChar,50),
					new MySqlParameter("@ProductType", MySqlDbType.VarChar,20),
					new MySqlParameter("@Specification", MySqlDbType.VarChar,255),
					new MySqlParameter("@Manufaturer", MySqlDbType.VarChar,300),
					new MySqlParameter("@BatchNum", MySqlDbType.VarChar,50),
					new MySqlParameter("@DataofManufaturer", MySqlDbType.DateTime),
					new MySqlParameter("@UnitofMeasurement", MySqlDbType.VarChar,255),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.ProductId;
			parameters[1].Value = model.ProductName;
			parameters[2].Value = model.ProductType;
			parameters[3].Value = model.Specification;
			parameters[4].Value = model.Manufaturer;
			parameters[5].Value = model.BatchNum;
			parameters[6].Value = model.DataofManufaturer;
			parameters[7].Value = model.UnitofMeasurement;
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
			strSql.Append("delete from productinfo ");
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
			strSql.Append("delete from productinfo ");
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
		public YueYePlat.Model.productinfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,ProductId,ProductName,ProductType,Specification,Manufaturer,BatchNum,DataofManufaturer,UnitofMeasurement from productinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.productinfo model=new YueYePlat.Model.productinfo();
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
		public YueYePlat.Model.productinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.productinfo model=new YueYePlat.Model.productinfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["ProductId"]!=null)
				{
					model.ProductId=row["ProductId"].ToString();
				}
				if(row["ProductName"]!=null)
				{
					model.ProductName=row["ProductName"].ToString();
				}
				if(row["ProductType"]!=null)
				{
					model.ProductType=row["ProductType"].ToString();
				}
				if(row["Specification"]!=null)
				{
					model.Specification=row["Specification"].ToString();
				}
				if(row["Manufaturer"]!=null)
				{
					model.Manufaturer=row["Manufaturer"].ToString();
				}
				if(row["BatchNum"]!=null)
				{
					model.BatchNum=row["BatchNum"].ToString();
				}
				if(row["DataofManufaturer"]!=null && row["DataofManufaturer"].ToString()!="")
				{
					model.DataofManufaturer=DateTime.Parse(row["DataofManufaturer"].ToString());
				}
				if(row["UnitofMeasurement"]!=null)
				{
					model.UnitofMeasurement=row["UnitofMeasurement"].ToString();
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
			strSql.Append("select Id,ProductId,ProductName,ProductType,Specification,Manufaturer,BatchNum,DataofManufaturer,UnitofMeasurement ");
			strSql.Append(" FROM productinfo ");
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
			strSql.Append("select count(1) FROM productinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperMySQL.GetSingle(strSql.ToString());
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
			strSql.Append(")AS Row, T.*  from productinfo T ");
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
			parameters[0].Value = "productinfo";
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


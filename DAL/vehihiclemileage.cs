using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:vehihiclemileage
	/// </summary>
	public partial class vehihiclemileage
	{
		public vehihiclemileage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("MileageID", "vehihiclemileage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MileageID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from vehihiclemileage");
			strSql.Append(" where MileageID=@MileageID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MileageID", MySqlDbType.Int32)
			};
			parameters[0].Value = MileageID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(YueYePlat.Model.vehihiclemileage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into vehihiclemileage(");
			strSql.Append("VehicleID,DailyMileage,ToalMileage,curDate)");
			strSql.Append(" values (");
			strSql.Append("@VehicleID,@DailyMileage,@ToalMileage,@curDate)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@VehicleID", MySqlDbType.VarChar,12),
					new MySqlParameter("@DailyMileage", MySqlDbType.Double),
					new MySqlParameter("@ToalMileage", MySqlDbType.Double),
					new MySqlParameter("@curDate", MySqlDbType.DateTime)};
			parameters[0].Value = model.VehicleID;
			parameters[1].Value = model.DailyMileage;
			parameters[2].Value = model.ToalMileage;
			parameters[3].Value = model.curDate;

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
		public bool Update(YueYePlat.Model.vehihiclemileage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update vehihiclemileage set ");
			strSql.Append("VehicleID=@VehicleID,");
			strSql.Append("DailyMileage=@DailyMileage,");
			strSql.Append("ToalMileage=@ToalMileage,");
			strSql.Append("curDate=@curDate");
			strSql.Append(" where MileageID=@MileageID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@VehicleID", MySqlDbType.VarChar,12),
					new MySqlParameter("@DailyMileage", MySqlDbType.Double),
					new MySqlParameter("@ToalMileage", MySqlDbType.Double),
					new MySqlParameter("@curDate", MySqlDbType.DateTime),
					new MySqlParameter("@MileageID", MySqlDbType.Int32,11)};
			parameters[0].Value = model.VehicleID;
			parameters[1].Value = model.DailyMileage;
			parameters[2].Value = model.ToalMileage;
			parameters[3].Value = model.curDate;
			parameters[4].Value = model.MileageID;

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
		public bool Delete(int MileageID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from vehihiclemileage ");
			strSql.Append(" where MileageID=@MileageID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MileageID", MySqlDbType.Int32)
			};
			parameters[0].Value = MileageID;

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
		public bool DeleteList(string MileageIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from vehihiclemileage ");
			strSql.Append(" where MileageID in ("+MileageIDlist + ")  ");
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
		public YueYePlat.Model.vehihiclemileage GetModel(int MileageID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MileageID,VehicleID,DailyMileage,ToalMileage,curDate from vehihiclemileage ");
			strSql.Append(" where MileageID=@MileageID");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MileageID", MySqlDbType.Int32)
			};
			parameters[0].Value = MileageID;

			YueYePlat.Model.vehihiclemileage model=new YueYePlat.Model.vehihiclemileage();
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
		public YueYePlat.Model.vehihiclemileage DataRowToModel(DataRow row)
		{
			YueYePlat.Model.vehihiclemileage model=new YueYePlat.Model.vehihiclemileage();
			if (row != null)
			{
				if(row["MileageID"]!=null && row["MileageID"].ToString()!="")
				{
					model.MileageID=int.Parse(row["MileageID"].ToString());
				}
				if(row["VehicleID"]!=null)
				{
					model.VehicleID=row["VehicleID"].ToString();
				}
                if (row["DailyMileage"] != null && row["DailyMileage"].ToString() != "")
                {
                    model.DailyMileage = Double.Parse(row["DailyMileage"].ToString());
                }
                if (row["ToalMileage"] != null && row["ToalMileage"].ToString() != "")
                {
                    model.ToalMileage = Double.Parse(row["ToalMileage"].ToString());
                }
                //model.DailyMileage=row["DailyMileage"].ToString();
                //model.ToalMileage=row["ToalMileage"].ToString();
                if (row["curDate"]!=null && row["curDate"].ToString()!="")
				{
					model.curDate=DateTime.Parse(row["curDate"].ToString());
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
			strSql.Append("select MileageID,VehicleID,DailyMileage,ToalMileage,curDate ");
			strSql.Append(" FROM vehihiclemileage ");
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
			strSql.Append("select count(1) FROM vehihiclemileage ");
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
				strSql.Append("order by T.MileageID desc");
			}
			strSql.Append(")AS Row, T.*  from vehihiclemileage T ");
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
			parameters[0].Value = "vehihiclemileage";
			parameters[1].Value = "MileageID";
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


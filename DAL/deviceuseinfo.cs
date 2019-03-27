using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:deviceuseinfo
	/// </summary>
	public partial class deviceuseinfo
	{
		public deviceuseinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "deviceuseinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from deviceuseinfo");
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
		public bool Add(YueYePlat.Model.deviceuseinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into deviceuseinfo(");
			strSql.Append("DeviceId,VehicleId,IfBind,BindTime,UnbindTime,Comment)");
			strSql.Append(" values (");
			strSql.Append("@DeviceId,@VehicleId,@IfBind,@BindTime,@UnbindTime,@Comment)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeviceId", MySqlDbType.VarChar,14),
					new MySqlParameter("@VehicleId", MySqlDbType.VarChar,12),
					new MySqlParameter("@IfBind", MySqlDbType.Bit),
					new MySqlParameter("@BindTime", MySqlDbType.DateTime),
					new MySqlParameter("@UnbindTime", MySqlDbType.DateTime),
					new MySqlParameter("@Comment", MySqlDbType.VarChar,300)};
			parameters[0].Value = model.DeviceId;
			parameters[1].Value = model.VehicleId;
			parameters[2].Value = model.IfBind;
			parameters[3].Value = model.BindTime;
			parameters[4].Value = model.UnbindTime;
			parameters[5].Value = model.Comment;

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
		public bool Update(YueYePlat.Model.deviceuseinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update deviceuseinfo set ");
			strSql.Append("DeviceId=@DeviceId,");
			strSql.Append("VehicleId=@VehicleId,");
			strSql.Append("IfBind=@IfBind,");
			strSql.Append("BindTime=@BindTime,");
			strSql.Append("UnbindTime=@UnbindTime,");
			strSql.Append("Comment=@Comment");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeviceId", MySqlDbType.VarChar,14),
					new MySqlParameter("@VehicleId", MySqlDbType.VarChar,12),
					new MySqlParameter("@IfBind", MySqlDbType.Bit),
					new MySqlParameter("@BindTime", MySqlDbType.DateTime),
					new MySqlParameter("@UnbindTime", MySqlDbType.DateTime),
					new MySqlParameter("@Comment", MySqlDbType.VarChar,300),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DeviceId;
			parameters[1].Value = model.VehicleId;
			parameters[2].Value = model.IfBind;
			parameters[3].Value = model.BindTime;
			parameters[4].Value = model.UnbindTime;
			parameters[5].Value = model.Comment;
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
			strSql.Append("delete from deviceuseinfo ");
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
			strSql.Append("delete from deviceuseinfo ");
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
		public YueYePlat.Model.deviceuseinfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeviceId,VehicleId,IfBind,BindTime,UnbindTime,Comment from deviceuseinfo ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.deviceuseinfo model=new YueYePlat.Model.deviceuseinfo();
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
		public YueYePlat.Model.deviceuseinfo DataRowToModel(DataRow row)
		{
			YueYePlat.Model.deviceuseinfo model=new YueYePlat.Model.deviceuseinfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DeviceId"]!=null)
				{
					model.DeviceId=row["DeviceId"].ToString();
				}
				if(row["VehicleId"]!=null)
				{
					model.VehicleId=row["VehicleId"].ToString();
				}
				if(row["IfBind"]!=null && row["IfBind"].ToString()!="")
				{
					if((row["IfBind"].ToString()=="1")||(row["IfBind"].ToString().ToLower()=="true"))
					{
						model.IfBind=true;
					}
					else
					{
						model.IfBind=false;
					}
				}
				if(row["BindTime"]!=null && row["BindTime"].ToString()!="")
				{
					model.BindTime=DateTime.Parse(row["BindTime"].ToString());
				}
				if(row["UnbindTime"]!=null && row["UnbindTime"].ToString()!="")
				{
					model.UnbindTime=DateTime.Parse(row["UnbindTime"].ToString());
				}
				if(row["Comment"]!=null)
				{
					model.Comment=row["Comment"].ToString();
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
			strSql.Append("select Id,DeviceId,VehicleId,IfBind,BindTime,UnbindTime,Comment ");
			strSql.Append(" FROM deviceuseinfo ");
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
			strSql.Append("select count(1) FROM deviceuseinfo ");
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
			strSql.Append(")AS Row, T.*  from deviceuseinfo T ");
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
			parameters[0].Value = "deviceuseinfo";
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


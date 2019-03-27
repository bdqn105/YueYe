using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:clientorder
	/// </summary>
	public partial class clientorder
	{
		public clientorder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "clientorder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from clientorder");
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
		public bool Add(YueYePlat.Model.clientorder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into clientorder(");
			strSql.Append("ClientOrderId,Listnumber,AirWaybillID,SourTransType,SourceTransId,AirArriverTime,ClientId,ClientPhone,ClientAddress,Receiver,ReceiverPhone,ReceiverAddress,ProductId,Quantity,Weight,IsDeliver,IsDeal,Remark)");
			strSql.Append(" values (");
			strSql.Append("@ClientOrderId,@Listnumber,@AirWaybillID,@SourTransType,@SourceTransId,@AirArriverTime,@ClientId,@ClientPhone,@ClientAddress,@Receiver,@ReceiverPhone,@ReceiverAddress,@ProductId,@Quantity,@Weight,@IsDeliver,@IsDeal,@Remark)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ClientOrderId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Listnumber", MySqlDbType.VarChar,50),
					new MySqlParameter("@AirWaybillID", MySqlDbType.VarChar,50),
					new MySqlParameter("@SourTransType", MySqlDbType.VarChar,50),
					new MySqlParameter("@SourceTransId", MySqlDbType.VarChar,50),
					new MySqlParameter("@AirArriverTime", MySqlDbType.DateTime),
					new MySqlParameter("@ClientId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ClientPhone", MySqlDbType.VarChar,20),
					new MySqlParameter("@ClientAddress", MySqlDbType.VarChar,100),
					new MySqlParameter("@Receiver", MySqlDbType.VarChar,50),
					new MySqlParameter("@ReceiverPhone", MySqlDbType.VarChar,50),
					new MySqlParameter("@ReceiverAddress", MySqlDbType.VarChar,100),
					new MySqlParameter("@ProductId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Quantity", MySqlDbType.Int32,11),
					new MySqlParameter("@Weight", MySqlDbType.Decimal,10),
					new MySqlParameter("@IsDeliver", MySqlDbType.Bit),
					new MySqlParameter("@IsDeal", MySqlDbType.Bit),
					new MySqlParameter("@Remark", MySqlDbType.Text)};
			parameters[0].Value = model.ClientOrderId;
			parameters[1].Value = model.Listnumber;
			parameters[2].Value = model.AirWaybillID;
			parameters[3].Value = model.SourTransType;
			parameters[4].Value = model.SourceTransId;
			parameters[5].Value = model.AirArriverTime;
			parameters[6].Value = model.ClientId;
			parameters[7].Value = model.ClientPhone;
			parameters[8].Value = model.ClientAddress;
			parameters[9].Value = model.Receiver;
			parameters[10].Value = model.ReceiverPhone;
			parameters[11].Value = model.ReceiverAddress;
			parameters[12].Value = model.ProductId;
			parameters[13].Value = model.Quantity;
			parameters[14].Value = model.Weight;
			parameters[15].Value = model.IsDeliver;
			parameters[16].Value = model.IsDeal;
			parameters[17].Value = model.Remark;

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
		public bool Update(YueYePlat.Model.clientorder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update clientorder set ");
			strSql.Append("ClientOrderId=@ClientOrderId,");
			strSql.Append("Listnumber=@Listnumber,");
			strSql.Append("AirWaybillID=@AirWaybillID,");
			strSql.Append("SourTransType=@SourTransType,");
			strSql.Append("SourceTransId=@SourceTransId,");
			strSql.Append("AirArriverTime=@AirArriverTime,");
			strSql.Append("ClientId=@ClientId,");
			strSql.Append("ClientPhone=@ClientPhone,");
			strSql.Append("ClientAddress=@ClientAddress,");
			strSql.Append("Receiver=@Receiver,");
			strSql.Append("ReceiverPhone=@ReceiverPhone,");
			strSql.Append("ReceiverAddress=@ReceiverAddress,");
			strSql.Append("ProductId=@ProductId,");
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("Weight=@Weight,");
			strSql.Append("IsDeliver=@IsDeliver,");
			strSql.Append("IsDeal=@IsDeal,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ClientOrderId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Listnumber", MySqlDbType.VarChar,50),
					new MySqlParameter("@AirWaybillID", MySqlDbType.VarChar,50),
					new MySqlParameter("@SourTransType", MySqlDbType.VarChar,50),
					new MySqlParameter("@SourceTransId", MySqlDbType.VarChar,50),
					new MySqlParameter("@AirArriverTime", MySqlDbType.DateTime),
					new MySqlParameter("@ClientId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ClientPhone", MySqlDbType.VarChar,20),
					new MySqlParameter("@ClientAddress", MySqlDbType.VarChar,100),
					new MySqlParameter("@Receiver", MySqlDbType.VarChar,50),
					new MySqlParameter("@ReceiverPhone", MySqlDbType.VarChar,50),
					new MySqlParameter("@ReceiverAddress", MySqlDbType.VarChar,100),
					new MySqlParameter("@ProductId", MySqlDbType.VarChar,50),
					new MySqlParameter("@Quantity", MySqlDbType.Int32,11),
					new MySqlParameter("@Weight", MySqlDbType.Decimal,10),
					new MySqlParameter("@IsDeliver", MySqlDbType.Bit),
					new MySqlParameter("@IsDeal", MySqlDbType.Bit),
					new MySqlParameter("@Remark", MySqlDbType.Text),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.ClientOrderId;
			parameters[1].Value = model.Listnumber;
			parameters[2].Value = model.AirWaybillID;
			parameters[3].Value = model.SourTransType;
			parameters[4].Value = model.SourceTransId;
			parameters[5].Value = model.AirArriverTime;
			parameters[6].Value = model.ClientId;
			parameters[7].Value = model.ClientPhone;
			parameters[8].Value = model.ClientAddress;
			parameters[9].Value = model.Receiver;
			parameters[10].Value = model.ReceiverPhone;
			parameters[11].Value = model.ReceiverAddress;
			parameters[12].Value = model.ProductId;
			parameters[13].Value = model.Quantity;
			parameters[14].Value = model.Weight;
			parameters[15].Value = model.IsDeliver;
			parameters[16].Value = model.IsDeal;
			parameters[17].Value = model.Remark;
			parameters[18].Value = model.Id;

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
			strSql.Append("delete from clientorder ");
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
			strSql.Append("delete from clientorder ");
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
		public YueYePlat.Model.clientorder GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,ClientOrderId,Listnumber,AirWaybillID,SourTransType,SourceTransId,AirArriverTime,ClientId,ClientPhone,ClientAddress,Receiver,ReceiverPhone,ReceiverAddress,ProductId,Quantity,Weight,IsDeliver,IsDeal,Remark from clientorder ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.clientorder model=new YueYePlat.Model.clientorder();
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
		public YueYePlat.Model.clientorder DataRowToModel(DataRow row)
		{
			YueYePlat.Model.clientorder model=new YueYePlat.Model.clientorder();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["ClientOrderId"]!=null)
				{
					model.ClientOrderId=row["ClientOrderId"].ToString();
				}
				if(row["Listnumber"]!=null)
				{
					model.Listnumber=row["Listnumber"].ToString();
				}
				if(row["AirWaybillID"]!=null)
				{
					model.AirWaybillID=row["AirWaybillID"].ToString();
				}
				if(row["SourTransType"]!=null)
				{
					model.SourTransType=row["SourTransType"].ToString();
				}
				if(row["SourceTransId"]!=null)
				{
					model.SourceTransId=row["SourceTransId"].ToString();
				}
				if(row["AirArriverTime"]!=null && row["AirArriverTime"].ToString()!="")
				{
					model.AirArriverTime=DateTime.Parse(row["AirArriverTime"].ToString());
				}
				if(row["ClientId"]!=null)
				{
					model.ClientId=row["ClientId"].ToString();
				}
				if(row["ClientPhone"]!=null)
				{
					model.ClientPhone=row["ClientPhone"].ToString();
				}
				if(row["ClientAddress"]!=null)
				{
					model.ClientAddress=row["ClientAddress"].ToString();
				}
				if(row["Receiver"]!=null)
				{
					model.Receiver=row["Receiver"].ToString();
				}
				if(row["ReceiverPhone"]!=null)
				{
					model.ReceiverPhone=row["ReceiverPhone"].ToString();
				}
				if(row["ReceiverAddress"]!=null)
				{
					model.ReceiverAddress=row["ReceiverAddress"].ToString();
				}
				if(row["ProductId"]!=null)
				{
					model.ProductId=row["ProductId"].ToString();
				}
				if(row["Quantity"]!=null && row["Quantity"].ToString()!="")
				{
					model.Quantity=int.Parse(row["Quantity"].ToString());
				}
				if(row["Weight"]!=null && row["Weight"].ToString()!="")
				{
					model.Weight=decimal.Parse(row["Weight"].ToString());
				}
				if(row["IsDeliver"]!=null && row["IsDeliver"].ToString()!="")
				{
					if((row["IsDeliver"].ToString()=="1")||(row["IsDeliver"].ToString().ToLower()=="true"))
					{
						model.IsDeliver=true;
					}
					else
					{
						model.IsDeliver=false;
					}
				}
				if(row["IsDeal"]!=null && row["IsDeal"].ToString()!="")
				{
					if((row["IsDeal"].ToString()=="1")||(row["IsDeal"].ToString().ToLower()=="true"))
					{
						model.IsDeal=true;
					}
					else
					{
						model.IsDeal=false;
					}
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select Id,ClientOrderId,Listnumber,AirWaybillID,SourTransType,SourceTransId,AirArriverTime,ClientId,ClientPhone,ClientAddress,Receiver,ReceiverPhone,ReceiverAddress,ProductId,Quantity,Weight,IsDeliver,IsDeal,Remark ");
			strSql.Append(" FROM clientorder ");
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
			strSql.Append("select count(1) FROM clientorder ");
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
			strSql.Append(")AS Row, T.*  from clientorder T ");
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
			parameters[0].Value = "clientorder";
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


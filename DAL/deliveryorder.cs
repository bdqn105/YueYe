using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YueYePlat.DAL
{
	/// <summary>
	/// 数据访问类:deliveryorder
	/// </summary>
	public partial class deliveryorder
	{
		public deliveryorder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "deliveryorder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from deliveryorder");
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
		public bool Add(YueYePlat.Model.deliveryorder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into deliveryorder(");
			strSql.Append("DeliveryOrderId,DeliveryId,SourceTransType,SourceTransId,AirWaybillID,Origin,BeginTime,Destination,Longitude,Latitude,PredictDeliveryTime,DeliveryTime,ClientId,ArriveTime,Receiver,ReceiverPhone1,ReceiverPhone2,ReceiverPhone3,IfTransfer,TransferName,TransferFee,Signer,SignerCardID,Telephone,IsBackFee,Receivable,Amount,IsDeliver,TotalFee,ReturnOrderSrc,ClientReturnOrderSrc,Terminator,IsEnd,PaymentMethod,Auditor,IsChecked,LogisCompanyShortName,LogisCompanyID,Remark,RecorderID)");
			strSql.Append(" values (");
			strSql.Append("@DeliveryOrderId,@DeliveryId,@SourceTransType,@SourceTransId,@AirWaybillID,@Origin,@BeginTime,@Destination,@Longitude,@Latitude,@PredictDeliveryTime,@DeliveryTime,@ClientId,@ArriveTime,@Receiver,@ReceiverPhone1,@ReceiverPhone2,@ReceiverPhone3,@IfTransfer,@TransferName,@TransferFee,@Signer,@SignerCardID,@Telephone,@IsBackFee,@Receivable,@Amount,@IsDeliver,@TotalFee,@ReturnOrderSrc,@ClientReturnOrderSrc,@Terminator,@IsEnd,@PaymentMethod,@Auditor,@IsChecked,@LogisCompanyShortName,@LogisCompanyID,@Remark,@RecorderID)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryOrderId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,50),
					new MySqlParameter("@SourceTransType", MySqlDbType.VarChar,50),
					new MySqlParameter("@SourceTransId", MySqlDbType.VarChar,50),
					new MySqlParameter("@AirWaybillID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Origin", MySqlDbType.VarChar,20),
					new MySqlParameter("@BeginTime", MySqlDbType.DateTime),
					new MySqlParameter("@Destination", MySqlDbType.VarChar,300),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@PredictDeliveryTime", MySqlDbType.DateTime),
					new MySqlParameter("@DeliveryTime", MySqlDbType.DateTime),
					new MySqlParameter("@ClientId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ArriveTime", MySqlDbType.DateTime),
					new MySqlParameter("@Receiver", MySqlDbType.VarChar,50),
					new MySqlParameter("@ReceiverPhone1", MySqlDbType.VarChar,20),
					new MySqlParameter("@ReceiverPhone2", MySqlDbType.VarChar,20),
					new MySqlParameter("@ReceiverPhone3", MySqlDbType.VarChar,20),
					new MySqlParameter("@IfTransfer", MySqlDbType.Bit),
					new MySqlParameter("@TransferName", MySqlDbType.VarChar,300),
					new MySqlParameter("@TransferFee", MySqlDbType.Decimal,20),
					new MySqlParameter("@Signer", MySqlDbType.VarChar,50),
					new MySqlParameter("@SignerCardID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Telephone", MySqlDbType.VarChar,20),
					new MySqlParameter("@IsBackFee", MySqlDbType.Bit),
					new MySqlParameter("@Receivable", MySqlDbType.Decimal,15),
					new MySqlParameter("@Amount", MySqlDbType.Decimal,15),
					new MySqlParameter("@IsDeliver", MySqlDbType.Bit),
					new MySqlParameter("@TotalFee", MySqlDbType.Decimal,15),
					new MySqlParameter("@ReturnOrderSrc", MySqlDbType.VarChar,500),
					new MySqlParameter("@ClientReturnOrderSrc", MySqlDbType.VarChar,500),
					new MySqlParameter("@Terminator", MySqlDbType.VarChar,50),
					new MySqlParameter("@IsEnd", MySqlDbType.Bit),
					new MySqlParameter("@PaymentMethod", MySqlDbType.VarChar,50),
					new MySqlParameter("@Auditor", MySqlDbType.VarChar,50),
					new MySqlParameter("@IsChecked", MySqlDbType.Bit),
					new MySqlParameter("@LogisCompanyShortName", MySqlDbType.VarChar,200),
					new MySqlParameter("@LogisCompanyID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Remark", MySqlDbType.Text),
					new MySqlParameter("@RecorderID", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.DeliveryOrderId;
			parameters[1].Value = model.DeliveryId;
			parameters[2].Value = model.SourceTransType;
			parameters[3].Value = model.SourceTransId;
			parameters[4].Value = model.AirWaybillID;
			parameters[5].Value = model.Origin;
			parameters[6].Value = model.BeginTime;
			parameters[7].Value = model.Destination;
			parameters[8].Value = model.Longitude;
			parameters[9].Value = model.Latitude;
			parameters[10].Value = model.PredictDeliveryTime;
			parameters[11].Value = model.DeliveryTime;
			parameters[12].Value = model.ClientId;
			parameters[13].Value = model.ArriveTime;
			parameters[14].Value = model.Receiver;
			parameters[15].Value = model.ReceiverPhone1;
			parameters[16].Value = model.ReceiverPhone2;
			parameters[17].Value = model.ReceiverPhone3;
			parameters[18].Value = model.IfTransfer;
			parameters[19].Value = model.TransferName;
			parameters[20].Value = model.TransferFee;
			parameters[21].Value = model.Signer;
			parameters[22].Value = model.SignerCardID;
			parameters[23].Value = model.Telephone;
			parameters[24].Value = model.IsBackFee;
			parameters[25].Value = model.Receivable;
			parameters[26].Value = model.Amount;
			parameters[27].Value = model.IsDeliver;
			parameters[28].Value = model.TotalFee;
			parameters[29].Value = model.ReturnOrderSrc;
			parameters[30].Value = model.ClientReturnOrderSrc;
			parameters[31].Value = model.Terminator;
			parameters[32].Value = model.IsEnd;
			parameters[33].Value = model.PaymentMethod;
			parameters[34].Value = model.Auditor;
			parameters[35].Value = model.IsChecked;
			parameters[36].Value = model.LogisCompanyShortName;
			parameters[37].Value = model.LogisCompanyID;
			parameters[38].Value = model.Remark;
			parameters[39].Value = model.RecorderID;

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
		public bool Update(YueYePlat.Model.deliveryorder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update deliveryorder set ");
			strSql.Append("DeliveryOrderId=@DeliveryOrderId,");
			strSql.Append("DeliveryId=@DeliveryId,");
			strSql.Append("SourceTransType=@SourceTransType,");
			strSql.Append("SourceTransId=@SourceTransId,");
			strSql.Append("AirWaybillID=@AirWaybillID,");
			strSql.Append("Origin=@Origin,");
			strSql.Append("BeginTime=@BeginTime,");
			strSql.Append("Destination=@Destination,");
			strSql.Append("Longitude=@Longitude,");
			strSql.Append("Latitude=@Latitude,");
			strSql.Append("PredictDeliveryTime=@PredictDeliveryTime,");
			strSql.Append("DeliveryTime=@DeliveryTime,");
			strSql.Append("ClientId=@ClientId,");
			strSql.Append("ArriveTime=@ArriveTime,");
			strSql.Append("Receiver=@Receiver,");
			strSql.Append("ReceiverPhone1=@ReceiverPhone1,");
			strSql.Append("ReceiverPhone2=@ReceiverPhone2,");
			strSql.Append("ReceiverPhone3=@ReceiverPhone3,");
			strSql.Append("IfTransfer=@IfTransfer,");
			strSql.Append("TransferName=@TransferName,");
			strSql.Append("TransferFee=@TransferFee,");
			strSql.Append("Signer=@Signer,");
			strSql.Append("SignerCardID=@SignerCardID,");
			strSql.Append("Telephone=@Telephone,");
			strSql.Append("IsBackFee=@IsBackFee,");
			strSql.Append("Receivable=@Receivable,");
			strSql.Append("Amount=@Amount,");
			strSql.Append("IsDeliver=@IsDeliver,");
			strSql.Append("TotalFee=@TotalFee,");
			strSql.Append("ReturnOrderSrc=@ReturnOrderSrc,");
			strSql.Append("ClientReturnOrderSrc=@ClientReturnOrderSrc,");
			strSql.Append("Terminator=@Terminator,");
			strSql.Append("IsEnd=@IsEnd,");
			strSql.Append("PaymentMethod=@PaymentMethod,");
			strSql.Append("Auditor=@Auditor,");
			strSql.Append("IsChecked=@IsChecked,");
			strSql.Append("LogisCompanyShortName=@LogisCompanyShortName,");
			strSql.Append("LogisCompanyID=@LogisCompanyID,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("RecorderID=@RecorderID");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@DeliveryOrderId", MySqlDbType.VarChar,50),
					new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,50),
					new MySqlParameter("@SourceTransType", MySqlDbType.VarChar,50),
					new MySqlParameter("@SourceTransId", MySqlDbType.VarChar,50),
					new MySqlParameter("@AirWaybillID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Origin", MySqlDbType.VarChar,20),
					new MySqlParameter("@BeginTime", MySqlDbType.DateTime),
					new MySqlParameter("@Destination", MySqlDbType.VarChar,300),
					new MySqlParameter("@Longitude", MySqlDbType.Double),
					new MySqlParameter("@Latitude", MySqlDbType.Double),
					new MySqlParameter("@PredictDeliveryTime", MySqlDbType.DateTime),
					new MySqlParameter("@DeliveryTime", MySqlDbType.DateTime),
					new MySqlParameter("@ClientId", MySqlDbType.VarChar,50),
					new MySqlParameter("@ArriveTime", MySqlDbType.DateTime),
					new MySqlParameter("@Receiver", MySqlDbType.VarChar,50),
					new MySqlParameter("@ReceiverPhone1", MySqlDbType.VarChar,20),
					new MySqlParameter("@ReceiverPhone2", MySqlDbType.VarChar,20),
					new MySqlParameter("@ReceiverPhone3", MySqlDbType.VarChar,20),
					new MySqlParameter("@IfTransfer", MySqlDbType.Bit),
					new MySqlParameter("@TransferName", MySqlDbType.VarChar,300),
					new MySqlParameter("@TransferFee", MySqlDbType.Decimal,20),
					new MySqlParameter("@Signer", MySqlDbType.VarChar,50),
					new MySqlParameter("@SignerCardID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Telephone", MySqlDbType.VarChar,20),
					new MySqlParameter("@IsBackFee", MySqlDbType.Bit),
					new MySqlParameter("@Receivable", MySqlDbType.Decimal,15),
					new MySqlParameter("@Amount", MySqlDbType.Decimal,15),
					new MySqlParameter("@IsDeliver", MySqlDbType.Bit),
					new MySqlParameter("@TotalFee", MySqlDbType.Decimal,15),
					new MySqlParameter("@ReturnOrderSrc", MySqlDbType.VarChar,500),
					new MySqlParameter("@ClientReturnOrderSrc", MySqlDbType.VarChar,500),
					new MySqlParameter("@Terminator", MySqlDbType.VarChar,50),
					new MySqlParameter("@IsEnd", MySqlDbType.Bit),
					new MySqlParameter("@PaymentMethod", MySqlDbType.VarChar,50),
					new MySqlParameter("@Auditor", MySqlDbType.VarChar,50),
					new MySqlParameter("@IsChecked", MySqlDbType.Bit),
					new MySqlParameter("@LogisCompanyShortName", MySqlDbType.VarChar,200),
					new MySqlParameter("@LogisCompanyID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Remark", MySqlDbType.Text),
					new MySqlParameter("@RecorderID", MySqlDbType.VarChar,50),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.DeliveryOrderId;
			parameters[1].Value = model.DeliveryId;
			parameters[2].Value = model.SourceTransType;
			parameters[3].Value = model.SourceTransId;
			parameters[4].Value = model.AirWaybillID;
			parameters[5].Value = model.Origin;
			parameters[6].Value = model.BeginTime;
			parameters[7].Value = model.Destination;
			parameters[8].Value = model.Longitude;
			parameters[9].Value = model.Latitude;
			parameters[10].Value = model.PredictDeliveryTime;
			parameters[11].Value = model.DeliveryTime;
			parameters[12].Value = model.ClientId;
			parameters[13].Value = model.ArriveTime;
			parameters[14].Value = model.Receiver;
			parameters[15].Value = model.ReceiverPhone1;
			parameters[16].Value = model.ReceiverPhone2;
			parameters[17].Value = model.ReceiverPhone3;
			parameters[18].Value = model.IfTransfer;
			parameters[19].Value = model.TransferName;
			parameters[20].Value = model.TransferFee;
			parameters[21].Value = model.Signer;
			parameters[22].Value = model.SignerCardID;
			parameters[23].Value = model.Telephone;
			parameters[24].Value = model.IsBackFee;
			parameters[25].Value = model.Receivable;
			parameters[26].Value = model.Amount;
			parameters[27].Value = model.IsDeliver;
			parameters[28].Value = model.TotalFee;
			parameters[29].Value = model.ReturnOrderSrc;
			parameters[30].Value = model.ClientReturnOrderSrc;
			parameters[31].Value = model.Terminator;
			parameters[32].Value = model.IsEnd;
			parameters[33].Value = model.PaymentMethod;
			parameters[34].Value = model.Auditor;
			parameters[35].Value = model.IsChecked;
			parameters[36].Value = model.LogisCompanyShortName;
			parameters[37].Value = model.LogisCompanyID;
			parameters[38].Value = model.Remark;
			parameters[39].Value = model.RecorderID;
			parameters[40].Value = model.Id;

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
			strSql.Append("delete from deliveryorder ");
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
			strSql.Append("delete from deliveryorder ");
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
		public YueYePlat.Model.deliveryorder GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,DeliveryOrderId,DeliveryId,SourceTransType,SourceTransId,AirWaybillID,Origin,BeginTime,Destination,Longitude,Latitude,PredictDeliveryTime,DeliveryTime,ClientId,ArriveTime,Receiver,ReceiverPhone1,ReceiverPhone2,ReceiverPhone3,IfTransfer,TransferName,TransferFee,Signer,SignerCardID,Telephone,IsBackFee,Receivable,Amount,IsDeliver,TotalFee,ReturnOrderSrc,ClientReturnOrderSrc,Terminator,IsEnd,PaymentMethod,Auditor,IsChecked,LogisCompanyShortName,LogisCompanyID,Remark,RecorderID from deliveryorder ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			YueYePlat.Model.deliveryorder model=new YueYePlat.Model.deliveryorder();
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
		public YueYePlat.Model.deliveryorder DataRowToModel(DataRow row)
		{
			YueYePlat.Model.deliveryorder model=new YueYePlat.Model.deliveryorder();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DeliveryOrderId"]!=null)
				{
					model.DeliveryOrderId=row["DeliveryOrderId"].ToString();
				}
				if(row["DeliveryId"]!=null)
				{
					model.DeliveryId=row["DeliveryId"].ToString();
				}
				if(row["SourceTransType"]!=null)
				{
					model.SourceTransType=row["SourceTransType"].ToString();
				}
				if(row["SourceTransId"]!=null)
				{
					model.SourceTransId=row["SourceTransId"].ToString();
				}
				if(row["AirWaybillID"]!=null)
				{
					model.AirWaybillID=row["AirWaybillID"].ToString();
				}
				if(row["Origin"]!=null)
				{
					model.Origin=row["Origin"].ToString();
				}
				if(row["BeginTime"]!=null && row["BeginTime"].ToString()!="")
				{
					model.BeginTime=DateTime.Parse(row["BeginTime"].ToString());
				}
				if(row["Destination"]!=null)
				{
					model.Destination=row["Destination"].ToString();
				}
					if(row["Longitude"]!=null&&row["Longitude"].ToString()!="")
				{
					model.Longitude=double.Parse ( row["Longitude"].ToString());
				}
				if(row["Latitude"]!=null&&row["Latitude"].ToString()!="")
				{
					model.Latitude=double.Parse (row["Latitude"].ToString());
				}
					//model.Longitude=row["Longitude"].ToString();
					//model.Latitude=row["Latitude"].ToString();
				if(row["PredictDeliveryTime"]!=null && row["PredictDeliveryTime"].ToString()!="")
				{
					model.PredictDeliveryTime=DateTime.Parse(row["PredictDeliveryTime"].ToString());
				}
				if(row["DeliveryTime"]!=null && row["DeliveryTime"].ToString()!="")
				{
					model.DeliveryTime=DateTime.Parse(row["DeliveryTime"].ToString());
				}
				if(row["ClientId"]!=null)
				{
					model.ClientId=row["ClientId"].ToString();
				}
				if(row["ArriveTime"]!=null && row["ArriveTime"].ToString()!="")
				{
					model.ArriveTime=DateTime.Parse(row["ArriveTime"].ToString());
				}
				if(row["Receiver"]!=null)
				{
					model.Receiver=row["Receiver"].ToString();
				}
				if(row["ReceiverPhone1"]!=null)
				{
					model.ReceiverPhone1=row["ReceiverPhone1"].ToString();
				}
				if(row["ReceiverPhone2"]!=null)
				{
					model.ReceiverPhone2=row["ReceiverPhone2"].ToString();
				}
				if(row["ReceiverPhone3"]!=null)
				{
					model.ReceiverPhone3=row["ReceiverPhone3"].ToString();
				}
				if(row["IfTransfer"]!=null && row["IfTransfer"].ToString()!="")
				{
					if((row["IfTransfer"].ToString()=="1")||(row["IfTransfer"].ToString().ToLower()=="true"))
					{
						model.IfTransfer=true;
					}
					else
					{
						model.IfTransfer=false;
					}
				}
				if(row["TransferName"]!=null)
				{
					model.TransferName=row["TransferName"].ToString();
				}
				if(row["TransferFee"]!=null && row["TransferFee"].ToString()!="")
				{
					model.TransferFee=decimal.Parse(row["TransferFee"].ToString());
				}
				if(row["Signer"]!=null)
				{
					model.Signer=row["Signer"].ToString();
				}
				if(row["SignerCardID"]!=null)
				{
					model.SignerCardID=row["SignerCardID"].ToString();
				}
				if(row["Telephone"]!=null)
				{
					model.Telephone=row["Telephone"].ToString();
				}
				if(row["IsBackFee"]!=null && row["IsBackFee"].ToString()!="")
				{
					if((row["IsBackFee"].ToString()=="1")||(row["IsBackFee"].ToString().ToLower()=="true"))
					{
						model.IsBackFee=true;
					}
					else
					{
						model.IsBackFee=false;
					}
				}
				if(row["Receivable"]!=null && row["Receivable"].ToString()!="")
				{
					model.Receivable=decimal.Parse(row["Receivable"].ToString());
				}
				if(row["Amount"]!=null && row["Amount"].ToString()!="")
				{
					model.Amount=decimal.Parse(row["Amount"].ToString());
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
				if(row["TotalFee"]!=null && row["TotalFee"].ToString()!="")
				{
					model.TotalFee=decimal.Parse(row["TotalFee"].ToString());
				}
				if(row["ReturnOrderSrc"]!=null)
				{
					model.ReturnOrderSrc=row["ReturnOrderSrc"].ToString();
				}
				if(row["ClientReturnOrderSrc"]!=null)
				{
					model.ClientReturnOrderSrc=row["ClientReturnOrderSrc"].ToString();
				}
				if(row["Terminator"]!=null)
				{
					model.Terminator=row["Terminator"].ToString();
				}
				if(row["IsEnd"]!=null && row["IsEnd"].ToString()!="")
				{
					if((row["IsEnd"].ToString()=="1")||(row["IsEnd"].ToString().ToLower()=="true"))
					{
						model.IsEnd=true;
					}
					else
					{
						model.IsEnd=false;
					}
				}
				if(row["PaymentMethod"]!=null)
				{
					model.PaymentMethod=row["PaymentMethod"].ToString();
				}
				if(row["Auditor"]!=null)
				{
					model.Auditor=row["Auditor"].ToString();
				}
				if(row["IsChecked"]!=null && row["IsChecked"].ToString()!="")
				{
					if((row["IsChecked"].ToString()=="1")||(row["IsChecked"].ToString().ToLower()=="true"))
					{
						model.IsChecked=true;
					}
					else
					{
						model.IsChecked=false;
					}
				}
				if(row["LogisCompanyShortName"]!=null)
				{
					model.LogisCompanyShortName=row["LogisCompanyShortName"].ToString();
				}
				if(row["LogisCompanyID"]!=null)
				{
					model.LogisCompanyID=row["LogisCompanyID"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["RecorderID"]!=null)
				{
					model.RecorderID=row["RecorderID"].ToString();
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
			strSql.Append("select Id,DeliveryOrderId,DeliveryId,SourceTransType,SourceTransId,AirWaybillID,Origin,BeginTime,Destination,Longitude,Latitude,PredictDeliveryTime,DeliveryTime,ClientId,ArriveTime,Receiver,ReceiverPhone1,ReceiverPhone2,ReceiverPhone3,IfTransfer,TransferName,TransferFee,Signer,SignerCardID,Telephone,IsBackFee,Receivable,Amount,IsDeliver,TotalFee,ReturnOrderSrc,ClientReturnOrderSrc,Terminator,IsEnd,PaymentMethod,Auditor,IsChecked,LogisCompanyShortName,LogisCompanyID,Remark,RecorderID ");
			strSql.Append(" FROM deliveryorder ");
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
			strSql.Append("select count(1) FROM deliveryorder ");
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
			strSql.Append(")AS Row, T.*  from deliveryorder T ");
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
			parameters[0].Value = "deliveryorder";
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


using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.DAL
{
    public partial class deliveryorder
    {
        /// <summary>
		/// 更新一条数据
		/// </summary>
		public bool UpdateByOrderId(YueYePlat.Model.deliveryorder model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update deliveryorder set ");         
            strSql.Append("DeliveryId=@DeliveryId,");
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
            strSql.Append("Signer=@Signer,");
            strSql.Append("Telephone=@Telephone,");
            strSql.Append("IsBackFee=@IsBackFee,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("IsDeliver=@IsDeliver,");
            strSql.Append("TotalFee=@TotalFee,");
            strSql.Append("ReturnOrderSrc=@ReturnOrderSrc,");
            strSql.Append("ClientReturnOrderSrc=@ClientReturnOrderSrc,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("Terminator=@Terminator,");        
            strSql.Append("PaymentMethod=@PaymentMethod,");
            strSql.Append("LogisCompanyShortName=@LogisCompanyShortName,");
            strSql.Append("LogisCompanyID=@LogisCompanyID,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where DeliveryOrderId=@DeliveryOrderId");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@DeliveryOrderId", MySqlDbType.VarChar,50),
                    new MySqlParameter("@DeliveryId", MySqlDbType.VarChar,50),
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
                    new MySqlParameter("@Signer", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Telephone", MySqlDbType.VarChar,20),
                    new MySqlParameter("@IsBackFee", MySqlDbType.Bit),
                    new MySqlParameter("@Amount", MySqlDbType.Decimal,15),
                    new MySqlParameter("@IsDeliver", MySqlDbType.Bit),
                    new MySqlParameter("@TotalFee", MySqlDbType.Decimal,15),
                    new MySqlParameter("@ReturnOrderSrc", MySqlDbType.VarChar,500),
                    new MySqlParameter("@ClientReturnOrderSrc", MySqlDbType.VarChar,500),
                    new MySqlParameter("@IsEnd", MySqlDbType.Bit),
                    new MySqlParameter("@Terminator", MySqlDbType.VarChar, 50),
                    new MySqlParameter("@PaymentMethod", MySqlDbType.VarChar,50),
                    new MySqlParameter("@LogisCompanyShortName", MySqlDbType.VarChar,200),
                    new MySqlParameter("@LogisCompanyID", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Remark", MySqlDbType.Text),
                    };
            parameters[0].Value = model.DeliveryOrderId;
            parameters[1].Value = model.DeliveryId;
            parameters[2].Value = model.Origin;
            parameters[3].Value = model.BeginTime;
            parameters[4].Value = model.Destination;
            parameters[5].Value = model.Longitude;
            parameters[6].Value = model.Latitude;
            parameters[7].Value = model.PredictDeliveryTime;
            parameters[8].Value = model.DeliveryTime;
            parameters[9].Value = model.ClientId;
            parameters[10].Value = model.ArriveTime;
            parameters[11].Value = model.Receiver;
            parameters[12].Value = model.ReceiverPhone1;
            parameters[13].Value = model.ReceiverPhone2;
            parameters[14].Value = model.ReceiverPhone3;
            parameters[15].Value = model.Signer;
            parameters[16].Value = model.Telephone;
            parameters[17].Value = model.IsBackFee;
            parameters[18].Value = model.Amount;
            parameters[19].Value = model.IsDeliver;
            parameters[20].Value = model.TotalFee;
            parameters[21].Value = model.ReturnOrderSrc;
            parameters[22].Value = model.ClientReturnOrderSrc;
            parameters[23].Value = model.IsEnd;
            parameters[24].Value = model.Terminator;
            parameters[25].Value = model.PaymentMethod;
            parameters[26].Value = model.LogisCompanyShortName;
            parameters[27].Value = model.LogisCompanyID;
            parameters[28].Value = model.Remark;           

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM deliveryorder ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" ORDER BY DeliveryOrderId DESC  LIMIT " + (PageIndex-1)*PageSize+","+PageSize);
            return DbHelperMySQL.Query(strSql.ToString());
        }
    }
}

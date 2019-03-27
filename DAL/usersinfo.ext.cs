using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;

namespace YueYePlat.DAL
{
    public partial class usersinfo
    {
        public DataSet GetModelList(string UserId, string UserPassword)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from usersinfo ");
            strSql.Append(" where (UserId=@UserId or UserMobile=@UserId)   and UserPassword=@UserPassword");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@UserId", MySqlDbType.VarChar,50),
                    new MySqlParameter("@UserPassword", MySqlDbType.VarChar,50)
            };
            parameters[0].Value = UserId;
            parameters[1].Value = UserPassword;            
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            return ds;
        }
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,UserId,UserName,UserMobile,UserSex,UserPassword,UserState,UserTypeId,CompanyId ");
            strSql.Append(" FROM usersinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" LIMIT " + (PageIndex - 1) * PageSize + "," + PageSize);
            return DbHelperMySQL.Query(strSql.ToString());
        }
    }
}

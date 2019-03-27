using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.DAL
{
    public partial class clientinfo
    {
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,ClientId,ClientName,Telephone,Mobile,CompanyId ");
            strSql.Append(" FROM clientinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" LIMIT " + (PageIndex - 1) * PageSize + "," + PageSize);
            return DbHelperMySQL.Query(strSql.ToString());
        }
    }
}

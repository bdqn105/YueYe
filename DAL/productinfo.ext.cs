using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.DAL
{
    public partial  class productinfo
    {
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,ProductId,ProductName,ProductType,Specification,Manufaturer,BatchNum,DataofManufaturer,UnitofMeasurement ");
            strSql.Append(" FROM productinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" LIMIT " + (PageIndex - 1) * PageSize + "," + PageSize);
            return DbHelperMySQL.Query(strSql.ToString());
        }
    }
}

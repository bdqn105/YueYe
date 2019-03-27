using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.BLL
{
    public partial class usersinfo
    {
        public List<YueYePlat.Model.usersinfo> GetModelList(string UserId, string UserPassword)
        {
            DataSet ds = dal.GetModelList(UserId, UserPassword);
            return DataTableToList(ds.Tables[0]);
        }
        public List<YueYePlat.Model.usersinfo> GetModelList(int PageSize, int PageIndex, string strWhere)
        {
            DataSet ds = dal.GetList(PageSize, PageIndex, strWhere);
            return DataTableToList(ds.Tables[0]);
        }
    }
}

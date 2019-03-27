using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.BLL
{
    public partial  class clientinfo
    {
        public List<YueYePlat.Model.clientinfo> GetModelList(int PageSize, int PageIndex, string strWhere)
        {
            DataSet ds = dal.GetList(PageSize, PageIndex, strWhere);
            return DataTableToList(ds.Tables[0]);
        }
    }
}

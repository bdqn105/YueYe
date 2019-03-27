using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.BLL
{
    public partial  class productinfo
    {
        public List<YueYePlat.Model.productinfo> GetModelList(int PageSize, int PageIndex, string strWhere)
        {
            DataSet ds = dal.GetList(PageSize, PageIndex, strWhere);
            return DataTableToList(ds.Tables[0]);
        }
    }
}

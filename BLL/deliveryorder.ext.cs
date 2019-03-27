using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.BLL
{
    public partial class deliveryorder
    {
        /// <summary>
		/// 更新一条数据
		/// </summary>
		public bool UpdateByOrderId(YueYePlat.Model.deliveryorder model)
        {
            return dal.UpdateByOrderId(model);
        }
        public List<YueYePlat.Model.deliveryorder> GetModelList(int PageSize,int PageIndex,string strWhere)
        {
            DataSet ds = dal.GetList(PageSize,PageIndex,strWhere);
            return DataTableToList(ds.Tables[0]);
        }
    }
}

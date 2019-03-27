using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class productdelivery
    {
        string productName;
        string feetype;
        decimal fee;
        string feetypeName;
        decimal totalfee;
        List<YueYePlat.Model.deliveryorderfee> feeList;

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }

        public string Feetype
        {
            get
            {
                return feetype;
            }

            set
            {
                feetype = value;
            }
        }

        public decimal Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        public string FeetypeName
        {
            get
            {
                return feetypeName;
            }

            set
            {
                feetypeName = value;
            }
        }

        public decimal Totalfee
        {
            get
            {
                return totalfee;
            }

            set
            {
                totalfee = value;
            }
        }

        public List<deliveryorderfee> FeeList
        {
            get
            {
                return feeList;
            }

            set
            {
                feeList = value;
            }
        }
    }
}

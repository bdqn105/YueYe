using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class deliveryorderfee
    {
        string productCount;
        string feetypeName;
        decimal totalfee;
        string productName;
        string productId;
        string  productWeight;
        public string ProductCount
        {
            get
            {
                return productCount;
            }

            set
            {
                productCount = value;
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

        public string ProductId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
            }
        }

        public string ProductWeight
        {
            get
            {
                return productWeight;
            }

            set
            {
                productWeight = value;
            }
        }
    }
}

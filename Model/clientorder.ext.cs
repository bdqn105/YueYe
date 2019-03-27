using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class clientorder
    {
        string clientName;
        string isDealName;
        string isDeliveryName;

        public string ClientName
        {
            get
            {
                return clientName;
            }

            set
            {
                clientName = value;
            }
        }

        public string IsDealName
        {
            get
            {
                return isDealName;
            }

            set
            {
                isDealName = value;
            }
        }
       

        public string IsDeliveryName
        {
            get
            {
                return isDeliveryName;
            }

            set
            {
                isDeliveryName = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
 public partial class deliveryorder
    {
        string strCarCodeImage;
        string clientName;
        string ifEndName;
        string terminatorName;
        string auditorName;
        string ifCheckedName;
        string detail;
        string orderfee;
        string deliveryStatus;        
        string recorderName;
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

        public vehicledelivery DeliveryModel
        {
            get
            {
                return deliveryModel;
            }

            set
            {
                deliveryModel = value;
                this.VehicleName = deliveryModel.VehicleId ;
                this.Driver1Id = deliveryModel.Driver1Id;
                this.Driver2Id = deliveryModel.Driver2Id;              
                this.AuditorId = deliveryModel.Auditor;
                this.strCarCode = DeliveryModel.StrCarCode;
              
            }
        }

        public string VehicleName
        {
            get
            {
                return vehicleName;
            }

            set
            {
                vehicleName = value;
            }
        }

        public string Driver1Id
        {
            get
            {
                return driver1Id;
            }

            set
            {
                driver1Id = value;
            }
        }

        public string Driver2Id
        {
            get
            {
                return driver2Id;
            }

            set
            {
                driver2Id = value;
            }
        }
        public string AuditorId
        {
            get
            {
                return auditorId;
            }

            set
            {
                auditorId = value;
            }
        }


        public List<productdelivery> ProductList
        {
            get
            {
                return productList;
            }

            set
            {
                productList = value;
            }
        }

        public string IsDeliverName
        {
            get
            {
                return isDeliverName;
            }

            set
            {
                isDeliverName = value;
            }
        }

        public List<deliveryorderfee> OrderfeeList
        {
            get
            {
                return orderfeeList;
            }

            set
            {
                orderfeeList = value;
            }
        }

        public string IfEndName
        {
            get
            {
                return ifEndName;
            }

            set
            {
                ifEndName = value;
            }
        }

        public string TerminatorName
        {
            get
            {
                return terminatorName;
            }

            set
            {
                terminatorName = value;
            }
        }

        public string AuditorName
        {
            get
            {
                return auditorName;
            }

            set
            {
                auditorName = value;
            }
        }

        public string IfCheckedName
        {
            get
            {
                return ifCheckedName;
            }

            set
            {
                ifCheckedName = value;
            }
        }

        public string StrCarCodeImage
        {
            get
            {
                return strCarCodeImage;
            }

            set
            {
                strCarCodeImage = value;
            }
        }

        public string Detail
        {
            get
            {
                return detail;
            }

            set
            {
                detail = value;
            }
        }

        public string Orderfee
        {
            get
            {
                return orderfee;
            }

            set
            {
                orderfee = value;
            }
        }

        public string DeliveryStatus
        {
            get
            {
                return deliveryStatus;
            }

            set
            {
                deliveryStatus = value;
            }
        }
        public string RecorderName
        {
            get
            {
                return recorderName;
            }

            set
            {
                recorderName = value;
            }
        }

        vehicledelivery deliveryModel;


        string vehicleName;
        string driver1Id;
        string driver2Id;
        string auditorId;
        string strCarCode;
        string isDeliverName;
        List<productdelivery> productList;
        List<deliveryorderfee> orderfeeList;

    }
}

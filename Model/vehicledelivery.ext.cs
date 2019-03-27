using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class vehicledelivery
    {
        string strCarCode;
        string ifEndName;
        string clientId;
        string clientName;
        string driver1Name;
        string driver2Name;
        string vehicleNumber;
        string ifChargebackName;
        string recorderName;
        public string StrCarCode
        {
            get
            {
                return strCarCode;
            }

            set
            {
                strCarCode = value;
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

        public string ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }

        public string Driver1Name
        {
            get
            {
                return driver1Name;
            }

            set
            {
                driver1Name = value;
            }
        }

        public string Driver2Name
        {
            get
            {
                return driver2Name;
            }

            set
            {
                driver2Name = value;
            }
        }

        public string VehicleNumber
        {
            get
            {
                return vehicleNumber;
            }

            set
            {
                vehicleNumber = value;
            }
        }

        public string IfChargebackName
        {
            get
            {
                return ifChargebackName;
            }

            set
            {
                ifChargebackName = value;
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
    }
}

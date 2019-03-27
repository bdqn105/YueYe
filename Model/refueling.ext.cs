using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class refueling
    {
        string vehicleNumber;
        string ifVerifyedName;
        string verfielName;
        string driverName;

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

        public string IfVerifyedName
        {
            get
            {
                return ifVerifyedName;
            }

            set
            {
                ifVerifyedName = value;
            }
        }

        public string VerfielName
        {
            get
            {
                return verfielName;
            }

            set
            {
                verfielName = value;
            }
        }

        public string DriverName
        {
            get
            {
                return driverName;
            }

            set
            {
                driverName = value;
            }
        }
    }
}

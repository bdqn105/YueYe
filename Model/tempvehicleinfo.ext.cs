using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class tempvehicleinfo
    {
        string driverName;
        string vehicleNumber;
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
    }
}

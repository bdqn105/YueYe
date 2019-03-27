using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial  class deviceuseinfo
    {
        string ifbindName;
        string vehicleNumber;
        string deviceName;
        public string IfbindName
        {
            get
            {
                return ifbindName;
            }

            set
            {
                ifbindName = value;
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

        public string DeviceName
        {
            get
            {
                return deviceName;
            }

            set
            {
                deviceName = value;
            }
        }
    }
}

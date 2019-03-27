using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial  class deliverycurgpsinfo
    {
        string vehicleNumber;
        string vehicleId;
        string driver1Id;
        string driver2Id;
        public string VehicleId
        {
            get
            {
                return vehicleId;
            }

            set
            {
                vehicleId = value;
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

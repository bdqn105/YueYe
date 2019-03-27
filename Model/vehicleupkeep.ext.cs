using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class vehicleupkeep
    {
        string vehicleNumber;
        string keepManName;

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

        public string KeepManName
        {
            get
            {
                return keepManName;
            }

            set
            {
                keepManName = value;
            }
        }
    }
}

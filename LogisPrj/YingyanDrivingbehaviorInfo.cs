using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingyanDrivingbehaviorInfo
    {
        double _longitude;
        double _latitude;
        string _coord_type;
        long _loc_time;
        string _address;

        public double longitude
        {
            get
            {
                return _longitude;
            }

            set
            {
                _longitude = value;
            }
        }

        public double latitude
        {
            get
            {
                return _latitude;
            }

            set
            {
                _latitude = value;
            }
        }

        public string coord_type
        {
            get
            {
                return _coord_type;
            }

            set
            {
                _coord_type = value;
            }
        }

        public long loc_time
        {
            get
            {
                return _loc_time;
            }

            set
            {
                _loc_time = value;
            }
        }

        public string address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }
    }
}

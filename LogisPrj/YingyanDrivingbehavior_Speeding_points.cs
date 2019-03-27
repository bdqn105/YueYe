using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingyanDrivingbehavior_Speeding_points
    {
        double _longitude;
        double _latitude;
        string _coord_type;
        long _loc_time;
        double _actual_speed;
        double _limit_speed;

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

        public double actual_speed
        {
            get
            {
                return _actual_speed;
            }

            set
            {
                _actual_speed = value;
            }
        }

        public double limit_speed
        {
            get
            {
                return _limit_speed;
            }

            set
            {
                _limit_speed = value;
            }
        }
    }
}

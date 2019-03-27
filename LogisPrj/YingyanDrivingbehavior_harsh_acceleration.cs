using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingyanDrivingbehavior_harsh_acceleration
    {
        double _longitude;
        double _latitude;
        string _coord_type;
        long _loc_time;
        double _acceleration;
        double _initial_speed;
        double _end_speed;

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

        public double acceleration
        {
            get
            {
                return _acceleration;
            }

            set
            {
                _acceleration = value;
            }
        }

        public double initial_speed
        {
            get
            {
                return _initial_speed;
            }

            set
            {
                _initial_speed = value;
            }
        }

        public double end_speed
        {
            get
            {
                return _end_speed;
            }

            set
            {
                _end_speed = value;
            }
        }
    }
}

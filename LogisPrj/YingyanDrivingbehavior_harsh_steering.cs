using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingyanDrivingbehavior_harsh_steering
    {
        double _longitude;
        double _latitude;
        string _coord_type;
        long _loc_time;
        double _centripetal_acceleration;
        double _turn_type;
        double _speed;

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

        public double centripetal_acceleration
        {
            get
            {
                return _centripetal_acceleration;
            }

            set
            {
                _centripetal_acceleration = value;
            }
        }

        public double turn_type
        {
            get
            {
                return _turn_type;
            }

            set
            {
                _turn_type = value;
            }
        }

        public double speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }
    }
}

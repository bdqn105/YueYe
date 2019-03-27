using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingYanPoint
    {
        double _speed;
        double _longitude;
        double _latitude;
        long _loc_time;
        int _direction;
        DateTime _create_time;

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

        public int direction
        {
            get
            {
                return _direction;
            }

            set
            {
                _direction = value;
            }
        }

        public DateTime create_time
        {
            get
            {
                return _create_time;
            }

            set
            {
                _create_time = value;
            }
        }
    }
}

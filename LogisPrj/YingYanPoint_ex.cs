using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingYanPoint_ex
    {
        double _longitude;
        double _latitude;
        long _loc_time;

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
    }
}

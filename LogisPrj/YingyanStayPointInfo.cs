using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingyanStayPointInfo
    {
        long _start_time;
        long _end_time;
        int duration;
        public YingyanStaypoint_ex stay_point;

        public long Start_time
        {
            get
            {
                return _start_time;
            }

            set
            {
                _start_time = value;
            }
        }

        public long End_time
        {
            get
            {
                return _end_time;
            }

            set
            {
                _end_time = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }
    }
}

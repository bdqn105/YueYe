using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingyanDrivingbehavior
    {
        public int status;
        public string message;
        public double distance;
        public int duration;
        public double average_speed;
        public double max_speed;
        public int speeding_num;
        public int harsh_acceleration_num;
        public int harsh_breaking_num;
        public int harsh_steering_num;
        public YingyanDrivingbehaviorInfo start_point;
        public YingyanDrivingbehaviorInfo end_point;
        public List<YingyanDrivingbehavior_speed> speeding;
        public List<YingyanDrivingbehavior_harsh_acceleration> harsh_acceleration;
        public List<YingyanDrivingbehavior_harsh_acceleration> harsh_breaking;
        public List<YingyanDrivingbehavior_harsh_steering> harsh_steering;

    }
}

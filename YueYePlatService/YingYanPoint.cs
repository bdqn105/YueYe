using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YueYePlatService
{
    public class YingYanPoint
    {
        string _entity_name;
        double _longitude;
        double _latitude;
        long _loc_time;
        string _coord_type_input="bd09ll";
        /// <summary>
        /// 点的名称
        /// </summary>
        public string entity_name
        {
            get
            {
                return _entity_name;
            }

            set
            {
                _entity_name = value;
            }
        }
        /// <summary>
        /// 经度
        /// </summary>
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
        /// <summary>
        /// 纬度
        /// </summary>
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
        /// <summary>
        /// 时间戳
        /// </summary>
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
        /// <summary>
        /// 轨迹点类型，百度为bd09ll
        /// </summary>
        public string coord_type_input
        {
            get
            {
                return _coord_type_input;
            }

            set
            {
                _coord_type_input = value;
            }
        }
    }
}
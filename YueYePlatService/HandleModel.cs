using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YueYePlatService
{
    public class HandleModel
    {
        /// <summary>
        /// 定义操作名称
        /// </summary>
        public string Op
        {
            get;
            set;
        }
        /// <summary>
        /// 处理是否成功
        /// </summary>
        public bool IsSuccess
        {
            get;
            set;
        }
        /// <summary>
        /// 处理后反馈的消息
        /// </summary>
        public string ResultMsg
        {
            get;
            set;
        }
        public object UserInfo
        {
            get;
            set;
        }
        public object UserData
        {
            get;
            set;
        }
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceId
        {
            get;
            set;
        }
    }
}
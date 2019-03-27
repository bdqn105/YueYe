using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class LogInfo
    {
        string topic;
        string message;
        DateTime extimer;

        public string Topic
        {
            get
            {
                return topic;
            }

            set
            {
                topic = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public DateTime Extimer
        {
            get
            {
                return extimer;
            }

            set
            {
                extimer = value;
            }
        }
    }
}

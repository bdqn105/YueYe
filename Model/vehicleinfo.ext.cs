using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class vehicleinfo
    {
        string isBelongstoName;
        string vehicletypeName;

        public string IsBelongstoName
        {
            get
            {
                return isBelongstoName;
            }

            set
            {
                isBelongstoName = value;
            }
        }

        public string VehicletypeName
        {
            get
            {
                return vehicletypeName;
            }

            set
            {
                vehicletypeName = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueYePlat.Model
{
    public partial class usersinfo
    {
       string usersStateName;

        public string UsersStateName
        {
            get
            {
                return usersStateName;
            }

            set
            {
                usersStateName = value;
            }
        }
    }
}

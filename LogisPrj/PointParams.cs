using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class PointParams
    {
        public string funcName;
        public YingYanPoint point;
        public YingYanPoint nextPoint;

        public PointParams(string funcName, YingYanPoint point, YingYanPoint nextPoint)
        {
            this.funcName = funcName;
            this.point = point;
            this.nextPoint = nextPoint;
        }
    }
}

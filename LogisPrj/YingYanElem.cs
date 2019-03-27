using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
    public class YingYanElem
    {
        public int status;
        public string message;
        public int total;
        public int size;
        public double distance;
        public double toll_distance;
        public YingYanPoint_ex start_point;
        public YingYanPoint_ex end_point;
        public List<YingYanPoint> points;
    }
}

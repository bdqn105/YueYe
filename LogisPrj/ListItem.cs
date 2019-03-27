using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisPrj
{
   public class ListItem
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public ListItem(string key,string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value;
        }

    }
}

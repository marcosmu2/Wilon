using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wilon
{
    public class Item
    {
        public string Name { get; set; }
        public bool Value { get; set; }

        public Item(string name, bool value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

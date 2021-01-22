using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class Item<T>
    {
        public readonly T _data;

        public Item<T> previousItem { get; set; }

        public Item(T Data)
        {
            _data = Data;
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AxesoFeng
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

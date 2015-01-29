using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AxesoFeng
{
    public class UpcInventory
    {
        public string upc;
        public string name;
        public int total;
        public UpcInventory(String upc,String name)
        {
            this.upc = upc;
            this.name = name;
            this.total = 0;
        }
    }
}

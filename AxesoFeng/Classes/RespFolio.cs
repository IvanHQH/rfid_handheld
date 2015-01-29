using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AxesoFeng.Classes
{
    public class RespFolio
    {
        public class Products
        {
            public String name;
            public int quantity;
            public string upc;
            public Products(String name, int quantity)
            {
                this.name = name;
                this.quantity = quantity;
            }
        }
        public List<Products> products { get; set; }
    }

}

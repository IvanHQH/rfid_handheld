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
            public String name { get; set; }
            public int quantity { get; set; }
            public String upc { get; set; }
            
            public Products(String name, int quantity)
            {
                this.name = name;
                this.quantity = quantity;
            }

            public Products(String name,String upc, int quantity)
            {
                this.name = name;
                this.quantity = quantity;
                this.upc = upc;
            }
        }
        public List<Products> products { get; set; }
    }

}

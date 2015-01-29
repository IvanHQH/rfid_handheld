using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ReadWriteCsv;

namespace AxesoFeng
{
    public class Warehouses
    {
        public List<Warehouse> collection;

        public Warehouses(String path)
        {
            collection = new List<Warehouse>();
            Warehouse warehouse;
            using (CsvFileReader reader = new CsvFileReader(path))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    warehouse = new Warehouse();
                    warehouse.id = Convert.ToInt32(row[0]);
                    warehouse.name = row[1];
                    collection.Add(warehouse);
                }
            }
        }

        public Warehouse getById(int warehouseId)
        {
            return collection.Find(delegate(Warehouse findWarehouseO)
            {
                bool founded = (findWarehouseO.id == warehouseId);
                return founded;
            });
        }
    }

    public class Warehouse
    {
        public int id { get; set; }
        public String name { get; set; }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using ReadWriteCsv;
using System.IO;

namespace AxesoFeng
{
    public class ProductsList
    {
        public List<Product> items;
        private Dictionary<String, int> UPCindex;
        //private List<string[]> lista;

        public ProductsList(String path)
        {
            items= new List<Product>();
            UPCindex = new Dictionary<string, int>();

            using (CsvFileReader reader = new CsvFileReader(path))
            {
                CsvRow row = new CsvRow();
                Product tempprod;
                while (reader.ReadRow(row))
                {
                    UPCindex.Add(row[0], items.Count);
                    tempprod = new Product();
                    tempprod.id = 1;
                    tempprod.upc = row[0];
                    tempprod.product_name = row[1];
                    items.Add(tempprod);
                }
            }
        }

        public Product getByUPC(String upc)
        {
            return items[UPCindex[upc]];
        }

        public List<Product> getAll()
        {
            return items;
        }

        public bool Exists(String upc)
        {
            return UPCindex.ContainsKey(upc);
        }

        public void saveEPCs(SimpleRFID reader, String folder, String path)
        {
            Directory.CreateDirectory(folder);
            using (CsvFileWriter writer = new CsvFileWriter(path))
            {
                foreach (DictionaryEntry item in reader.m_TagTable)
                {
                    CsvRow row = new CsvRow();
                    row.Add(item.Key.ToString());
                    writer.WriteRow(row);
                }
            }
        }

        public void saveUPCs(SimpleRFID reader, string folder, string path)
        {
            Directory.CreateDirectory(folder);

            using (CsvFileWriter writer = new CsvFileWriter(path))
            {
                foreach (UpcInventory item in reader.fillUPCsInventory(this))
                {
                    CsvRow row = new CsvRow();
                    row.Add(item.upc);
                    row.Add(item.name);
                    row.Add(item.total.ToString());
                    writer.WriteRow(row);
                }
            }
        }
    }
}

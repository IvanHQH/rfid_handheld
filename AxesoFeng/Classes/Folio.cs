using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using System.IO;
using ReadWriteCsv;
using System.Windows.Forms;
using Newtonsoft.Json;
using AxesoFeng.Classes;

namespace AxesoFeng
{
    public class FolioOrder
    {
        private RestClient client;
        string bu;

        public FolioOrder(String BaseUrl)
        {
            client = new RestClient(BaseUrl);
            bu = BaseUrl;
        }

        public List<RespFolio.Products> GetProductsFile(string fileName)
        {
            List<RespFolio.Products> productsFile = new List<RespFolio.Products>();
            using (CsvFileReader reader = new CsvFileReader(fileName))
            {
                CsvRow rowcsv = new CsvRow();
                while (reader.ReadRow(rowcsv))
                {
                    productsFile.Add(new RespFolio.Products(rowcsv[1], int.Parse(rowcsv[2])));
                    //table.addRow(rowcsv[0],rowcsv[1],rowcsv[2]);
                }
            }
            return productsFile;
        }

        public List<string> CompareTo(String path)
        {
            RespFolio respFolio;
            string folio = GetFolio(path);
            string fileName = Path.GetFileName(path);
            respFolio = GETServer(fileName);
            List<string> messages = new List<string>();
            if (respFolio != null)
            {
                List<RespFolio.Products> productsFile = GetProductsFile(fileName);
                messages = CompareTo(productsFile, respFolio);
            }
            return messages;
        }

        public List<string> CompareTo(List<RespFolio.Products> productsFile,String folio)
        {
            RespFolio respFolio;
            respFolio = GETServer(folio);
            List<string> messages = new List<string>();
            if (respFolio != null)
            {
                messages = CompareTo(productsFile, respFolio);
            }
            return messages;
        }

        private List<string> CompareTo(List<RespFolio.Products> productsFile, RespFolio respFolio)
        {
            List<string> Inequalities = new List<string>();
            bool find;
            foreach (RespFolio.Products prodResp in respFolio.products)
            {
                find = false;
                foreach (RespFolio.Products prodFile in productsFile)
                {
                    if (prodResp.name == prodFile.name) {
                        find = true;
                        if (prodResp.quantity != prodFile.quantity){                            
                            Inequalities.Add("hay " + prodFile.quantity.ToString()+ 
                                " de " +prodResp.name+ " se esperaban " + prodResp.quantity);
                            break;
                        }
                    }
                }
                if (find == false)
                    Inequalities.Add(prodResp.name + " no se encuentra");
            }
            foreach (RespFolio.Products prodFile in productsFile)
            {
                find = false;
                foreach (RespFolio.Products prodResp in respFolio.products)
                {
                    if (prodResp.name == prodFile.name){
                        find = true;
                        break;
                        //if (prodResp.quantity != prodFile.quantity){}
                    }
                }
                if (find == false)
                    Inequalities.Add(prodFile.name + " no se esperaba");
            }
            return Inequalities;
        }

        private string GetFolio(string fileName)
        {
            string folio; 
            string[] comp = fileName.Split(new Char[] { '_' });
            try{
                folio = comp[3];
            }
            catch (Exception exc) {
                folio = "";
            }
            return folio;
        }

        private RespFolio GETServer(string folio)
        {
            //Sync sync = new Sync(bu);
            //sync.GET();
            var request = new RestRequest("test_get_folio", Method.POST);
            request.AddParameter("folio", folio);
            IRestResponse<RespFolio> response = client.Execute<RespFolio>(request);
            RespFolio data = JsonConvert.DeserializeObject<RespFolio>(response.Content);
            //RespFolio data = response.Data;

            if (!requestError(response.StatusCode.ToString()))
                return null;

            return data;
        }

        private bool requestError(String StatusCode)
        {
            switch (StatusCode)
            {
                case "0":
                case "NotFound":
                    MessageBox.Show("Error de Red. No se pudieron sincronizar los datos con el servidor. Verifique que tiene su wifi encendida, que tiene acceso a la red y al servidor.", "Error");
                    return false;
                case "Forbidden":
                case "InternalServerError":
                    MessageBox.Show("Error contacte a su administrador.", "Error");
                    return false;
                case "OK":
                    return true;
                default:
                    MessageBox.Show(StatusCode, "Error");
                    return false;
            }
        }

        public static void DeleteFiles()
        {
            Cursor.Current = Cursors.WaitCursor;
            string[] filePaths = Directory.GetFiles(@"\rfiddata");

            foreach (String path in filePaths)
            {
                if (path.Contains("iupc") || path.Contains("oupc") || path.Contains("iepc") 
                    || path.Contains("oepc") || path.Contains("message"))
                {
                    File.Delete(path);
                }
            }
            Cursor.Current = Cursors.Default;
        }

    }
}

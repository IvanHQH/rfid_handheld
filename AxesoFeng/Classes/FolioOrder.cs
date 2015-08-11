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
    public class FolioOrder : BaseFormReader
    {
        private RestClient client;
        string bu;

        public class Folio
        {
            public class Product
            {
                public String upc { get; set; }
                public String name { get; set; }
                public int quantity { get; set; }
            }
            public List<Product> products { get; set; }

        }
        //.configData.url
        public FolioOrder(MenuForm form)
        {
            menu = form;
            client = new RestClient(menu.configData.url);
            bu = menu.configData.url;
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
            string folio = getFolio(path);
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
            //RespFolio respFolio;
            //respFolio = GETServer(folio);
            RespFolio respFolio = getFolioFtp(menu.ftpConfig.server_name,
                menu.ftpConfig.user_name, menu.ftpConfig.user_password, folio);
            //MessageBox.Show("03");
            List<string> messages = new List<string>();
            if (respFolio != null)
            {
                //MessageBox.Show("04");
                messages = CompareTo(productsFile, respFolio);
            }
            return messages;
        }

        private List<string> CompareTo(List<RespFolio.Products> productsFile, RespFolio respFolio)
        {
            List<string> Inequalities = new List<string>();
            bool find;
            //MessageBox.Show("1");
            foreach (RespFolio.Products prodResp in respFolio.products)
            {
                find = false;
                foreach (RespFolio.Products prodFile in productsFile)
                {
                    //MessageBox.Show("2");
                    if (prodResp.name == prodFile.name) {
                        find = true;
                        //MessageBox.Show("3");
                        if (prodResp.quantity != prodFile.quantity){
                            //MessageBox.Show("4");
                            Inequalities.Add(prodFile.quantity.ToString()+ 
                                " de " +prodResp.name+ " esperados "+prodResp.quantity );
                            //MessageBox.Show("5");
                            break;
                        }
                    }
                }
                //MessageBox.Show("6");
                if (find == false)
                {
                    Inequalities.Add(prodResp.name + " Inexistente");
                    //MessageBox.Show("7");
                }
            }
            foreach (RespFolio.Products prodFile in productsFile)
            {
                //MessageBox.Show("8");
                find = false;
                foreach (RespFolio.Products prodResp in respFolio.products)
                {
                    //MessageBox.Show("9");
                    if (prodResp.name == prodFile.name){
                        find = true;
                        //MessageBox.Show("10");
                        break;                        
                    }
                }
                if (find == false)
                    Inequalities.Add(prodFile.name + " Excedente");
            }
            return Inequalities;
        }

        private string getFolio(string fileName)
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

        public RespFolio GETServer(string folio)
        {
            //var request = new RestRequest("test_get_folio", Method.POST);
            //request.AddParameter("folio", folio);
            //IRestResponse<RespFolio> response = client.Execute<RespFolio>(request);
            //RespFolio data = JsonConvert.DeserializeObject<RespFolio>(response.Content);
            //Equipo\GRUPO HQH\\\rfiddata\FOLIO
            StreamReader sreader = new StreamReader(@"\rfiddata\FOLIO\folio.json");
            String json = sreader.ReadToEnd();
            sreader.Close();
            RespFolio data = JsonConvert.DeserializeObject<RespFolio>(json);
            //if (!requestError(response.StatusCode.ToString()))
            //    return null;

            return data;
        }

        public RespFolio getFolioFtp(string serverName, string userName, string userPassword, string fileName)
        {
            var request = new RestRequest("getFolio", Method.POST);
            JsonObject json = new JsonObject();
            RespFolio resp = new RespFolio();
            request.RequestFormat = DataFormat.Json;
            json.Add("server_name", serverName);
            json.Add("user_name", userName);
            json.Add("user_password", userPassword);
            json.Add("file_name", fileName);
            request.AddBody(json);

            IRestResponse<Folio> response = client.Execute<Folio>(request);
            Folio data = response.Data;
            resp.products = new List<RespFolio.Products>();
            if(data != null)
                foreach (Folio.Product prod in data.products)
                    resp.products.Add(new RespFolio.Products(prod.name, prod.upc, prod.quantity));
            return resp;
        }

        public Folio getFolioFtp(string content)
        {
            Folio data = new Folio();
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

        public static void DeleteFiles(String pathFolderName)
        {
            Cursor.Current = Cursors.WaitCursor;
            string[] filePaths = Directory.GetFiles(pathFolderName);

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

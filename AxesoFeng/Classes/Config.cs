using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace AxesoFeng
{
    public class Config
    {
        public String url { get; set; }
        public int id_client { get; set; }
        public int id_user { get; set; }
        public string pwd { get; set; }
        public int version { get; set; }
        public int id_warehouse { get; set; }
        /// <summary>
        /// Match with Global.Version ISCAM = 1,INVENTORY = 2,INVENTORY_PLACE = 3
        /// </summary>

        public static Config getConfig(String path){
            StreamReader sreader = new StreamReader(path);
            String json = sreader.ReadToEnd();
            sreader.Close();
            return JsonConvert.DeserializeObject<Config>(json);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace RfidFolio
{
    public class FtpConfig
    {
        public string server_name { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }

        public static FtpConfig getConfig(String path)
        {
            StreamReader sreader = new StreamReader(path);
            String json = sreader.ReadToEnd();
            sreader.Close();
            return JsonConvert.DeserializeObject<FtpConfig>(json);
        }
    }
}

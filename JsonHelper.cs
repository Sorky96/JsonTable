using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTable
{
    public class JsonHelper
    {
        public dynamic GetJsonObject(string path)
        {
            dynamic json;
            using (StreamReader r = new StreamReader(path))
            {
                string jsonFile = r.ReadToEnd();
                json = JArray.Parse(jsonFile);
            }


            return json;
        }
    }
}

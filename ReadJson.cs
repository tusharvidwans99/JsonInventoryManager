using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonInventoryManagement
{
    public class ReadJson
    {

        public TypesOfInventary ReadtheJson(string path)
        {
            using(StreamReader file = new StreamReader(path))
            {
                try
                {
                    string sfile = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<TypesOfInventary>(sfile);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                
            }
        }

    }
}

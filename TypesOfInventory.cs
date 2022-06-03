using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonInventoryManagement
{
 

    public class TypesOfInventary
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfPulses> typesOfPulses;
        public List<TypesOfWheat> typesOfWheat;

    }
    public class TypesOfRice
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
    public class TypesOfPulses
    {
        public string name { get; set; }
        public int price { get; set; }

        public int weight { get; set; }
    }
    public class TypesOfWheat
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }


}

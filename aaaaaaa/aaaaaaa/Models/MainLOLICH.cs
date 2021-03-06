using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aaaaaaa.Models
{
    public class MainLOLICH
    {
        public int id { get; set; }
        public string anek { get; set; }
        public MainLOLICH()
        {
            
        }
        public MainLOLICH(string id, string anek)
        {
            this.id = int.Parse(id);
            this.anek = anek;
        }
    }
}

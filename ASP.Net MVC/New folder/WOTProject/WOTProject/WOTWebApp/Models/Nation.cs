using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOTWebApp.Models
{
    public class Nation
    {
        public Nation()
        {
            Tanks = new List<Tank>();
        }
        public int NationId { get; set; }
        public string NationName { get; set; }
        public List<Tank> Tanks { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOTWebApp.Models
{
    public class TankType
    {
        public TankType()
        {
            Tanks = new List<Tank>();
        }
        public int TankTypeId { get; set; }
        public string TankTypeName { get; set; }
        public List<Tank> Tanks { get; set; }
    }
}

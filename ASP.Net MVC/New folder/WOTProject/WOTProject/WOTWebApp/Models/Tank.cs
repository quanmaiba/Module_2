using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOTWebApp.Models
{
    public class Tank
    {
        public int TankId { get; set; }
        public string TankName { get; set; }
        public int TankTier { get; set; }
        public int FirePower { get; set; }
        public int Survivability { get; set; }
        public int Mobility { get; set; }
        public int Concealment { get; set; }
        public int Spotting { get; set; }
        public int TankTypeId { get; set; }
        public TankType TankType { get; set; }
        public int NationId { get; set; }
        public Nation Nation { get; set; }
    }
}

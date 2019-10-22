using System;
using System.Collections.Generic;

namespace WoTWithCore
{
    public partial class Tanks
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
        public int NationId { get; set; }

        public virtual Nations Nation { get; set; }
        public virtual TankTypes TankType { get; set; }
    }
}

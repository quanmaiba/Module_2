using System;
using System.Collections.Generic;

namespace WoTWithCore
{
    public partial class TankTypes
    {
        public TankTypes()
        {
            Tanks = new HashSet<Tanks>();
        }

        public int TankTypeId { get; set; }
        public string TankTypeName { get; set; }

        public virtual ICollection<Tanks> Tanks { get; set; }
    }
}

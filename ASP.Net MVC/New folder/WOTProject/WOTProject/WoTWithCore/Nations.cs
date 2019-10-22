using System;
using System.Collections.Generic;

namespace WoTWithCore
{
    public partial class Nations
    {
        public Nations()
        {
            Tanks = new HashSet<Tanks>();
        }

        public int NationId { get; set; }
        public string NationName { get; set; }

        public virtual ICollection<Tanks> Tanks { get; set; }
    }
}

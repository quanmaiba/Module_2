using System;
using System.Collections.Generic;

namespace GameLol.Core
{
    public partial class RoleSkins
    {
        public RoleSkins()
        {
            RoleHeroes = new HashSet<RoleHeroes>();
        }

        public int RoleSkinId { get; set; }
        public string NameRoleSkin { get; set; }

        public ICollection<RoleHeroes> RoleHeroes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GameLol.Core
{
    public partial class RoleHeroes
    {
        public int HeroId { get; set; }
        public int RoleSkinId { get; set; }

        public HeroLols Hero { get; set; }
        public RoleSkins RoleSkin { get; set; }
    }
}

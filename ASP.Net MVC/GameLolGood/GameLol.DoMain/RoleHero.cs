using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameLol.DoMain
{
    public class RoleHero
    {
        [Key]
        public int RoleHeroID { get; set; }
        public string NameRoleSkin { get; set; }
        public List<RoleSkinHero> RoleSkinHero { get; set; }

    }
}

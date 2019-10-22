using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GameLol.DoMain
{
    public class RoleSkin
    {
        [Key]
        public int RoleSkinID { get; set; }
        public string NameRoleSkin { get; set; }
        public List<RoleSkinHero> RoleSkinHeroes { get; set; }

    }
}

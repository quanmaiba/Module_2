using System;
using System.Collections.Generic;

namespace GameLol.Core
{
    public partial class HeroLols
    {
        public HeroLols()
        {
            DescriptionHeroes = new HashSet<DescriptionHeroes>();
            PropertyHeroes = new HashSet<PropertyHeroes>();
            RoleHeroes = new HashSet<RoleHeroes>();
            SkillHeroes = new HashSet<SkillHeroes>();
            SkinHeroes = new HashSet<SkinHeroes>();
        }

        public int HeroId { get; set; }
        public string NameHero { get; set; }
        public int HitRangeHeroId { get; set; }

        public HitRangeHeros HitRangeHero { get; set; }
        public ICollection<DescriptionHeroes> DescriptionHeroes { get; set; }
        public ICollection<PropertyHeroes> PropertyHeroes { get; set; }
        public ICollection<RoleHeroes> RoleHeroes { get; set; }
        public ICollection<SkillHeroes> SkillHeroes { get; set; }
        public ICollection<SkinHeroes> SkinHeroes { get; set; }
    }
}

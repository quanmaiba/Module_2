using System;
using System.Collections.Generic;

namespace GameLol.Core
{
    public partial class HitRangeHeros
    {
        public HitRangeHeros()
        {
            HeroLols = new HashSet<HeroLols>();
        }

        public int HitRangeHeroId { get; set; }
        public string NameHitRangeHero { get; set; }

        public ICollection<HeroLols> HeroLols { get; set; }
    }
}

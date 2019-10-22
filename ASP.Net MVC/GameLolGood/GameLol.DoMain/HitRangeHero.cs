using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameLol.DoMain
{
    public class HitRangeHero
    {
        [Key]
        public int HitRangeHeroID { get; set; }
        public string NameHitRangeHero { get; set; }
        public List<HeroLol> HeroLols { get; set; }
    }
}

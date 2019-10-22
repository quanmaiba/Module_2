using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameLol.DoMain
{
    public class HeroLol
    {
        [Key]
        public int HeroID { get; set; }
        public string NameHero { get; set; }
        public List<DescriptionHero> Descriptions { get; set; }
        public List<SkillHero> SkillHeroes { get; set; }
        public List<SkinHero> SkinHeroes { get; set; }
        public List<RoleSkinHero> RoleSkinHeroes { get; set; }
        public List<PropertyHero> PropertyHeroes { get; set; }
        public HitRangeHero HitRangeHero { get; set; }
      
    }
}

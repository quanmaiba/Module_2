using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Hero
{
    public class HeroView
    {
        public int HeroID { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string NameHero { get; set; }
        //public List<DescriptionHero> Descriptions { get; set; }
        //public List<SkillHero> SkillHeroes { get; set; }
        //public List<SkinHero> SkinHeroes { get; set; }
        //public List<RoleSkinHero> RoleSkinHeroes { get; set; }
        //public List<PropertyHero> PropertyHeroes { get; set; }
        //public HitRangeHero HitRangeHero { get; set; }
        //public int HitRangeHeroID { get; set; }

    }
}

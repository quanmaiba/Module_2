using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GameLol.DoMain
{
    public class DescriptionHero
    {
        [Key]
        public int DescriptionHeroID { get; set; }
        public string NameDescriptionHero { get; set; }
        public string DescriptionOfHero { get; set; }
        public HeroLol HeroLol { get; set; }
        public int HeroID { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GameLol.Core
{
    public partial class DescriptionHeroes
    {
        public int DescriptionHeroId { get; set; }
        public string NameDescriptionHero { get; set; }
        public string DescriptionOfHero { get; set; }
        public int HeroId { get; set; }

        public HeroLols Hero { get; set; }
    }
}

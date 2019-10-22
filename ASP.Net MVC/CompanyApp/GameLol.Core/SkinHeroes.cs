using System;
using System.Collections.Generic;

namespace GameLol.Core
{
    public partial class SkinHeroes
    {
        public int SkinHeroId { get; set; }
        public string NameSkinHero { get; set; }
        public string DescriptionSkinHero { get; set; }
        public int HeroId { get; set; }

        public HeroLols Hero { get; set; }
    }
}

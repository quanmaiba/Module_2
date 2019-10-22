using System;
using System.Collections.Generic;

namespace GameLol.Core
{
    public partial class PropertyHeroes
    {
        public int PropertyId { get; set; }
        public string NamePoperty { get; set; }
        public double RateProperty { get; set; }
        public int HeroId { get; set; }

        public HeroLols Hero { get; set; }
    }
}

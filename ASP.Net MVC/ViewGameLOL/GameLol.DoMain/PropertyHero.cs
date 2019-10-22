using System.ComponentModel.DataAnnotations;

namespace GameLol.DoMain
{
    public class PropertyHero
    {
        [Key]
        public int PropertyID { get; set; }
        public string NamePoperty { get; set; }
        public double RateProperty { get; set; }
        public HeroLol HeroLol { get; set; }
        public int HeroID { get; set; }
    }
}

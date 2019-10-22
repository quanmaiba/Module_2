using System.ComponentModel.DataAnnotations;

namespace GameLol.DoMain
{
    public class SkinHero
    {
        [Key]
        public int SkinHeroID { get; set; }
        public string NameSkinHero { get; set; }
        public string DescriptionSkinHero { get; set; }
        public HeroLol HeroLol { get; set; }
        public int HeroID { get; set; }
    }
}

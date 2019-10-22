using System.ComponentModel.DataAnnotations;

namespace GameLol.DoMain
{
    public class SkillHero
    {
        [Key]
        public int SkillHeroId { get; set; }
        [Required, StringLength(2)]
        public string NameSkillHero { get; set; }
        [Required, StringLength(2)]
        public string DescriptionSkinHero { get; set; }
        public HeroLol HeroLol { get; set; }
        public int HeroID { get; set; }

    }
}

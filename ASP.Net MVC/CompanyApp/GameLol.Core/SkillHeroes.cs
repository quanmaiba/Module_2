using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameLol.Core
{
    public partial class SkillHeroes
    {
        public int SkillHeroId { get; set; }
        [Required(AllowEmptyStrings =true,ErrorMessage ="Nhap vao")]
        public string NameSkillHero { get; set; }
        public string DescriptionSkinHero { get; set; }
        public int HeroId { get; set; }
        public HeroLols Hero { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (NameSkillHero == "quan")
        //    {
        //        yield return new ValidationResult("dung ui", new[] { "NameSkillHero" });
        //    }
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameLol.Data;
using GameLol.DoMain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageGameLol.Pages.SkillHeros
{
    public class DetailModel : PageModel
    {
        private readonly ISkillHero skillHero;

        public DetailModel(ISkillHero skillHero)
        {
            this.skillHero = skillHero;
        }
        public SkillHero SkillHero { get; set; }
        public IActionResult OnGet(int skillId)
        {
            SkillHero = skillHero.GetById(skillId);
            if (SkillHero == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
using GameLol.Data;
using GameLol.DoMain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RazorPageGameLol.Pages.SkillHeros
{
    public class IndexModel : PageModel
    {
        private readonly ISkillHero skillHero;

        public IndexModel(ISkillHero skillHero)
        {
            this.skillHero = skillHero;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchKeyWord { get; set; }
        public IEnumerable<SkillHero> skillHeroes { get; set; }
        public void OnGet()
        {
            skillHeroes = skillHero.GetStudentByName(SearchKeyWord);
        }
    }
}
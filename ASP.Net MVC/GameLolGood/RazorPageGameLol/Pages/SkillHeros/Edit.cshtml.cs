using GameLol.Data;
using GameLol.DoMain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace RazorPageGameLol.Pages.SkillHeros
{
    public class EditModel : PageModel
    {
        private readonly ISkillHero skillHero;

        [BindProperty]
        public SkillHero SkillHero { get; set; }
        public EditModel(ISkillHero skillHero)
        {
            this.skillHero = skillHero;
        }
        public IActionResult OnGet(int? skill)
        {
            if (skill.HasValue)
            {
                SkillHero = skillHero.GetById(skill.Value);
            }
            if (SkillHero == null)
            {
                SkillHero = new SkillHero();

            }
            return Page();

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (SkillHero.SkillHeroId > 0)
            {
                skillHero.Update(SkillHero);
            }
            else
            {
                skillHero.Add(SkillHero);
            }
            try
            {
                skillHero.Commit();
               
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
            return RedirectToPage("./Index", new { skill = SkillHero.SkillHeroId });
        }
    }
}
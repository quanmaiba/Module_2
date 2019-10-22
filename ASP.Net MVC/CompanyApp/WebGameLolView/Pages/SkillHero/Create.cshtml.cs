using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GameLol.Core;

namespace WebGameLolView.Pages.SkillHero
{
    public class CreateModel : PageModel
    {
        private readonly GameLol.Core.GameLoLViewNewContext _context;

        public CreateModel(GameLol.Core.GameLoLViewNewContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["HeroId"] = new SelectList(_context.HeroLols, "HeroId", "HeroId");
            return Page();
        }

        [BindProperty]
        public SkillHeroes SkillHeroes { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SkillHeroes.Add(SkillHeroes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameLol.Core;

namespace WebGameLolView.Pages.SkillHero
{
    public class EditModel : PageModel
    {
        private readonly GameLol.Core.GameLoLViewNewContext _context;

        public EditModel(GameLol.Core.GameLoLViewNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SkillHeroes SkillHeroes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SkillHeroes = await _context.SkillHeroes
                .Include(s => s.Hero).FirstOrDefaultAsync(m => m.SkillHeroId == id);

            if (SkillHeroes == null)
            {
                return NotFound();
            }
           ViewData["HeroId"] = new SelectList(_context.HeroLols, "HeroId", "HeroId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SkillHeroes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillHeroesExists(SkillHeroes.SkillHeroId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SkillHeroesExists(int id)
        {
            return _context.SkillHeroes.Any(e => e.SkillHeroId == id);
        }
    }
}

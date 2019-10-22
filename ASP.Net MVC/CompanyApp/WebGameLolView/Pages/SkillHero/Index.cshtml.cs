using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameLol.Core;

namespace WebGameLolView.Pages.SkillHero
{
    public class IndexModel : PageModel
    {
        private readonly GameLol.Core.GameLoLViewNewContext _context;

        public IndexModel(GameLol.Core.GameLoLViewNewContext context)
        {
            _context = context;
        }

        public IList<SkillHeroes> SkillHeroes { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var movies = from m in _context.SkillHeroes
                         select m;
            SkillHeroes = await _context.SkillHeroes
                .Include(s => s.Hero).ToListAsync();
        }
    }
}

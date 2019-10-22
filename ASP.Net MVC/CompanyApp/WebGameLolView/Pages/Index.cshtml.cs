using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameLol.Core;

namespace WebGameLolView.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GameLol.Core.GameLoLViewNewContext _context;

        public IndexModel(GameLol.Core.GameLoLViewNewContext context)
        {
            _context = context;
        }

        public IList<HeroLols> HeroLols { get;set; }

        public async Task OnGetAsync()
        {
            HeroLols = await _context.HeroLols
                .Include(h => h.HitRangeHero).ToListAsync();
        }
    }
}

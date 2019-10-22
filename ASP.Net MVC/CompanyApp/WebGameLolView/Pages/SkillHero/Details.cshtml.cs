﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameLol.Core;

namespace WebGameLolView.Pages.SkillHero
{
    public class DetailsModel : PageModel
    {
        private readonly GameLol.Core.GameLoLViewNewContext _context;

        public DetailsModel(GameLol.Core.GameLoLViewNewContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
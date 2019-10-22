using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameLol.AppData;
using GameLol.DoMain;

namespace ViewGameLOL.WebData.Controllers
{
    public class SkillHeroesController : Controller
    {
        private readonly GameLolContext _context;

        public SkillHeroesController(GameLolContext context)
        {
            _context = context;
        }

        // GET: SkillHeroes
        public async Task<IActionResult> Index()
        {
            var gameLolContext = _context.SkillHeroes.Include(s => s.HeroLol);
            return View(await gameLolContext.ToListAsync());
        }

        // GET: SkillHeroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillHero = await _context.SkillHeroes
                .Include(s => s.HeroLol)
                .FirstOrDefaultAsync(m => m.SkillHeroId == id);
            if (skillHero == null)
            {
                return NotFound();
            }

            return View(skillHero);
        }

        // GET: SkillHeroes/Create
        public IActionResult Create()
        {
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID");
            return View();
        }

        // POST: SkillHeroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SkillHeroId,NameSkillHero,DescriptionSkinHero,HeroID")] SkillHero skillHero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skillHero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", skillHero.HeroID);
            return View(skillHero);
        }

        // GET: SkillHeroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillHero = await _context.SkillHeroes.FindAsync(id);
            if (skillHero == null)
            {
                return NotFound();
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", skillHero.HeroID);
            return View(skillHero);
        }

        // POST: SkillHeroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SkillHeroId,NameSkillHero,DescriptionSkinHero,HeroID")] SkillHero skillHero)
        {
            if (id != skillHero.SkillHeroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skillHero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillHeroExists(skillHero.SkillHeroId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", skillHero.HeroID);
            return View(skillHero);
        }

        // GET: SkillHeroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillHero = await _context.SkillHeroes
                .Include(s => s.HeroLol)
                .FirstOrDefaultAsync(m => m.SkillHeroId == id);
            if (skillHero == null)
            {
                return NotFound();
            }

            return View(skillHero);
        }

        // POST: SkillHeroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skillHero = await _context.SkillHeroes.FindAsync(id);
            _context.SkillHeroes.Remove(skillHero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillHeroExists(int id)
        {
            return _context.SkillHeroes.Any(e => e.SkillHeroId == id);
        }
    }
}

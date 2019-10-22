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
    public class SkinHeroesController : Controller
    {
        private readonly GameLolContext _context;

        public SkinHeroesController(GameLolContext context)
        {
            _context = context;
        }

        // GET: SkinHeroes
        public async Task<IActionResult> Index()
        {
            var gameLolContext = _context.SkinHeroes.Include(s => s.HeroLol);
            return View(await gameLolContext.ToListAsync());
        }

        // GET: SkinHeroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skinHero = await _context.SkinHeroes
                .Include(s => s.HeroLol)
                .FirstOrDefaultAsync(m => m.SkinHeroID == id);
            if (skinHero == null)
            {
                return NotFound();
            }

            return View(skinHero);
        }

        // GET: SkinHeroes/Create
        public IActionResult Create()
        {
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID");
            return View();
        }

        // POST: SkinHeroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SkinHeroID,NameSkinHero,DescriptionSkinHero,HeroID")] SkinHero skinHero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skinHero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", skinHero.HeroID);
            return View(skinHero);
        }

        // GET: SkinHeroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skinHero = await _context.SkinHeroes.FindAsync(id);
            if (skinHero == null)
            {
                return NotFound();
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", skinHero.HeroID);
            return View(skinHero);
        }

        // POST: SkinHeroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SkinHeroID,NameSkinHero,DescriptionSkinHero,HeroID")] SkinHero skinHero)
        {
            if (id != skinHero.SkinHeroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skinHero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkinHeroExists(skinHero.SkinHeroID))
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
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", skinHero.HeroID);
            return View(skinHero);
        }

        // GET: SkinHeroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skinHero = await _context.SkinHeroes
                .Include(s => s.HeroLol)
                .FirstOrDefaultAsync(m => m.SkinHeroID == id);
            if (skinHero == null)
            {
                return NotFound();
            }

            return View(skinHero);
        }

        // POST: SkinHeroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skinHero = await _context.SkinHeroes.FindAsync(id);
            _context.SkinHeroes.Remove(skinHero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkinHeroExists(int id)
        {
            return _context.SkinHeroes.Any(e => e.SkinHeroID == id);
        }
    }
}

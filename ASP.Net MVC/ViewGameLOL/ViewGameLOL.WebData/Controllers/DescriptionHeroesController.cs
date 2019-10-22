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
    public class DescriptionHeroesController : Controller
    {
        private readonly GameLolContext _context;

        public DescriptionHeroesController(GameLolContext context)
        {
            _context = context;
        }

        // GET: DescriptionHeroes
        public async Task<IActionResult> Index()
        {
            var gameLolContext = _context.DescriptionHeroes.Include(d => d.HeroLol);
            return View(await gameLolContext.ToListAsync());
        }

        // GET: DescriptionHeroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptionHero = await _context.DescriptionHeroes
                .Include(d => d.HeroLol)
                .FirstOrDefaultAsync(m => m.DescriptionHeroID == id);
            if (descriptionHero == null)
            {
                return NotFound();
            }

            return View(descriptionHero);
        }

        // GET: DescriptionHeroes/Create
        public IActionResult Create()
        {
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID");
            ViewBag.Heros = _context.HeroLols.ToList();
            return View();
        }

        // POST: DescriptionHeroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DescriptionHeroID,NameDescriptionHero,HeroID,DescriptionOfHero,DescriptionOfHero")] DescriptionHero descriptionHero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(descriptionHero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", descriptionHero.HeroID);
            return View(descriptionHero);
        }

        // GET: DescriptionHeroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptionHero = await _context.DescriptionHeroes.FindAsync(id);
            if (descriptionHero == null)
            {
                return NotFound();
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", descriptionHero.HeroID);
            return View(descriptionHero);
        }

        // POST: DescriptionHeroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DescriptionHeroID,NameDescriptionHero,HeroID,DescriptionOfHero")] DescriptionHero descriptionHero)
        {
            if (id != descriptionHero.DescriptionHeroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(descriptionHero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DescriptionHeroExists(descriptionHero.DescriptionHeroID))
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
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", descriptionHero.HeroID);
            return View(descriptionHero);
        }

        // GET: DescriptionHeroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var descriptionHero = await _context.DescriptionHeroes
                .Include(d => d.HeroLol)
                .FirstOrDefaultAsync(m => m.DescriptionHeroID == id);
            if (descriptionHero == null)
            {
                return NotFound();
            }

            return View(descriptionHero);
        }

        // POST: DescriptionHeroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var descriptionHero = await _context.DescriptionHeroes.FindAsync(id);
            _context.DescriptionHeroes.Remove(descriptionHero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DescriptionHeroExists(int id)
        {
            return _context.DescriptionHeroes.Any(e => e.DescriptionHeroID == id);
        }
    }
}

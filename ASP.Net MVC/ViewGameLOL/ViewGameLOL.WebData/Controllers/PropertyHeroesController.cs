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
    public class PropertyHeroesController : Controller
    {
        private readonly GameLolContext _context;

        public PropertyHeroesController(GameLolContext context)
        {
            _context = context;
        }

        // GET: PropertyHeroes
        public async Task<IActionResult> Index()
        {
            var gameLolContext = _context.PropertyHeroes.Include(p => p.HeroLol);
            return View(await gameLolContext.ToListAsync());
        }

        // GET: PropertyHeroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyHero = await _context.PropertyHeroes
                .Include(p => p.HeroLol)
                .FirstOrDefaultAsync(m => m.PropertyID == id);
            if (propertyHero == null)
            {
                return NotFound();
            }

            return View(propertyHero);
        }

        // GET: PropertyHeroes/Create
        public IActionResult Create()
        {
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID");
            return View();
        }

        // POST: PropertyHeroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyID,NamePoperty,RateProperty,HeroID")] PropertyHero propertyHero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propertyHero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", propertyHero.HeroID);
            return View(propertyHero);
        }

        // GET: PropertyHeroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyHero = await _context.PropertyHeroes.FindAsync(id);
            if (propertyHero == null)
            {
                return NotFound();
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", propertyHero.HeroID);
            return View(propertyHero);
        }

        // POST: PropertyHeroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyID,NamePoperty,RateProperty,HeroID")] PropertyHero propertyHero)
        {
            if (id != propertyHero.PropertyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propertyHero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyHeroExists(propertyHero.PropertyID))
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
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", propertyHero.HeroID);
            return View(propertyHero);
        }

        // GET: PropertyHeroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyHero = await _context.PropertyHeroes
                .Include(p => p.HeroLol)
                .FirstOrDefaultAsync(m => m.PropertyID == id);
            if (propertyHero == null)
            {
                return NotFound();
            }

            return View(propertyHero);
        }

        // POST: PropertyHeroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propertyHero = await _context.PropertyHeroes.FindAsync(id);
            _context.PropertyHeroes.Remove(propertyHero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyHeroExists(int id)
        {
            return _context.PropertyHeroes.Any(e => e.PropertyID == id);
        }
    }
}

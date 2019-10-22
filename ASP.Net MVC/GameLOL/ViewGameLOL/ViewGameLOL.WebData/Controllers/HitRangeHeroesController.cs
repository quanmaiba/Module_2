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
    public class HitRangeHeroesController : Controller
    {
        private readonly GameLolContext _context;

        public HitRangeHeroesController(GameLolContext context)
        {
            _context = context;
        }

        // GET: HitRangeHeroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.HitRangeHeros.ToListAsync());
        }

        // GET: HitRangeHeroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hitRangeHero = await _context.HitRangeHeros
                .FirstOrDefaultAsync(m => m.HitRangeHeroID == id);
            if (hitRangeHero == null)
            {
                return NotFound();
            }

            return View(hitRangeHero);
        }

        // GET: HitRangeHeroes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HitRangeHeroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HitRangeHeroID,NameHitRangeHero")] HitRangeHero hitRangeHero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hitRangeHero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hitRangeHero);
        }

        // GET: HitRangeHeroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hitRangeHero = await _context.HitRangeHeros.FindAsync(id);
            if (hitRangeHero == null)
            {
                return NotFound();
            }
            return View(hitRangeHero);
        }

        // POST: HitRangeHeroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HitRangeHeroID,NameHitRangeHero")] HitRangeHero hitRangeHero)
        {
            if (id != hitRangeHero.HitRangeHeroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hitRangeHero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HitRangeHeroExists(hitRangeHero.HitRangeHeroID))
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
            return View(hitRangeHero);
        }

        // GET: HitRangeHeroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hitRangeHero = await _context.HitRangeHeros
                .FirstOrDefaultAsync(m => m.HitRangeHeroID == id);
            if (hitRangeHero == null)
            {
                return NotFound();
            }

            return View(hitRangeHero);
        }

        // POST: HitRangeHeroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hitRangeHero = await _context.HitRangeHeros.FindAsync(id);
            _context.HitRangeHeros.Remove(hitRangeHero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HitRangeHeroExists(int id)
        {
            return _context.HitRangeHeros.Any(e => e.HitRangeHeroID == id);
        }
    }
}

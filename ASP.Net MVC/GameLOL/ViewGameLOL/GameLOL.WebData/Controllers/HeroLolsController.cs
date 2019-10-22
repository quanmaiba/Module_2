using GameLol.AppData;
using GameLol.DoMain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GameLOL.WebData.Controllers
{
    public class HeroLolsController : Controller
    {
        private readonly GameLolContext _context;

        public HeroLolsController(GameLolContext context)
        {
            _context = context;
        }

        // GET: HeroLols
        public async Task<IActionResult> Index()
        {
            var gameLolContext = _context.HeroLols.Include(h => h.HitRangeHero);
            return View(await gameLolContext.ToListAsync());
        }

        // GET: HeroLols/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heroLol = await _context.HeroLols
                .Include(h => h.HitRangeHero)
                .FirstOrDefaultAsync(m => m.HeroID == id);
            if (heroLol == null)
            {
                return NotFound();
            }

            return View(heroLol);
        }

        // GET: HeroLols/Create
        public IActionResult Create()
        {
            ViewData["HitRangeHeroID"] = new SelectList(_context.HitRangeHeros, "HitRangeHeroID", "NameHitRangeHero");
            //ViewBag.Hero = _context.HitRangeHeros.ToList();
            return View();
        }

        // POST: HeroLols/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HeroID,NameHero,HitRangeHeroID")] HeroLol heroLol)
        {
            if (ModelState.IsValid)
            {
                _context.Add(heroLol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HitRangeHeroID"] = new SelectList(_context.HitRangeHeros, "HitRangeHeroID", "HitRangeHeroID", heroLol.HitRangeHeroID);
            return View(heroLol);
        }

        // GET: HeroLols/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heroLol = await _context.HeroLols.FindAsync(id);
            if (heroLol == null)
            {
                return NotFound();
            }
            ViewData["HitRangeHeroID"] = new SelectList(_context.HitRangeHeros, "HitRangeHeroID", "HitRangeHeroID", heroLol.HitRangeHeroID);
            return View(heroLol);
        }

        // POST: HeroLols/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HeroID,NameHero,HitRangeHeroID")] HeroLol heroLol)
        {
            if (id != heroLol.HeroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(heroLol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeroLolExists(heroLol.HeroID))
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
            ViewData["HitRangeHeroID"] = new SelectList(_context.HitRangeHeros, "HitRangeHeroID", "HitRangeHeroID", heroLol.HitRangeHeroID);
            return View(heroLol);
        }

        // GET: HeroLols/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heroLol = await _context.HeroLols
                .Include(h => h.HitRangeHero)
                .FirstOrDefaultAsync(m => m.HeroID == id);
            if (heroLol == null)
            {
                return NotFound();
            }

            return View(heroLol);
        }

        // POST: HeroLols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var heroLol = await _context.HeroLols.FindAsync(id);
            _context.HeroLols.Remove(heroLol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeroLolExists(int id)
        {
            return _context.HeroLols.Any(e => e.HeroID == id);
        }
    }
}

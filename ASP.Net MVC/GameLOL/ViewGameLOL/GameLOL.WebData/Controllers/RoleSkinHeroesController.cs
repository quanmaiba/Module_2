using GameLol.AppData;
using GameLol.DoMain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GameLOL.WebData.Controllers
{
    public class RoleSkinHeroesController : Controller
    {
        private readonly GameLolContext _context;

        public RoleSkinHeroesController(GameLolContext context)
        {
            _context = context;
        }

        // GET: RoleSkinHeroes
        public async Task<IActionResult> Index()
        {
            var gameLolContext = _context.RoleHeroes.Include(r => r.HeroLol).Include(r => r.RoleSkin);
            return View(await gameLolContext.ToListAsync());
        }

        // GET: RoleSkinHeroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleSkinHero = await _context.RoleHeroes
                .Include(r => r.HeroLol)
                .Include(r => r.RoleSkin)
                .FirstOrDefaultAsync(m => m.HeroID == id);
            if (roleSkinHero == null)
            {
                return NotFound();
            }

            return View(roleSkinHero);
        }

        // GET: RoleSkinHeroes/Create
        public IActionResult Create()
        {
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "NameHero");
            ViewData["RoleSkinID"] = new SelectList(_context.RoleSkins, "RoleSkinID", "NameRoleSkin");
            ViewBag.Hero = _context.HeroLols.ToList();
            ViewBag.Role = _context.RoleSkins.ToList();
            return View();
        }

        // POST: RoleSkinHeroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HeroID,RoleSkinID")] RoleSkinHero roleSkinHero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roleSkinHero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", roleSkinHero.HeroID);
            ViewData["RoleSkinID"] = new SelectList(_context.RoleSkins, "RoleSkinID", "RoleSkinID", roleSkinHero.RoleSkinID);
            return View(roleSkinHero);
        }

        // GET: RoleSkinHeroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleSkinHero = await _context.RoleHeroes.FindAsync(id);
            if (roleSkinHero == null)
            {
                return NotFound();
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", roleSkinHero.HeroID);
            ViewData["RoleSkinID"] = new SelectList(_context.RoleSkins, "RoleSkinID", "RoleSkinID", roleSkinHero.RoleSkinID);
            return View(roleSkinHero);
        }

        // POST: RoleSkinHeroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HeroID,RoleSkinID")] RoleSkinHero roleSkinHero)
        {
            if (id != roleSkinHero.HeroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleSkinHero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleSkinHeroExists(roleSkinHero.HeroID))
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
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", roleSkinHero.HeroID);
            ViewData["RoleSkinID"] = new SelectList(_context.RoleSkins, "RoleSkinID", "RoleSkinID", roleSkinHero.RoleSkinID);
            return View(roleSkinHero);
        }

        // GET: RoleSkinHeroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleSkinHero = await _context.RoleHeroes
                .Include(r => r.HeroLol)
                .Include(r => r.RoleSkin)
                .FirstOrDefaultAsync(m => m.HeroID == id);
            if (roleSkinHero == null)
            {
                return NotFound();
            }

            return View(roleSkinHero);
        }

        // POST: RoleSkinHeroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roleSkinHero = await _context.RoleHeroes.FindAsync(id);
            _context.RoleHeroes.Remove(roleSkinHero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleSkinHeroExists(int id)
        {
            return _context.RoleHeroes.Any(e => e.HeroID == id);
        }
    }
}

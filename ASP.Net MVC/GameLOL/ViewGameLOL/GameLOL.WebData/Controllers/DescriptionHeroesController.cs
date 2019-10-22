using GameLol.AppData;
using GameLol.DoMain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GameLOL.WebData.Controllers
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
    
        public IActionResult AddOrEdit(int id = 0)
        {
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "NameHero");
            if (id == 0)
            {
                return View(new DescriptionHero());
            }
            else
            {
                return View(_context.DescriptionHeroes.Find(id));
            }
                       
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("DescriptionHeroID,NameDescriptionHero,DescriptionOfHero,HeroID")] DescriptionHero descriptionHero)
        {
            if (ModelState.IsValid)
            {
                if (descriptionHero.DescriptionHeroID == 0)
                {
                    _context.Add(descriptionHero);
                }
                else
                {
                    _context.Update(descriptionHero);
                }              
               await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["HeroID"] = new SelectList(_context.HeroLols, "HeroID", "HeroID", descriptionHero.HeroID);
            return View(descriptionHero);
        }
        
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            var descriptionHero = await _context.DescriptionHeroes.FindAsync(id);
            _context.DescriptionHeroes.Remove(descriptionHero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      
    }
}

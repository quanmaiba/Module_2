using GameLol.AppData;
using GameLol.DoMain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GameLOL.WebData.Controllers
{
    public class RoleSkinsController : Controller
    {
        private readonly GameLolContext _context;

        public RoleSkinsController(GameLolContext context)
        {
            _context = context;
        }

        // GET: RoleSkins
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoleSkins.ToListAsync());
        }

        // GET: RoleSkins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleSkin = await _context.RoleSkins
                .FirstOrDefaultAsync(m => m.RoleSkinID == id);
            if (roleSkin == null)
            {
                return NotFound();
            }

            return View(roleSkin);
        }

        // GET: RoleSkins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoleSkins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleSkinID,NameRoleSkin")] RoleSkin roleSkin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roleSkin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roleSkin);
        }

        // GET: RoleSkins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleSkin = await _context.RoleSkins.FindAsync(id);
            if (roleSkin == null)
            {
                return NotFound();
            }
            return View(roleSkin);
        }

        // POST: RoleSkins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoleSkinID,NameRoleSkin")] RoleSkin roleSkin)
        {
            if (id != roleSkin.RoleSkinID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleSkin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleSkinExists(roleSkin.RoleSkinID))
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
            return View(roleSkin);
        }

        // GET: RoleSkins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleSkin = await _context.RoleSkins
                .FirstOrDefaultAsync(m => m.RoleSkinID == id);
            if (roleSkin == null)
            {
                return NotFound();
            }

            return View(roleSkin);
        }

        // POST: RoleSkins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roleSkin = await _context.RoleSkins.FindAsync(id);
            _context.RoleSkins.Remove(roleSkin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleSkinExists(int id)
        {
            return _context.RoleSkins.Any(e => e.RoleSkinID == id);
        }
    }
}

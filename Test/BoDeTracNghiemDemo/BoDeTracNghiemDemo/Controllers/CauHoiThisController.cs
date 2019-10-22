using BoDeTracNghiemDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BoDeTracNghiemDemo.Controllers
{
    public class CauHoiThisController : Controller
    {
        private readonly AppDataConText _context;

        public CauHoiThisController(AppDataConText context)
        {
            _context = context;
        }

        // GET: CauHoiThis
        public async Task<IActionResult> Index()
        {
            var appDataConText = _context.CauHoiThi.Include(c => c.CauHoi).Include(c => c.Thi);
            return View(await appDataConText.ToListAsync());
        }

        // GET: CauHoiThis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoiThi = await _context.CauHoiThi
                .Include(c => c.CauHoi)
                .Include(c => c.Thi)
                .FirstOrDefaultAsync(m => m.CauHoiId == id);
            if (cauHoiThi == null)
            {
                return NotFound();
            }

            return View(cauHoiThi);
        }

        // GET: CauHoiThis/Create
        public IActionResult Create()
        {
            ViewData["CauHoiId"] = new SelectList(_context.CauHois, "CauHoiId", "TenCauHoi");
            ViewData["ThiId"] = new SelectList(_context.Thi, "ThiId", "TenThi");
            return View();
        }

        // POST: CauHoiThis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CauHoiId,ThiId")] CauHoiThi cauHoiThi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cauHoiThi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CauHoiId"] = new SelectList(_context.CauHois, "CauHoiId", "CauTraLoi1", cauHoiThi.CauHoiId);
            ViewData["ThiId"] = new SelectList(_context.Thi, "ThiId", "TenThi", cauHoiThi.ThiId);
            return View(cauHoiThi);
        }

        // GET: CauHoiThis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoiThi = await _context.CauHoiThi.FindAsync(id);
            if (cauHoiThi == null)
            {
                return NotFound();
            }
            ViewData["CauHoiId"] = new SelectList(_context.CauHois, "CauHoiId", "CauTraLoi1", cauHoiThi.CauHoiId);
            ViewData["ThiId"] = new SelectList(_context.Thi, "ThiId", "TenThi", cauHoiThi.ThiId);
            return View(cauHoiThi);
        }

        // POST: CauHoiThis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CauHoiId,ThiId")] CauHoiThi cauHoiThi)
        {
            if (id != cauHoiThi.CauHoiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cauHoiThi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CauHoiThiExists(cauHoiThi.CauHoiId))
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
            ViewData["CauHoiId"] = new SelectList(_context.CauHois, "CauHoiId", "CauTraLoi1", cauHoiThi.CauHoiId);
            ViewData["ThiId"] = new SelectList(_context.Thi, "ThiId", "TenThi", cauHoiThi.ThiId);
            return View(cauHoiThi);
        }

        // GET: CauHoiThis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoiThi = await _context.CauHoiThi
                .Include(c => c.CauHoi)
                .Include(c => c.Thi)
                .FirstOrDefaultAsync(m => m.CauHoiId == id);
            if (cauHoiThi == null)
            {
                return NotFound();
            }

            return View(cauHoiThi);
        }

        // POST: CauHoiThis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cauHoiThi = await _context.CauHoiThi.FindAsync(id);
            _context.CauHoiThi.Remove(cauHoiThi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CauHoiThiExists(int id)
        {
            return _context.CauHoiThi.Any(e => e.CauHoiId == id);
        }
    }
}

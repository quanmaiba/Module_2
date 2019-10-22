using BoDeTracNghiemDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BoDeTracNghiemDemo.Controllers
{
    public class CauHoisController : Controller
    {
        private readonly AppDataConText _context;

        public CauHoisController(AppDataConText context)
        {
            _context = context;
        }

        // GET: CauHois
        public async Task<IActionResult> Index()
        {
            var appDataConText = _context.CauHois.Include(c => c.TheLoai);
            return View(await appDataConText.ToListAsync());
        }

        // GET: CauHois/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoi = await _context.CauHois
                .Include(c => c.TheLoai)
                .FirstOrDefaultAsync(m => m.CauHoiId == id);
            if (cauHoi == null)
            {
                return NotFound();
            }

            return View(cauHoi);
        }

        // GET: CauHois/Create
        public IActionResult Create()
        {
            ViewData["TheLoaiId"] = new SelectList(_context.TheLoais, "TheLoaiId", "TenTheLoai");
            return View();
        }

        // POST: CauHois/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CauHoiId,TenCauHoi,CauTraLoi1,CauTraLoi2,CauTraLoi3,CauTraLoi4,TheLoaiId")] CauHoi cauHoi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cauHoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TheLoaiId"] = new SelectList(_context.TheLoais, "TheLoaiId", "TenTheLoai", cauHoi.TheLoaiId);
            return View(cauHoi);
        }

        // GET: CauHois/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoi = await _context.CauHois.FindAsync(id);
            if (cauHoi == null)
            {
                return NotFound();
            }
            ViewData["TheLoaiId"] = new SelectList(_context.TheLoais, "TheLoaiId", "TenTheLoai", cauHoi.TheLoaiId);
            return View(cauHoi);
        }

        // POST: CauHois/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CauHoiId,TenCauHoi,CauTraLoi1,CauTraLoi2,CauTraLoi3,CauTraLoi4,TheLoaiId")] CauHoi cauHoi)
        {
            if (id != cauHoi.CauHoiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cauHoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CauHoiExists(cauHoi.CauHoiId))
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
            ViewData["TheLoaiId"] = new SelectList(_context.TheLoais, "TheLoaiId", "TenTheLoai", cauHoi.TheLoaiId);
            return View(cauHoi);
        }

        // GET: CauHois/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoi = await _context.CauHois
                .Include(c => c.TheLoai)
                .FirstOrDefaultAsync(m => m.CauHoiId == id);
            if (cauHoi == null)
            {
                return NotFound();
            }

            return View(cauHoi);
        }

        // POST: CauHois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cauHoi = await _context.CauHois.FindAsync(id);
            _context.CauHois.Remove(cauHoi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CauHoiExists(int id)
        {
            return _context.CauHois.Any(e => e.CauHoiId == id);
        }
    }
}

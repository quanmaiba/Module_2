using BoDeTracNghiemDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BoDeTracNghiemDemo.Controllers
{
    public class DapAnsController : Controller
    {
        private readonly AppDataConText _context;

        public DapAnsController(AppDataConText context)
        {
            _context = context;
        }

        // GET: DapAns
        public async Task<IActionResult> Index()
        {
            var appDataConText = _context.DapAns.Include(d => d.CauHoi);
            return View(await appDataConText.ToListAsync());
        }

        // GET: DapAns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dapAn = await _context.DapAns
                .Include(d => d.CauHoi)
                .FirstOrDefaultAsync(m => m.DapAnId == id);
            if (dapAn == null)
            {
                return NotFound();
            }

            return View(dapAn);
        }

        // GET: DapAns/Create
        public IActionResult Create()
        {
            ViewData["CauHoiId"] = new SelectList(_context.CauHois, "CauHoiId", "TenCauHoi");
            return View();
        }

        // POST: DapAns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DapAnId,TenDapAn,TenCauHoi")] DapAn dapAn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dapAn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CauHoiId"] = new SelectList(_context.CauHois, "CauHoiId", "TenCauHoi", dapAn.CauHoiId);
            return View(dapAn);
        }

        // GET: DapAns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dapAn = await _context.DapAns.FindAsync(id);
            if (dapAn == null)
            {
                return NotFound();
            }
            ViewData["CauHoiId"] = new SelectList(_context.CauHois, "CauHoiId", "TenCauHoi", dapAn.CauHoiId);
            return View(dapAn);
        }

        // POST: DapAns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DapAnId,TenDapAn,CauHoiId")] DapAn dapAn)
        {
            if (id != dapAn.DapAnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dapAn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DapAnExists(dapAn.DapAnId))
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
            ViewData["CauHoiId"] = new SelectList(_context.CauHois, "CauHoiId", "TenCauHoi", dapAn.CauHoiId);
            return View(dapAn);
        }

        // GET: DapAns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dapAn = await _context.DapAns
                .Include(d => d.CauHoi)
                .FirstOrDefaultAsync(m => m.DapAnId == id);
            if (dapAn == null)
            {
                return NotFound();
            }

            return View(dapAn);
        }

        // POST: DapAns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dapAn = await _context.DapAns.FindAsync(id);
            _context.DapAns.Remove(dapAn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DapAnExists(int id)
        {
            return _context.DapAns.Any(e => e.DapAnId == id);
        }
    }
}

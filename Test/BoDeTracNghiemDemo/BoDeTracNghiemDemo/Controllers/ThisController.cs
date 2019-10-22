using BoDeTracNghiemDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoDeTracNghiemDemo.Controllers
{
    public class ThisController : Controller
    {
        private readonly AppDataConText _context;

        public ThisController(AppDataConText context)
        {
            _context = context;
        }

        // GET: This
        public async Task<IActionResult> Index()
        {
            var appDataConText = _context.Thi.Include(t => t.NguoiDung);
            return View(await appDataConText.ToListAsync());
        }

        [HttpGet]
        public IActionResult List()
        {
            var appDataConText = _context.CauHoiThi.Include(t => t.CauHoi)
                .Include(c => c.Thi).ToList();

            //var listCauHoi = appDataContext.CauHoi.ToList();
            var cauHois = new List<CauHoiThi>();
            var i = 0;
            var rd = new Random();
            while (i < 2)
            {
                int a = rd.Next(0, appDataConText.Count);
                cauHois.Add(appDataConText.ToArray()[a]);
                appDataConText.RemoveAt(a);
                i++;
            }
            return View(cauHois);
        }

        [HttpPost]
        public IActionResult List(List<string> id)
        {
            return View();
        }

        // GET: This/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thi = await _context.Thi
                .Include(t => t.NguoiDung)
                .FirstOrDefaultAsync(m => m.ThiId == id);
            if (thi == null)
            {
                return NotFound();
            }

            return View(thi);
        }

        // GET: This/Create
        public IActionResult Create()
        {
            ViewData["NguoiDungId"] = new SelectList(_context.NguoiDungs, "NguoiDungId", "DiaChi");
            return View();
        }

        // POST: This/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ThiId,TenThi,NguoiDungId")] Thi thi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NguoiDungId"] = new SelectList(_context.NguoiDungs, "NguoiDungId", "DiaChi", thi.NguoiDungId);
            return View(thi);
        }

        // GET: This/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thi = await _context.Thi.FindAsync(id);
            if (thi == null)
            {
                return NotFound();
            }
            ViewData["NguoiDungId"] = new SelectList(_context.NguoiDungs, "NguoiDungId", "DiaChi", thi.NguoiDungId);
            return View(thi);
        }

        // POST: This/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ThiId,TenThi,NguoiDungId")] Thi thi)
        {
            if (id != thi.ThiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThiExists(thi.ThiId))
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
            ViewData["NguoiDungId"] = new SelectList(_context.NguoiDungs, "NguoiDungId", "DiaChi", thi.NguoiDungId);
            return View(thi);
        }

        // GET: This/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thi = await _context.Thi
                .Include(t => t.NguoiDung)
                .FirstOrDefaultAsync(m => m.ThiId == id);
            if (thi == null)
            {
                return NotFound();
            }

            return View(thi);
        }

        // POST: This/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thi = await _context.Thi.FindAsync(id);
            _context.Thi.Remove(thi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThiExists(int id)
        {
            return _context.Thi.Any(e => e.ThiId == id);
        }
    }
}

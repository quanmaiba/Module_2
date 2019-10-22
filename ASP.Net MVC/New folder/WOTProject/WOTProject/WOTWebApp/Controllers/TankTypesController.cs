using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOTWebApp.Context;
using WOTWebApp.Models;

namespace WOTWebApp.Controllers
{
    public class TankTypesController : Controller
    {
        private readonly WotContext _context;

        public TankTypesController(WotContext context)
        {
            _context = context;
        }

        // GET: TankTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TankTypes.ToListAsync());
        }

        // GET: TankTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tankType = await _context.TankTypes
                .FirstOrDefaultAsync(m => m.TankTypeId == id);
            if (tankType == null)
            {
                return NotFound();
            }

            return View(tankType);
        }

        // GET: TankTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TankTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TankTypeId,TankTypeName")] TankType tankType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tankType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tankType);
        }

        // GET: TankTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tankType = await _context.TankTypes.FindAsync(id);
            if (tankType == null)
            {
                return NotFound();
            }
            return View(tankType);
        }

        // POST: TankTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TankTypeId,TankTypeName")] TankType tankType)
        {
            if (id != tankType.TankTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tankType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TankTypeExists(tankType.TankTypeId))
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
            return View(tankType);
        }

        // GET: TankTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tankType = await _context.TankTypes
                .FirstOrDefaultAsync(m => m.TankTypeId == id);
            if (tankType == null)
            {
                return NotFound();
            }

            return View(tankType);
        }

        // POST: TankTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tankType = await _context.TankTypes.FindAsync(id);
            _context.TankTypes.Remove(tankType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TankTypeExists(int id)
        {
            return _context.TankTypes.Any(e => e.TankTypeId == id);
        }
    }
}

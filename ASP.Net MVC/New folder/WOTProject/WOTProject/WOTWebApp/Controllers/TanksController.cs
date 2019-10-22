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
    public class TanksController : Controller
    {
        private readonly WotContext _context;

        public TanksController(WotContext context)
        {
            _context = context;
        }

        // GET: Tanks
        public async Task<IActionResult> Index()
        {
            var wotContext = _context.Tanks.Include(t => t.Nation).Include(t => t.TankType);
            return View(await wotContext.ToListAsync());
        }

        // GET: Tanks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tank = await _context.Tanks
                .Include(t => t.Nation)
                .Include(t => t.TankType)
                .FirstOrDefaultAsync(m => m.TankId == id);
            if (tank == null)
            {
                return NotFound();
            }

            return View(tank);
        }

        // GET: Tanks/Create
        public IActionResult Create()
        {
            ViewData["NationId"] = new SelectList(_context.Nations, "NationId", "NationName");
            ViewData["TankTypeId"] = new SelectList(_context.TankTypes, "TankTypeId", "TankTypeName");
            return View();
        }

        // POST: Tanks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TankId,TankName,TankTier,FirePower,Survivability,Mobility,Concealment,Spotting,TankTypeId,NationId")] Tank tank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NationId"] = new SelectList(_context.Nations, "NationId", "NationId", tank.NationId);
            ViewData["TankTypeId"] = new SelectList(_context.TankTypes, "TankTypeId", "TankTypeId", tank.TankTypeId);
            return View(tank);
        }

        // GET: Tanks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tank = await _context.Tanks.FindAsync(id);
            if (tank == null)
            {
                return NotFound();
            }
            ViewData["NationId"] = new SelectList(_context.Nations, "NationId", "NationName", tank.NationId);
            ViewData["TankTypeId"] = new SelectList(_context.TankTypes, "TankTypeId", "TankTypeName", tank.TankTypeId);
            return View(tank);
        }

        // POST: Tanks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TankId,TankName,TankTier,FirePower,Survivability,Mobility,Concealment,Spotting,TankTypeId,NationId")] Tank tank)
        {
            if (id != tank.TankId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TankExists(tank.TankId))
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
            ViewData["NationId"] = new SelectList(_context.Nations, "NationId", "NationId", tank.NationId);
            ViewData["TankTypeId"] = new SelectList(_context.TankTypes, "TankTypeId", "TankTypeId", tank.TankTypeId);
            return View(tank);
        }

        // GET: Tanks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tank = await _context.Tanks
                .Include(t => t.Nation)
                .Include(t => t.TankType)
                .FirstOrDefaultAsync(m => m.TankId == id);
            if (tank == null)
            {
                return NotFound();
            }

            return View(tank);
        }

        // POST: Tanks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tank = await _context.Tanks.FindAsync(id);
            _context.Tanks.Remove(tank);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TankExists(int id)
        {
            return _context.Tanks.Any(e => e.TankId == id);
        }
    }
}

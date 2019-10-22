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
    public class NationsController : Controller
    {
        private readonly WotContext _context;

        public NationsController(WotContext context)
        {
            _context = context;
        }

        // GET: Nations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nations.ToListAsync());
        }

        // GET: Nations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nation = await _context.Nations
                .FirstOrDefaultAsync(m => m.NationId == id);
            if (nation == null)
            {
                return NotFound();
            }

            return View(nation);
        }

        // GET: Nations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NationId,NationName")] Nation nation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nation);
        }

        // GET: Nations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nation = await _context.Nations.FindAsync(id);
            if (nation == null)
            {
                return NotFound();
            }
            return View(nation);
        }

        // POST: Nations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NationId,NationName")] Nation nation)
        {
            if (id != nation.NationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NationExists(nation.NationId))
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
            return View(nation);
        }

        // GET: Nations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nation = await _context.Nations
                .FirstOrDefaultAsync(m => m.NationId == id);
            if (nation == null)
            {
                return NotFound();
            }

            return View(nation);
        }

        // POST: Nations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nation = await _context.Nations.FindAsync(id);
            _context.Nations.Remove(nation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NationExists(int id)
        {
            return _context.Nations.Any(e => e.NationId == id);
        }
    }
}

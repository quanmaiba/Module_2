using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameLol.AppData;
using GameLol.DoMain;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroLolsController : ControllerBase
    {
        private readonly GameLolContext _context;

        public HeroLolsController(GameLolContext context)
        {
            _context = context;
        }

        // GET: api/HeroLols
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeroLol>>> GetHeroLols()
        {
            return await _context.HeroLols.ToListAsync();
        }

        // GET: api/HeroLols/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HeroLol>> GetHeroLol(int id)
        {
            var heroLol = await _context.HeroLols.FindAsync(id);

            if (heroLol == null)
            {
                return NotFound();
            }

            return heroLol;
        }

        // PUT: api/HeroLols/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHeroLol(int id, HeroLol heroLol)
        {
            if (id != heroLol.HeroID)
            {
                return BadRequest();
            }

            _context.Entry(heroLol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroLolExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HeroLols
        [HttpPost]
        public async Task<ActionResult<HeroLol>> PostHeroLol(HeroLol heroLol)
        {
            _context.HeroLols.Add(heroLol);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHeroLol), new { id = heroLol.HeroID }, heroLol);
        }

        // DELETE: api/HeroLols/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HeroLol>> DeleteHeroLol(int id)
        {
            var heroLol = await _context.HeroLols.FindAsync(id);
            if (heroLol == null)
            {
                return NotFound();
            }

            _context.HeroLols.Remove(heroLol);
            await _context.SaveChangesAsync();

            return heroLol;
        }

        private bool HeroLolExists(int id)
        {
            return _context.HeroLols.Any(e => e.HeroID == id);
        }
    }
}

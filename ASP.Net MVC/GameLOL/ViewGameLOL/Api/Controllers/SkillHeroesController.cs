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
    public class SkillHeroesController : ControllerBase
    {
        private readonly GameLolContext _context;

        public SkillHeroesController(GameLolContext context)
        {
            _context = context;
        }

        // GET: api/SkillHeroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillHero>>> GetSkillHeroes()
        {
            return await _context.SkillHeroes.ToListAsync();
        }

        // GET: api/SkillHeroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillHero>> GetSkillHero(int id)
        {
            var skillHero = await _context.SkillHeroes.FindAsync(id);

            if (skillHero == null)
            {
                return NotFound();
            }

            return skillHero;
        }

        // PUT: api/SkillHeroes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillHero(int id, SkillHero skillHero)
        {
            if (id != skillHero.SkillHeroId)
            {
                return BadRequest();
            }

            _context.Entry(skillHero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillHeroExists(id))
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

        // POST: api/SkillHeroes
        [HttpPost]
        public async Task<ActionResult<SkillHero>> PostSkillHero(SkillHero skillHero)
        {
            _context.SkillHeroes.Add(skillHero);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSkillHero), new { id = skillHero.SkillHeroId }, skillHero);
        }

        // DELETE: api/SkillHeroes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SkillHero>> DeleteSkillHero(int id)
        {
            var skillHero = await _context.SkillHeroes.FindAsync(id);
            if (skillHero == null)
            {
                return NotFound();
            }

            _context.SkillHeroes.Remove(skillHero);
            await _context.SaveChangesAsync();

            return skillHero;
        }

        private bool SkillHeroExists(int id)
        {
            return _context.SkillHeroes.Any(e => e.SkillHeroId == id);
        }
    }
}

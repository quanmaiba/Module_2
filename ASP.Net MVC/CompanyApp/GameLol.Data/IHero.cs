using System;
using System.Collections.Generic;
using System.Text;
using GameLol.Core;
using System.Linq;

namespace GameLol.Data
{
    public interface IHero
    {
        IEnumerable<HeroLols> GetAll(string name);
    }
    public class InHero : IHero
    {
        private readonly GameLoLViewNewContext _context;
        public InHero(GameLoLViewNewContext context)
        {
            _context = context;
        }

        public IEnumerable<HeroLols> GetAll(string name = null)
        {
            return from c in _context.HeroLols
                   where string.IsNullOrEmpty(name) || c.NameHero.ToLower().StartsWith(name.ToLower())
                   orderby c.NameHero
                   select c;
        }
    }
}

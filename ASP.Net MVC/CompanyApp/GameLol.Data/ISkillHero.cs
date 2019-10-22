using System;
using System.Collections.Generic;
using System.Text;
using GameLol.Core;
using System.Linq;

namespace GameLol.Data
{
    public interface ISkillHero
    {
        IEnumerable<SkillHeroes> GetSkillByName(string name);
    }
    public class InSkillHeroData : ISkillHero
    {
        private readonly GameLoLViewNewContext _context;
        public InSkillHeroData(GameLoLViewNewContext context )
        {
            _context = context;

        }

        public IEnumerable<SkillHeroes> GetSkillByName(string name)
        {
            return from c in _context.SkillHeroes
                   where string.IsNullOrEmpty(name) || c.NameSkillHero.ToLower().StartsWith(name.ToLower())
                   orderby c.NameSkillHero
                   select c;
        }
    }
}

using GameLol.DoMain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GameLol.Data
{
    public class SqlSkillHeroData : ISkillHero
    {
        private readonly GameLolContext context;

        public SqlSkillHeroData(GameLolContext context)
        {
            this.context = context;
        }
        public SkillHero Add(SkillHero skillHero)
        {
            var addSkill = context.SkillHeroes.Attach(skillHero);
            addSkill.State = EntityState.Added;

            return skillHero;
        }

        public int Commit()
        {
            return context.SaveChanges();
        }

        public SkillHero Delete(int id)
        {
            var skill = GetById(id);
            if (skill != null)
            {
                context.SkillHeroes.Remove(skill);
            }
            return skill;
        }

        public SkillHero GetById(int id)
        {
            return context.SkillHeroes.Find(id);
        }

        public IEnumerable<SkillHero> GetStudentByName(string name)
        {
            var result = from c in context.SkillHeroes
                         where string.IsNullOrEmpty(name) || c.NameSkillHero.StartsWith(name)
                         select c;
            return result;
        }

        public SkillHero Update(SkillHero updateSKill)
        {
            var entity = context.SkillHeroes.Attach(updateSKill);
            entity.State = EntityState.Modified;
            return updateSKill;
        }
    }
}

using GameLol.DoMain;
using System.Collections.Generic;

namespace GameLol.Data
{
    public interface ISkillHero
    {
        IEnumerable<SkillHero> GetStudentByName(string name);
        SkillHero GetById(int id);
        SkillHero Update(SkillHero updateSkill);
        SkillHero Add(SkillHero skillHero);
        SkillHero Delete(int id);
        int Commit();
    }
}

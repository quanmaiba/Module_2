using System.Collections.Generic;
using System.Linq;
using WoTWithCore;

namespace WotWithData
{
    public class SqlTankData : ITankData
    {
        private readonly WOTINFORContext dbContext;

        public SqlTankData(WOTINFORContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Tanks GetById(int tankId)
        {
            return dbContext.Tanks.SingleOrDefault(t => t.TankId == tankId);
        }

        public IEnumerable<Tanks> GetData(string name)
        {
            return from c in dbContext.Tanks
                   where string.IsNullOrEmpty(name) || c.TankName.ToLower().StartsWith(name.ToLower())
                   orderby c.TankName
                   select c;
        }
    }
}

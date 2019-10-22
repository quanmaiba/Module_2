using System;
using System.Collections.Generic;
using System.Text;
using WoTWithCore;

namespace WotWithData
{
    public interface ITankData
    {
        IEnumerable<Tanks> GetData(string name);
        Tanks GetById(int tankId);



    }
}

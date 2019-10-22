using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoTWithCore;
using WotWithData;

namespace WoTWithBs4.Pages.Wot
{
    public class TankModel : PageModel
    {
        private readonly ITankData tankData;

        public IEnumerable<Tanks> Tanks { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchKeyword { get; set; }

        public TankModel(ITankData tankData)
        {
            this.tankData = tankData;
        }
        public void OnGet()
        {
            Tanks = tankData.GetData(SearchKeyword);
        }

    }
}



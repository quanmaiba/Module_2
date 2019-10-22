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
    public class DetailModel : PageModel
    {
        private readonly ITankData tankData;

        public DetailModel(ITankData tankData)
        {
            this.tankData = tankData;
        }

        public Tanks tank { get; set; }

        public IActionResult OnGet(int TankId)
        {
            tank = new Tanks();
            tank = tankData.GetById(TankId);
            if (tank == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
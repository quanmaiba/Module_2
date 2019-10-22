using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WotWithData;

namespace WoTWithBs4.Pages.Wot
{
    public class EditModel : PageModel
    {
        private readonly ITankData tankNewData;

        public EditModel(ITankData tankNewData)
        {
            this.tankNewData = tankNewData;
        }
        public void OnGet()
        {

        }
    }
}
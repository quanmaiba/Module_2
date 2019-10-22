using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Model;

namespace RazorPage.Pages.QLSach
{
    public class DetailModel : PageModel
    {
        private readonly QuanLySachContext context;

        public DetailModel(QuanLySachContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public QuanLySach QuanLySach { get; set; }
        [TempData]
        public string Message { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            QuanLySach = GetById(id);

            if (QuanLySach == null)
            {
                return NotFound();
            }

            return Page();
        }
        public QuanLySach GetById(int id)
        {
            return context.QuanLySachs.Find(id);
        }
        
    }
}
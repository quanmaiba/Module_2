

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage.Model;

namespace RazorPage.Pages.QLSach
{
    public class IndexModel : PageModel
    {
        private readonly QuanLySachContext context;

        public IndexModel(QuanLySachContext context)
        {
            this.context = context;
        }
        public IEnumerable<QuanLySach> QuanLySaches { get; set; }
        [TempData]
        public string Message { get; set; }
        public QuanLySach QuanLySach { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchKeyWord { get; set; }
        public async Task<IActionResult> OnGet()
        {
           
           // QuanLySaches = await context.QuanLySachs.ToListAsync();
           QuanLySaches = GetStudentByName(SearchKeyWord);

            return Page();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var student = await context.QuanLySachs.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            context.QuanLySachs.Remove(student);
            await context.SaveChangesAsync();
            Message = "Delete Finish";
            return RedirectToPage("Index");
        }
        public IEnumerable<QuanLySach> GetStudentByName(string name)
        {
           
            var result = from m in context.QuanLySachs
                         select m;

            if (!String.IsNullOrEmpty(name))
            {
                result = result.Where(s => s.TenSach.Contains(name));
            }

            return result;
        }      
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPage.Model;
using static RazorPage.Model.QuanLySach;

namespace RazorPage.Pages.QLSach
{
    public class AddOrEditModel : PageModel
    {
        private readonly QuanLySachContext context;

        public AddOrEditModel(QuanLySachContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public QuanLySach QuanLySach { get; set; }
        [TempData]
        public string Message { get; set; }
        public IActionResult OnGet(int id)
        {
            var TheLoai = Enum.GetValues(typeof(TheLoai));
            ViewData["TheLoai"] = new SelectList(TheLoai);
            if (id == 0)
            {
                QuanLySach = new QuanLySach();
            }
            else
            {              
                QuanLySach = context.QuanLySachs.Find(id);
            }
           
            return Page();
        
        }
        public async Task<IActionResult> OnPost()
        {

            if (QuanLySach.Id == 0)
            {
                context.Attach(QuanLySach).State = EntityState.Added;
                Message = "Create Finish";
                await context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                context.Attach(QuanLySach).State = EntityState.Modified;
                Message = "Update Finish";
            }
            await context.SaveChangesAsync();

            return RedirectToPage("Detail", new { id = QuanLySach.Id });
        }

    }
}
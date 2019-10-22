using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursosCrudRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CursosCrudRazor.Pages.ListStudents
{
    public class AddOrEditModel : PageModel
    {
        private readonly StudenContext context;

        public AddOrEditModel(StudenContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public Student Student { get; set; }
        [TempData]
        public string Message { get; set; }
        public IActionResult OnGet(int id)
        {
            var Skills = Enum.GetValues(typeof(Skill));
            ViewData["Skill"] = new SelectList(Skills);
            if (id == 0)
            {
                new Student();
            }
            else
            {
                if (id == 0)
                {
                    return NotFound();
                }
                else
                {
                    Student = context.Students.Find(id);
                }
               
            }

            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
           
            if (Student.Id == 0)
            {
                context.Attach(Student).State = EntityState.Added;
                Message = "Create Finish";
                await context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                context.Attach(Student).State = EntityState.Modified;
                Message = "Update Finish";
            }
            await context.SaveChangesAsync();

            return RedirectToPage("Detail", new { id = Student.Id });
        }
    }
}
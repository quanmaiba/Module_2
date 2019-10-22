using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursosCrudRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace CursosCrudRazor.Pages.ListStudents
{
    public class IndexModel : PageModel
    {
        private readonly StudenContext context;

        public IndexModel(StudenContext context)
        {
            this.context = context;
        }
        public IEnumerable<Student> Students { get; set; }
        [TempData]
        public string Message { get; set; }
        public Student Student { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchKeyWord { get; set; }
        public async Task<IActionResult> OnGet()
        {
           //Students = await context.Students.ToListAsync();
          
            Students = GetStudentByName(SearchKeyWord);
            
            return Page();
        }
       
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            context.Students.Remove(student);
            await context.SaveChangesAsync();
            Message = "Delete Finish";
            return RedirectToPage("Index");
        }
        public IEnumerable<Student> GetStudentByName(string name)
        {
            var result = from s in context.Students
                         where string.IsNullOrEmpty(name) || s.Name.StartsWith(name)
                         select s;

            return result;
        }
        public Student GetById(int id)
        {
            return context.Students.Find(id);
        }
    }
}
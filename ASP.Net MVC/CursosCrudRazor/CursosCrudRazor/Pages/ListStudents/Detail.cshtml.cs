using CursosCrudRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace CursosCrudRazor.Pages.ListStudents
{
    public class DetailModel : PageModel
    {
        private readonly StudenContext context;

        public DetailModel(StudenContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public Student Student { get; set; }
        [TempData]
        public string Message { get; set; }
        
        public async Task<IActionResult> OnGet(int id)
        {
            Student = GetById(id);

            if (Student == null)
            {
                return NotFound();
            }
           
            return Page();
        }
        public Student GetById(int id)
        {
            return context.Students.Find(id);
        }
    }
}
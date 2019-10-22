using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompanyDemo.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompanyDemo.Data;

namespace CompanyApp.Pages.Company
{
    public class DetailModel : PageModel
    {
        private readonly ICompanyData companyData;

        public CompanyDemo.Core.Company company { get; set; }

        public DetailModel(ICompanyData companyData)
        {
            this.companyData = companyData;
        }
        public IActionResult OnGet(int companyId)
        {
            company = new CompanyDemo.Core.Company();
            company = companyData.GetById(companyId);
            if(company == null)
            {
                //Response.StatusCode = 404;
                //return null;
                return RedirectToPage("./NotFound");
            }
            return Page();
            }
    }
}
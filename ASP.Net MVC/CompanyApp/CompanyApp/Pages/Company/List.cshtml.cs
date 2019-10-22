
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Collections.Generic;
using CompanyC7.Core;
using CompanyC7.Data;

namespace CompanyApp.Pages.Company
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly ICompanyData companyData;

        public string Message { get; set; }
        public IEnumerable<CompanyC7.Core.Company> Companies { get; set; }
        public ListModel(IConfiguration config,ICompanyData companyData)
        {
            this.config = config;
            this.companyData = companyData;
        }
        public void OnGet()
        {
            Message = config["Mesage"];
            Companies = companyData.GetAll();

        }
    }
}
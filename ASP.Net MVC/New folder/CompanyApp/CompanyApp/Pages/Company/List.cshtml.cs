using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyDemo.Data;
using CompanyDemo.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CompanyApp.Pages.Company
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly ICompanyData companyData;

        public string Message { get; set; }

        [BindProperty (SupportsGet = true)]
        public string SearchKeyWord { get; set; }
        public IEnumerable<CompanyDemo.Core.Company> Companies { get; set; }
        public ListModel(IConfiguration config, ICompanyData companyData)
        {
            this.config = config;
            this.companyData = companyData;
        }

        public void OnGet()
        {
            Message = config["Message"];
            Companies = companyData.GetCompaniesByName(SearchKeyWord);
        }
    }
}
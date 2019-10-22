using System;
using System.Collections.Generic;
using CompanyDemo.Core;
using System.Linq;

namespace CompanyDemo.Data
{
    public interface ICompanyData
    {
        IEnumerable<Company> GetCompaniesByName(string name);
        Company GetById(int companyId);
    }

    public class InMemoryCompanyData: ICompanyData
    {
        public List<Company> companies { get; set; }

        public InMemoryCompanyData()
        {
            companies = new List<Company>()
            {
                new Company{Id=1,Name = "LNQ",Address="Lào Cai",CompanyType = CompanyType.CNTT},
                new Company{Id=2,Name = "Vĩ",Address="Huế",CompanyType = CompanyType.Traibao},
                new Company{Id=3,Name = "Oke con dê",Address="Hải phòng",CompanyType = CompanyType.Traibao}
            };
        }

        public IEnumerable<Company> GetCompaniesByName(string name = null)
        {
            return from c in companies
                   where string.IsNullOrEmpty(name) || c.Name.StartsWith(name)
                   orderby c.Name
                   select c;
        }

        public Company GetById(int companyId)
        {
            return companies.SingleOrDefault(c => c.Id == companyId);
        }
    }
}

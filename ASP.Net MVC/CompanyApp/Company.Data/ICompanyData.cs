using System;
using System.Collections.Generic;
using CompanyC7.Core;
using System.Linq;
namespace CompanyC7.Data
{
    public interface ICompanyData
    {
        IEnumerable<Core.Company> GetByName();
        Company Add();
        Company Delete();
        Company GetById(int id );
        Company Edit();
        int Update();


    }
    //public class InMemoryCompanyData : ICompanyData
    //{
    //    public List<Company> companies { get; set; }
    //    public InMemoryCompanyData()
    //    {
    //        companies = new List<Core.Company>()
    //        {
    //            new Core.Company{Id = 1,Name = "Anh quan", Location="Phu Da",CompanyType=Core.CompanyType.CNTT},
    //             new Core.Company{Id = 2,Name = "Anh quan Pro2", Location="Phu Da",CompanyType=Core.CompanyType.SaleHeaderHuman},
    //              new Core.Company{Id = 3,Name = "Anh Quan Vip3", Location="Phu Da",CompanyType=Core.CompanyType.Hotgirl}
    //        };
    //    }

    //    public IEnumerable<Company> GetAll()
    //    {
    //        return from c in companies
    //               orderby c.Name
    //               select c;
    //    }
    //}
    public class InMemoryCompanyData : ICompanyData
    {
        public InMemoryCompanyData()
        {

        }
        public Company Add()
        {
            throw new NotImplementedException();
        }

        //public Company Delete()
        //{
        //    var company = 
        //}

        public Company Edit()
        {
            throw new NotImplementedException();
        }

        public Company GetById(int id)
        {
           return context._.finds(id)
        }

        public IEnumerable<Company> GetByName(string name)
        {
           
        }

        public int Update(Company company)
        {
            var entity = context._.Attach(company);
            entity.State = EmtityState.Modified
        }
    }
}

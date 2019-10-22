using System;

namespace CompanyDemo.Core
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public CompanyType CompanyType { get; set; }
    }
}

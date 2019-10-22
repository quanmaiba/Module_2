using System;

namespace CompanyC7.Core
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Location { get; set; }
        public int MyProperty { get; set; }
        public CompanyType CompanyType { get; set; }
    }
}

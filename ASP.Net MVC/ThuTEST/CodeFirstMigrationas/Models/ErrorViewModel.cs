using System.ComponentModel.DataAnnotations;

namespace CodeFirstMigrationas.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        [Display()]
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);


    }
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Customer()
        {
            CustomerID = 1;
            Name = "quan";
            Address = "hue";
        }
    }
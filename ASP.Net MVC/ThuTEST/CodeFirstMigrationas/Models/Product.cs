using System.ComponentModel.DataAnnotations;

namespace CodeFirstMigrationas.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a valid Name")]
        //[StringLength(maximumLength:25,MinimumLength =10), ErrorMessage]
        [CreditCard(ErrorMessage ="Please enter a valid card No")]
        [Compare(otherProperty:"NewName",ErrorMessage ="New & Confirm Name does not match")]
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Racting { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid card email")]
        [Range(minimum:100,maximum:200, ErrorMessage = "Please enter a valid no betwen 100 & 200" )]
        [RegularExpression(pattern:"^Mr\\..*|^Mrs\\..*", ErrorMessage ="Name Must start with Mr")]
        public string EmailID { get; set; }
    }
}
